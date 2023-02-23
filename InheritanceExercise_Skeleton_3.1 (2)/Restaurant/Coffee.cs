using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const decimal CoffeePrice = 3.50m;
        private const double CoffeeMilliliters = 50;

        public Coffee(string name, double caffein) 
            : base(name, CoffeePrice, CoffeeMilliliters)
        {
           Caffeine = caffein;
        }

        public double Caffeine { get; private set; }
    }
}
