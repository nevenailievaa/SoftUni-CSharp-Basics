using System;

namespace _05.Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            double budget = double.Parse(Console.ReadLine());
            int numberSeries = int.Parse(Console.ReadLine());

            //CHANGEABLE INPUT
            string seriesName = null;
            double priceForSeries = 0;

            double finalPrice = 0;

            //ACTION
            for (int i = 1; i <= numberSeries; i++)
            {
                seriesName = Console.ReadLine();
                priceForSeries = double.Parse(Console.ReadLine());

                if (seriesName == "Thrones")
                {
                    priceForSeries -= priceForSeries * 0.5;
                }
                else if (seriesName == "Lucifer")
                {
                    priceForSeries -= priceForSeries * 0.4;
                }
                else if (seriesName == "Protector")
                {
                    priceForSeries -= priceForSeries * 0.3;
                }
                else if (seriesName == "TotalDrama")
                {
                    priceForSeries -= priceForSeries * 0.2;
                }
                else if (seriesName == "Area")
                {
                    priceForSeries -= priceForSeries * 0.1;
                }

                finalPrice += priceForSeries;
            }

            //OUTPUT
            if (budget >= finalPrice)
            {
                Console.WriteLine($"You bought all the series and left with {(budget - finalPrice):f2} lv.");
                return;
            }
            else
            {
                Console.WriteLine($"You need {(finalPrice - budget):f2} lv. more to buy the series!");
            }
        }
    }
}
