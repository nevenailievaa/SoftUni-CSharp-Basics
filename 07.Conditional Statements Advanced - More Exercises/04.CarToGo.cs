using System;

namespace _04.CarToGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string car = null;
            string carClass = null;
            double carBudget = 0;

            //ACTIONS
            if (budget <= 100)
            {
                carClass = "Economy class";

                if (season == "Summer")
                {
                    car = "Cabrio";
                    carBudget = budget * 0.35;
                }
                else if (season == "Winter")
                {
                    car = "Jeep";
                    carBudget = budget * 0.65;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                carClass = "Compact class";

                if (season == "Summer")
                {
                    car = "Cabrio";
                    carBudget = budget * 0.45;
                }
                else if (season == "Winter")
                {
                    car = "Jeep";
                    carBudget = budget * 0.80;
                }
            }
            else if (budget > 500)
            {
                carClass = "Luxury class";
                car = "Jeep";
                carBudget = budget * 0.90;
            }

            //OUTPUT
            Console.WriteLine(carClass);
            Console.WriteLine($"{car} - {carBudget:f2}");
        }
    }
}
