using System;

namespace _03.Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int numberChrysanthemums = int.Parse(Console.ReadLine());
            int numberRoses = int.Parse(Console.ReadLine());
            int numberTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            double chrysanthemumsPrice = 0;
            double rosesPrice = 0;
            double tulipsPrice = 0;
            double wholePrice = 0;

            //ACTIONS

            //Seasons
            if (season == "Spring" || season == "Summer")
            {
                chrysanthemumsPrice = numberChrysanthemums * 2.00;
                rosesPrice = numberRoses * 4.10;
                tulipsPrice = numberTulips * 2.50;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                chrysanthemumsPrice = numberChrysanthemums * 3.75;
                rosesPrice = numberRoses * 4.50;
                tulipsPrice = numberTulips * 4.15;
            }

            wholePrice = chrysanthemumsPrice + rosesPrice + tulipsPrice;

            //Holidays
            if (holiday == "Y")
            {
                wholePrice += wholePrice * 0.15;
            }
            else if (holiday == "N")
            {
                wholePrice = wholePrice;
            }

            //Discounts
            if (numberTulips > 7)
            {
                if (season == "Spring")
                {
                    wholePrice -= wholePrice * 0.05;
                }
            }

            if (numberRoses >= 10)
            {
                if (season == "Winter")
                {
                    wholePrice -= wholePrice * 0.1;
                }
            }

            if ((numberChrysanthemums + numberRoses + numberTulips) > 20)
            {
                wholePrice -= wholePrice * 0.2;
            }

            //OUTPUT
            double bouquetPrice = wholePrice + 2.00;
            Console.WriteLine($"{bouquetPrice:f2}");
        }
    }
}
