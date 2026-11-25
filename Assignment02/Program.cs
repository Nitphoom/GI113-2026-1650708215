// Student ID : 1650708215
// Name       : Nitiphoom Chuepet
// Section    : 129A
// No.        : 1
using System;

namespace Assignment02ห
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MaterialName = "Crystal";
            const double SmeltRate = 0.40;
            const double SalvageRate = 0.55;
            const double MaxBatch = 300;

            Console.WriteLine("==================================");
            Console.WriteLine("==    The Crystal Forge Shop    ==");
            Console.WriteLine("==================================");
            Console.WriteLine($"=> {MaterialName} Smelt Rate {SmeltRate} / Salvage Rate {SalvageRate}");
            Console.WriteLine("=> Press 'S' to Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Press 'B' to Breakdown (Ingot -> Ore)");

            Console.Write("=> Choose Menu: ");
            string menuText = Console.ReadLine();
            bool menuOk = char.TryParse(menuText, out char choice);

            Console.Write("=> How much would you like: ");
            string amountText = Console.ReadLine();
            bool amountOk = double.TryParse(amountText, out double quantity);

            if (amountOk && quantity > 0 && quantity <= MaxBatch)
            {
                if (menuOk && (choice == 'S' || choice == 's'))
                {
                    double ingotResult = quantity * SmeltRate;
                    Console.WriteLine($"=> {quantity:F2} {MaterialName} Ore = {ingotResult:F2} {MaterialName} Ingot");
                }
                else if (menuOk && (choice == 'B' || choice == 'b'))
                {
                    double oreResult = quantity / SalvageRate;
                    Console.WriteLine($"=> {quantity:F2} {MaterialName} Ingot = {oreResult:F2} {MaterialName} Ore");
                }
                else
                {
                    Console.WriteLine("Menu error: please type S for Smelt or B for Breakdown.");
                }
            }
            else
            {
                Console.WriteLine($"Amount error: please type a number above 0 and up to {MaxBatch}.");
            }
        }
    }
}