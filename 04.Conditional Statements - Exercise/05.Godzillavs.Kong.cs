using System;

namespace _05.Godzillavs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double movieBudget = double.Parse(Console.ReadLine());
            int statistsNumber = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());

            //Actions

            if (statistsNumber > 150)
            {
                clothingPrice = clothingPrice - (clothingPrice * 0.1);
            }

            double decor = movieBudget * 0.1;
            double clothing = clothingPrice * statistsNumber;
            double finalPriceMovie = clothing + decor;

            if (finalPriceMovie > movieBudget)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {(finalPriceMovie - movieBudget):f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {(movieBudget - finalPriceMovie):f2} leva left.");
            }
        }
    }
}
