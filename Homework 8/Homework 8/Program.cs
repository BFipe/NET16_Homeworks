using System;
using System.Collections.Generic;

namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Ilya", "Maximov", "872613526");
            List<Vehicle> TaxiVehicles = new List<Vehicle>
            {
                new Car ("Mazda", 12, 145672, 10.5d),
                new Helicopter ("MR-12", 45, 567819, 20d),
                new Motorbike ("Zigul", 8, 123574, 7.5d),
                new Car ("Bentley", 20, 432672, 22d),
                new Helicopter ("TT-16", 90, 512349, 40d),
                new Motorbike ("Moped-1", 4, 543274, 5d)
            };

            
            string menu = string.Empty;


            while (true)
            {
                string taxiCardName, cardName, paymentMethod = string.Empty;
                double moneyAmmount = 0;
                bool parseStatus = false, paymentStatus = false;
                int vehicleType = 0;

                Console.Clear();
                Console.Write(@"----------------------------------------------
Welcome to our ITaxi service!
Select your option:
1 - Add card
2 - Top up card
3 - Top up cash
4 - Show all possible payment methods
5 - Make a ride
6 - Exit service
----------------------------------------------
");
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":

                        Console.WriteLine("Enter your card name");
                        taxiCardName = Console.ReadLine();
                        Console.WriteLine("Enter your card system (Viisa, Mastirkard, KryshechkiOtKoly etc.)");
                        cardName = Console.ReadLine();
                        while (!parseStatus)
                        {
                            Console.WriteLine("Enter your money ammount");
                            parseStatus = double.TryParse(Console.ReadLine(), out moneyAmmount);
                        }

                        user.AddCard(taxiCardName, new Card(cardName, moneyAmmount));
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;



                    case "2":
                        Console.WriteLine("Enter your card name");
                        taxiCardName = Console.ReadLine();
                        while (!parseStatus || moneyAmmount < 0)
                        {
                            Console.WriteLine("Enter your money ammount");
                            parseStatus = double.TryParse(Console.ReadLine(), out moneyAmmount);
                        }
                        user.TopUpCard(moneyAmmount, taxiCardName);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;



                    case "3":
                        while (!parseStatus || moneyAmmount < 0)
                        {
                            Console.WriteLine("Enter your money ammount");
                            parseStatus = double.TryParse(Console.ReadLine(), out moneyAmmount);
                        }
                        user.TopUpCash(moneyAmmount);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;



                    case "4":
                        user.ShowAvailablePaymentMethods();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;



                    case "5":
                        while (!parseStatus || vehicleType < 0 || vehicleType > 6)
                        {
                            Console.WriteLine("Select your vehicle");
                            for (int i = 0; i < TaxiVehicles.Count; i++)
                            {
                                Console.WriteLine($"{i} - {TaxiVehicles[i].ToString()}");
                            }
                            parseStatus = int.TryParse(Console.ReadLine(), out vehicleType);
                        }

                        while (!paymentStatus)
                        {
                            Console.WriteLine("Select your payment type (Enter \"Cash\", \"Points\" or your card name)");
                            user.ShowAvailablePaymentMethods();
                            paymentMethod = Console.ReadLine();
                            paymentStatus = user.isPaymetExist(paymentMethod);
                        }
                        Console.WriteLine();
                        paymentStatus = user.Payment(paymentMethod, TaxiVehicles[vehicleType].GetPriceOfRide());

                        if (paymentStatus)
                        {
                            TaxiVehicles[vehicleType].MakeRide(user);
                            user.AddPoints(5);
                        }
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;




                    case "6":
                        Console.WriteLine("Thank you for using our ITaxi service!");
                        return;




                    default:
                        break;
                }















            }
        }
    }
}
