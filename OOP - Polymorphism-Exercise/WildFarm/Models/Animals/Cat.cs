using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Food;

namespace WildFarm.Models.Animals
{
    public class Cat : Feline
    {
        private const double CatWeightMultiplyer = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightMultiplyer => CatWeightMultiplyer;

        public override IReadOnlyCollection<Type> PreferredFood 
            => new HashSet<Type> { typeof(Meat), typeof(Fruit), typeof(Seeds), typeof(Vegetable) };

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
