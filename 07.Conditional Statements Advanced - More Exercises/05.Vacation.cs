using System;

namespace _05.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string stayingLocation = null;
            string stayingPlace = null;
            double stayingPrice = 0;

            //ACTIONS
            // - Budgets
            if (budget <= 1000)
            {
                stayingPlace = "Camp";

                if (season == "Summer")
                {
                    stayingLocation = "Alaska";
                    stayingPrice = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    stayingLocation = "Morocco";
                    stayingPrice = budget * 0.45;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                stayingPlace = "Hut";

                if (season == "Summer")
                {
                    stayingLocation = "Alaska";
                    stayingPrice = budget * 0.80;
                }
                else if (season == "Winter")
                {
                    stayingLocation = "Morocco";
                    stayingPrice = budget * 0.60;
                }
            }
            else if (budget > 3000)
            {
                stayingPlace = "Hotel";

                if (season == "Summer")
                {
                    stayingLocation = "Alaska";
                    stayingPrice = budget * 0.90;
                }
                else if (season == "Winter")
                {
                    stayingLocation = "Morocco";
                    stayingPrice = budget * 0.90;
                }
            }

            //OUTPUT
            Console.WriteLine($"{stayingLocation} - {stayingPlace} - {stayingPrice:f2}");
        }
    }
}
