using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Core.Interfaces;
using WildFarm.Factories.Interfaces;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        private readonly ICollection<IAnimal> animals;

        private IAnimalFactory animalFactory;
        private IFoodFactory foodFactory;

        public Engine(IReader reader, IWriter writer,
            IAnimalFactory animalFactory, IFoodFactory foodFactory)
        {
            this.reader = reader;
            this.writer = writer;

            this.animalFactory = animalFactory;
            this.foodFactory = foodFactory;

            animals = new List<IAnimal>();
        }

        public void Run()
        {
            string command;
            while ((command = reader.ReadLine()) != "End")
            {
                IAnimal animal = null;

                try
                {
                    animal = CreateAnimal(command);
                    IFood food = CreateFood();

                    writer.WriteLine(animal.ProduceSound());

                    animal.Eat(food);
                }
                catch(ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }
                catch (Exception)
                {
                    throw;
                }

                animals.Add(animal);
            }

            foreach (IAnimal animal in animals)
            {
                writer.WriteLine(animal.ToString());
            }
        }    

        private IAnimal CreateAnimal(string command)
        {
            string[] animalTokens = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            return animalFactory.CreateAnimal(animalTokens);
        }

        private IFood CreateFood()
        {
            string[] foodTokens = reader.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string foodType = foodTokens[0];
            int foodQuantiy = int.Parse(foodTokens[1]);

            return foodFactory.CreateFood(foodType, foodQuantiy);
        }
    }
}
