using System;

namespace Homework_7
{
    internal class Pharmacy
    {
        static void Main(string[] args)
        {
            Medicines[] pharmacyMedicineBase = new Medicines[]
            {
                new Pills("Tropikamed", 20, 45),
                new Pills("Fenibud", 13, 20),
                new Salve("Konovad", 15, 25),
                new Salve("Grovid", 65, 50),
                new Syrup("Agusha", 15, "Box"),
                new Syrup("Doktor Mom", 25, "Glass bottle")
            };
            foreach (var medicine in pharmacyMedicineBase)
            {
                medicine.Print();
                medicine.HowToUse();
                Console.WriteLine();
            }

        }
    }
}
