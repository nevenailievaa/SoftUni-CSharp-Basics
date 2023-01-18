using System;

namespace _03.Gymnastics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT//
            string country = Console.ReadLine();
            string instrument = Console.ReadLine();

            //CHANGEABLE INPUT//
            double difficultyPoints = 0;
            double performancePoints = 0;

            double maxPoints = 20;

            //ACTION//

            //RUSSIA
            if (country == "Russia")
            {
                if (instrument == "ribbon")
                {
                    difficultyPoints = 9.100;
                    performancePoints = 9.400;
                }
                else if (instrument == "hoop")
                {
                    difficultyPoints = 9.300;
                    performancePoints = 9.800;
                }
                else if (instrument == "rope")
                {
                    difficultyPoints = 9.600;
                    performancePoints = 9.000;
                }
            }
            //BULGARIA
            else if (country == "Bulgaria")
            {
                if (instrument == "ribbon")
                {
                    difficultyPoints = 9.600;
                    performancePoints = 9.400;
                }
                else if (instrument == "hoop")
                {
                    difficultyPoints = 9.550;
                    performancePoints = 9.750;
                }
                else if (instrument == "rope")
                {
                    difficultyPoints = 9.500;
                    performancePoints = 9.400;
                }
            }
            //ITALY
            else if (country == "Italy")
            {
                if (instrument == "ribbon")
                {
                    difficultyPoints = 9.200;
                    performancePoints = 9.500;
                }
                else if (instrument == "hoop")
                {
                    difficultyPoints = 9.450;
                    performancePoints = 9.350;
                }
                else if (instrument == "rope")
                {
                    difficultyPoints = 9.700;
                    performancePoints = 9.150;
                }
            }

            //OUTPUT
            double finalPoints = difficultyPoints + performancePoints;
            Console.WriteLine($"The team of {country} get {finalPoints:f3} on {instrument}.");

            double neededPoints = maxPoints - finalPoints;
            double percentNeededPoints = (neededPoints/maxPoints) * 100;
            Console.WriteLine($"{percentNeededPoints:f2}%");
        }
    }
}
