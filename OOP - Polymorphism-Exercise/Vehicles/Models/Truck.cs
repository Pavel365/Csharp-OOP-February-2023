using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double IncreasedConsumption = 1.6;

        public Truck(double fuelQuantiy, double fuelConsumption, double tankCapacity)
            : base(fuelQuantiy, fuelConsumption, tankCapacity, IncreasedConsumption)
        {
        }

        public override void Refuel(double amount)
        {
            if (amount + FuelQuantiy > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {amount} fuel in the tank");
            }

            base.Refuel(amount * 0.95);
        }
    }
}
