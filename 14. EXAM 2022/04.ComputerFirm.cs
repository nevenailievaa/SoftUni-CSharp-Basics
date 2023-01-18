using System;
using System.Reflection.Emit;
using System.Xml;

namespace _4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int computersCount = int.Parse(Console.ReadLine());

            //CHANGEABLE INPUT
            double numberMadeSells = 0;
            int sellsSum = 0;
            int ratingSum = 0;

            //ACTION
            for (int i = 1; i <= computersCount; i++)
            {
                int sellsAndRating = int.Parse(Console.ReadLine());
                int rating = sellsAndRating % 10;
                int sells = sellsAndRating / 10;

                ratingSum += rating;

                if (rating == 2)
                {
                    numberMadeSells += ((double)sells) * 0.0;
                }
                else if (rating == 3)
                {
                    numberMadeSells += ((double)sells) * 0.5;
                }
                else if (rating == 4)
                {
                    numberMadeSells += ((double)sells) * 0.7;
                }
                else if (rating == 5)
                {
                    numberMadeSells += ((double)sells) * 0.85;
                }
                else if (rating == 6)
                {
                    numberMadeSells += ((double)sells) * 1;
                }
            }

            //OUTPUT
            Console.WriteLine($"{numberMadeSells:f2}");
            double averageRating = ((double)ratingSum) / computersCount;
            Console.WriteLine($"{averageRating:f2}");
        }
    }
}
