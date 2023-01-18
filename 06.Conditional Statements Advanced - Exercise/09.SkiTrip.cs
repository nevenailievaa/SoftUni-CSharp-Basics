using System;

namespace _08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int daysStay = int.Parse(Console.ReadLine()) - 1;
            string typeRoom = Console.ReadLine();
            string rating = Console.ReadLine();
            double finalPrice = 0;

            //Actions
            if (typeRoom == "room for one person")
            {
                finalPrice = daysStay * 18.00;
            }
            else if (typeRoom == "apartment")
            {
                finalPrice = daysStay * 25.00;

                if (daysStay < 10)
                {
                    finalPrice -= finalPrice * 0.3;
                }
                else if (daysStay >= 10 && daysStay <= 15)
                {
                    finalPrice -= finalPrice * 0.35;
                }
                else if (daysStay > 15)
                {
                    finalPrice -= finalPrice * 0.5;
                }
            }
            else if (typeRoom == "president apartment")
            {
                finalPrice = daysStay * 35.00;

                if (daysStay < 10)
                {
                    finalPrice -= finalPrice * 0.1;
                }
                else if (daysStay >= 10 && daysStay <= 15)
                {
                    finalPrice -= finalPrice * 0.15;
                }
                else if (daysStay > 15)
                {
                    finalPrice -= finalPrice * 0.2;
                }
            }

            //Rating
            if (rating == "positive")
            {
                finalPrice += finalPrice * 0.25;
            }
            else if (rating == "negative")
            {
                finalPrice -= finalPrice * 0.1;
            }

            //Output
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
