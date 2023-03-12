using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double IncreasedConsumption = 1.4;

        public Bus(double fuelQuantiy, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantiy, fuelConsumption, tankCapacity, IncreasedConsumption)
        {
        }
    }
}
