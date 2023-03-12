using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Food;

namespace WildFarm.Models.Animals
{
    public class Hen : Bird
    {
        private const double HenWeightMultiplyer = 0.35;

        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override double WeightMultiplyer => HenWeightMultiplyer;

        public override IReadOnlyCollection<Type> PreferredFood
            => new HashSet<Type> { typeof(Meat), typeof(Fruit), typeof(Seeds), typeof(Vegetable) };

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
