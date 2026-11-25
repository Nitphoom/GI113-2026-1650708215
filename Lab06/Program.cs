// Student ID : 1650708215
// Name       : Nitiphoom Chuepet
// Section    : 129A
// No.        : 1
using System;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CRYSTAL CAVE EXPEDITION ===");
            Console.WriteLine("You stand at the mouth of a dark cave.");
            Console.WriteLine("PATH L: LEFT TUNNEL (needs 5 torches)");
            Console.WriteLine("PATH R: RIGHT TUNNEL (needs 3 torches)");
            Console.WriteLine("PATH C: CAMP AND REST");
            Console.WriteLine();

            Console.Write("How many torches do you carry (0-10)? ");
            bool torchOk = int.TryParse(Console.ReadLine(), out int torches);
            Console.Write("Choose your path: ");
            bool pathOk = char.TryParse(Console.ReadLine(), out char path);

            if (!torchOk || torches < 0 || torches > 10)
            {
                Console.WriteLine("Invalid torch count. Please enter a whole number from 0 to 10.");
            }
            else if (pathOk && (path == 'L' || path == 'l'))
            {
                if (torches >= 5)
                {
                    Console.WriteLine($"Your {torches} torches light the whole tunnel. You find a glowing crystal!");
                }
                else
                {
                    Console.WriteLine($"{torches} torches are not enough. You get lost in the dark and return empty-handed.");
                }
            }
            else if (pathOk && (path == 'R' || path == 'r'))
            {
                if (torches >= 3)
                {
                    Console.WriteLine($"The light of {torches} torches scares the bats away. You cross the tunnel safely.");
                }
                else
                {
                    Console.WriteLine($"With only {torches} torches the bats attack you. You run back to the entrance.");
                }
            }
            else if (pathOk && (path == 'C' || path == 'c'))
            {
                Console.WriteLine($"You rest at camp and keep your {torches} torches for tomorrow.");
            }
            else
            {
                Console.WriteLine("Invalid path. Please choose L, R or C.");
            }
        }
    }
}