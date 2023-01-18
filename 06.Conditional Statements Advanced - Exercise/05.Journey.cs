using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = null;
            string stayPlace = null;
            double finalPrice = 0;

            //Actions
            if (budget <= 100)
            {
                destination = "Bulgaria";
                
                if (season == "summer")
                {
                    finalPrice = budget * 0.3;
                    stayPlace = "Camp";
                }
                else if (season == "winter")
                {
                    stayPlace = "Hotel";
                    finalPrice = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    stayPlace = "Camp";
                    finalPrice = budget * 0.4;
                }
                else if (season == "winter")
                {
                    stayPlace = "Hotel";
                    finalPrice = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                stayPlace = "Hotel";
                finalPrice = budget * 0.9;
            }

            //Output
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{stayPlace} - {finalPrice:f2}");
        }
    }
}
