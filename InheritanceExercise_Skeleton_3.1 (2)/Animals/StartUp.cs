using System;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string animalType = Console.ReadLine();
                if (animalType == "Beast!")
                {
                    break;
                }

                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                try
                {
                    switch (animalType)
                    {
                        case "Dog":
                            Dog dog = new Dog(tokens[0], int.Parse(tokens[1]), tokens[2]);
                            Console.WriteLine(animalType);
                            Console.WriteLine(dog);
                            break;
                        case "Frog":
                            Frog frog = new Frog(tokens[0], int.Parse(tokens[1]), tokens[2]);
                            Console.WriteLine(animalType);
                            Console.WriteLine(frog);
                            break;
                        case "Cat":
                            Cat cat = new Cat(tokens[0], int.Parse(tokens[1]), tokens[2]);
                            Console.WriteLine(animalType);
                            Console.WriteLine(cat);
                            break;
                        case "Kitten":
                            Kitten kittens = new Kitten(tokens[0], int.Parse(tokens[1]));
                            Console.WriteLine(animalType);
                            Console.WriteLine(kittens);
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(tokens[0], int.Parse(tokens[1]));
                            Console.WriteLine(animalType);
                            Console.WriteLine(tomcat);
                            break;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
