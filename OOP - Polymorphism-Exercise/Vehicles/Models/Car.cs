using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double IncreasedConsumption = 0.9;

        public Car(double fuelQuantiy, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantiy, fuelConsumption, tankCapacity, IncreasedConsumption)
        {
        }
    }
}
