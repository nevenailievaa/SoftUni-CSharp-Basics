using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double budget = double.Parse(Console.ReadLine());
            int numberVideoCards = int.Parse(Console.ReadLine());
            int numberProcessors = int.Parse(Console.ReadLine());
            int numberMemories = int.Parse(Console.ReadLine());

            //Prices
            double videoCardsPrice = numberVideoCards * 250;
            double processorsPrice = numberProcessors * (0.35 * videoCardsPrice);
            double memoriesPrice = numberMemories * (0.10 * videoCardsPrice);

            //Action
            double bill = videoCardsPrice + processorsPrice + memoriesPrice;

            if (numberVideoCards > numberProcessors)
            {
                bill = bill - (bill * 0.15);
            }
            if (budget >= bill)
            {
                Console.WriteLine($"You have {(budget - bill):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(bill - budget):f2} leva more!");
            }
        }
    }
}
