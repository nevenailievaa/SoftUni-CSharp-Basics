using System;

namespace _03.OscarsWeekInCinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int staysCount = int.Parse(Console.ReadLine());

            //CHANGEABLE INPUT
            double staysSumPrice = 0;

            //ACTION
            //France
            if (destination == "France")
            {
                if (dates == "21-23")
                {
                    staysSumPrice = staysCount * 30;
                }
                else if (dates == "24-27")
                {
                    staysSumPrice = staysCount * 35;
                }
                else if (dates == "28-31")
                {
                    staysSumPrice = staysCount * 40;
                }
            }

            //Italy
            else if (destination == "Italy")
            {
                if (dates == "21-23")
                {
                    staysSumPrice = staysCount * 28;
                }
                else if (dates == "24-27")
                {
                    staysSumPrice = staysCount * 32;
                }
                else if (dates == "28-31")
                {
                    staysSumPrice = staysCount * 39;
                }
            }

            //Germany
            else if (destination == "Germany")
            {
                if (dates == "21-23")
                {
                    staysSumPrice = staysCount * 32;
                }
                else if (dates == "24-27")
                {
                    staysSumPrice = staysCount * 37;
                }
                else if (dates == "28-31")
                {
                    staysSumPrice = staysCount * 43;
                }
            }

            //OUTPUT
            Console.WriteLine($"Easter trip to {destination} : {staysSumPrice:f2} leva.");
        }
    }
}
