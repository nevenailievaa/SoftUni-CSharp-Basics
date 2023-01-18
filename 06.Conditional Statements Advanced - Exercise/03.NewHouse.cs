using System;
using System.Diagnostics.Tracing;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string typeFlowers = Console.ReadLine();
            int numberFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double flowersPrice = 0;
            double flowersFinalPrice = 0;
            double priceWithDiscount = 0;

            double remainingAmount = 0;

            //Actions
            if (typeFlowers == "Roses")
            {
                if (numberFlowers > 80)
                {
                    flowersPrice = 5.00 * numberFlowers;
                    priceWithDiscount = flowersPrice - (flowersPrice * 0.1);
                    flowersFinalPrice = priceWithDiscount;
                }
                else
                {
                    flowersFinalPrice = 5.00 * numberFlowers;
                }
            }
            else if (typeFlowers == "Dahlias")
            {
                if (numberFlowers > 90)
                {
                    flowersPrice = 3.80 * numberFlowers;
                    priceWithDiscount = flowersPrice - (flowersPrice * 0.15);
                    flowersFinalPrice = priceWithDiscount;
                }
                else
                {
                    flowersFinalPrice = 3.80 * numberFlowers;
                }
            }
            else if (typeFlowers == "Tulips")
            {
                if (numberFlowers > 80)
                {
                    flowersPrice = 2.80 * numberFlowers;
                    priceWithDiscount = flowersPrice - (flowersPrice * 0.15);
                    flowersFinalPrice = priceWithDiscount;
                }
                else
                {
                    flowersFinalPrice = 2.80 * numberFlowers;
                }
            }
            else if (typeFlowers == "Narcissus")
            {
                if (numberFlowers < 120)
                {
                    flowersPrice = 3.00 * numberFlowers;
                    priceWithDiscount = flowersPrice + (flowersPrice * 0.15);
                    flowersFinalPrice = priceWithDiscount;
                }
                else
                {
                    flowersFinalPrice = 3.00 * numberFlowers;
                }
            }
            else if (typeFlowers == "Gladiolus")
            {
                if (numberFlowers < 80)
                {
                    flowersPrice = 2.50 * numberFlowers;
                    priceWithDiscount = flowersPrice + (flowersPrice * 0.20);
                    flowersFinalPrice = priceWithDiscount;
                }
                else
                {
                    flowersFinalPrice = 2.50 * numberFlowers;
                }
            }
             
            //Output

            if (budget >= flowersFinalPrice)
            {
                remainingAmount = budget - flowersFinalPrice;
                Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {typeFlowers} and {remainingAmount:f2} leva left.");
            }
            else
            {
                remainingAmount = flowersFinalPrice - budget;
                Console.WriteLine($"Not enough money, you need {remainingAmount:f2} leva more.");
            }
        }
    }
}