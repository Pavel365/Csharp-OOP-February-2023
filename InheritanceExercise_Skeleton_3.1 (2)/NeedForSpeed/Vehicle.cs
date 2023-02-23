using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            HoresePower = horsePower;
            Fuel = fuel;
        }

        private const double DefaultFuelConsumption = 1.25;

        public int HoresePower { get; set; }

        public double Fuel { get; set; }

        public virtual double FuelConsumption => DefaultFuelConsumption;

        public virtual void Drive(double km)
        {
            Fuel -= km * FuelConsumption;
        }
    }
}
