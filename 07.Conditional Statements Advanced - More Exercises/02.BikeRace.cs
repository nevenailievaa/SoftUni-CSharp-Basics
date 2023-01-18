using System;

namespace _02.BikeRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int numberJuniorRiders = int.Parse(Console.ReadLine());
            int numberSeniorRiders = int.Parse(Console.ReadLine());
            string typeRoad = Console.ReadLine();

            double juniorsTax = 0;
            double seniorsTax = 0;
            double tax = 0;

            //Action
            if (typeRoad == "trail")
            {
                juniorsTax = numberJuniorRiders * 5.50;
                seniorsTax = numberSeniorRiders * 7.00;
                tax = juniorsTax + seniorsTax;
            }
            else if (typeRoad == "cross-country")
            {
                juniorsTax = numberJuniorRiders * 8.00;
                seniorsTax = numberSeniorRiders * 9.50;
                tax = juniorsTax + seniorsTax;

                if ((numberJuniorRiders + numberSeniorRiders) >= 50)
                {
                    tax -= tax * 0.25;
                }
            }
            else if (typeRoad == "downhill")
            {
                juniorsTax = numberJuniorRiders * 12.25;
                seniorsTax = numberSeniorRiders * 13.75;
                tax = juniorsTax + seniorsTax;
            }
            else if (typeRoad == "road")
            {
                juniorsTax = numberJuniorRiders * 20.00;
                seniorsTax = numberSeniorRiders * 21.50;
                tax = juniorsTax + seniorsTax;
            }

            tax -= tax * 0.05;
            Console.WriteLine($"{tax:f2}");
        }
    }
}
