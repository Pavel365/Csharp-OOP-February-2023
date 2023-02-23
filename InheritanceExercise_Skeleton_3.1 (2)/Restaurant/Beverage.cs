using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Beverage : Product
    {
        public Beverage(string name, decimal price, double millilters) 
            : base(name, price)
        {
            Millilters = millilters;
        }

        public double Millilters { get; private set; }
    }
}
