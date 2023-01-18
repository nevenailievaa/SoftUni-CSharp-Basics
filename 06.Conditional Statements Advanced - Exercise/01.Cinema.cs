using System;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string typeProjection = Console.ReadLine();
            int numberRows = int.Parse(Console.ReadLine());
            int numberColumns = int.Parse(Console.ReadLine());
            int numberSeats = numberRows * numberColumns;
            double finalIncome = 0;

            //Actions
            if (typeProjection == "Premiere")
            {
                finalIncome = 12.00 * numberSeats;
            }
            else if (typeProjection == "Normal")
            {
                finalIncome = 7.50 * numberSeats;
            }
            else if (typeProjection == "Discount")
            {
                finalIncome = 5.00 * numberSeats;
            }

            //Output
            Console.WriteLine($"{finalIncome:f2} leva");
        }
    }
}
