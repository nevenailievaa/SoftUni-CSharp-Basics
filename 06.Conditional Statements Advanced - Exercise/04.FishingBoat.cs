using System;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberFishers = int.Parse(Console.ReadLine());
            double finalPrice = 0;


            //Actions

            //SeasonsPrices
            if (season == "Spring")
            {
                finalPrice = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                finalPrice = 4200;
            }
            else if (season == "Winter")
            {
                finalPrice = 2600;
            }

            //Discounts
            if (numberFishers <= 6)
            {
                finalPrice -= finalPrice * 0.1;
            }
            else if (numberFishers >= 7 && numberFishers <= 11)
            {
                finalPrice -= finalPrice * 0.15;
            }
            else if (numberFishers >= 12)
            {
                finalPrice -= finalPrice * 0.25;
            }

            //Additional Discount
            if ((season == "Winter" ||  season == "Summer" || season == "Spring"))
            {
                if (numberFishers % 2 == 0)
                {
                    finalPrice -= finalPrice * 0.05;
                }
            }


            //Output
            if (budget >= finalPrice)
            {
                Console.WriteLine($"Yes! You have {(budget - finalPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(finalPrice - budget):f2} leva.");
            }
        }
    }
}
