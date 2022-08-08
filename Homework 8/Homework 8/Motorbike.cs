using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8
{
    internal class Motorbike : Vehicle, ITaxi
    {
        private double _taxiPrice;
        public Motorbike(string vehicleName, double fuelConsumption, double vehicleLicense, double taxiPrice) : base(fuelConsumption, vehicleLicense)
        {
            VehicleName = vehicleName;
            TaxiPrice = taxiPrice;
        }
        public string VehicleName { get; set; }

     

        public double TaxiPrice
        {
            get 
            {    
                return _taxiPrice;
            }
            set 
            {
                if (value <= 1)
                {
                    _taxiPrice = 1;
                }
                else
                {
                    _taxiPrice = value;
                }
            }
        }
        public override string ToString()
        {
            return $"Motorbike \"{VehicleName}\", license {VehicleLicense}, fuel consumption {FuelConsumption}, price {TaxiPrice}";
        }

        public override double GetPriceOfRide()
        {
            return TaxiPrice;
        }

        public override void MakeRide(User user)
        {
            Console.WriteLine($"{user.Name} {user.Surname} made ride on {ToString()}");
        }
    }
}
