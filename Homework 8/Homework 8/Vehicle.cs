using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8
{
    internal abstract class Vehicle
    {
        public Vehicle(double fuelConsumption, double vehicleLicense)
        {
            FuelConsumption = fuelConsumption;
            VehicleLicense = vehicleLicense;
        }
        public double FuelConsumption { get; set; }
        public double VehicleLicense { get; set; }
        public abstract double GetPriceOfRide();
        public abstract void MakeRide(User user);
    }
}

