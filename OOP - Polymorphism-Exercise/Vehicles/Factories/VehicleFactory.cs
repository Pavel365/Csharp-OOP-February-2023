using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Factories.Interfaces;
using Vehicles.Models;
using Vehicles.Models.Interfaces;

namespace Vehicles.Factories
{
    public class VehicleFactory : IVehicleFactory

    {
        public IVehicle Create(string type, double fuelQuantiy, double fuelConsumption, double tankCapacity)
        {
            switch (type)
            {
                case "Car":
                    return new Car(fuelQuantiy, fuelConsumption, tankCapacity);
                case "Truck":
                    return new Truck(fuelQuantiy, fuelConsumption, tankCapacity);
                case "Bus":
                    return new Bus(fuelQuantiy, fuelConsumption, tankCapacity);
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
}
