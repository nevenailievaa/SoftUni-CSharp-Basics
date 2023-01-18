using System;

namespace _03.EnergyBooster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            string fruitInput = Console.ReadLine();
            string sizeSets = Console.ReadLine();
            int countSets = int.Parse(Console.ReadLine());

            double fruitPrice = 0;

            //ACTION
            if (sizeSets == "small")
            {
                if (fruitInput == "Watermelon")
                {
                    fruitPrice = 56.00 * 2;
                }
                else if (fruitInput == "Mango")
                {
                    fruitPrice = 36.66 * 2;
                }
                else if (fruitInput == "Pineapple")
                {
                    fruitPrice = 42.10 * 2;
                }
                else if (fruitInput == "Raspberry")
                {
                    fruitPrice = 20.00 * 2;
                }
            }
            else if (sizeSets == "big")
            {
                if (fruitInput == "Watermelon")
                {
                    fruitPrice = 28.70 * 5;
                }
                else if (fruitInput == "Mango")
                {
                    fruitPrice = 19.60 * 5;
                }
                else if (fruitInput == "Pineapple")
                {
                    fruitPrice = 24.80 * 5;
                }
                else if (fruitInput == "Raspberry")
                {
                    fruitPrice = 15.20 * 5;
                }
            }

            double finalBill = fruitPrice * countSets;
            double discount = 0;

            if (finalBill >= 400 && finalBill <= 1000)
            {
                discount = 0.15;
                finalBill -= (finalBill * discount);
            }
            else if (finalBill > 1000)
            {
                discount = 0.50;
                finalBill -= (finalBill * discount);
            }

            //OUTPUT
            Console.WriteLine($"{finalBill:f2} lv.");
        }
    }
}
