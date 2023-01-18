using System;

namespace _04_1_TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int numberGroups = int.Parse(Console.ReadLine());

            int musalaParticipants = 0;
            int monblanParticipants = 0;
            int kilimandzharoParticipants = 0;
            int k2Participants = 0;
            int everestParticipants = 0;

            //ACTION
            for (int i = 1; i <= numberGroups; i++)
            {
                int numberParticipants = int.Parse(Console.ReadLine());

                if (numberParticipants <= 5)
                {
                    musalaParticipants += numberParticipants;
                }
                else if (numberParticipants >= 6 && numberParticipants <= 12)
                {
                    monblanParticipants += numberParticipants;
                }
                else if (numberParticipants >= 13 && numberParticipants <= 25)
                {
                    kilimandzharoParticipants += numberParticipants;
                }
                else if (numberParticipants >= 26 && numberParticipants <= 40)
                {
                    k2Participants += numberParticipants;
                }
                else if (numberParticipants > 40)
                {
                    everestParticipants += numberParticipants;
                }
            }

            //CALCULATIONS
            double allParticipants = musalaParticipants + monblanParticipants + kilimandzharoParticipants + k2Participants + everestParticipants;        
            double musalaPercent = (musalaParticipants / allParticipants) * 100.00;
            double monblanPercent = (monblanParticipants / allParticipants) * 100.00;
            double kilimandzharoPercent = (kilimandzharoParticipants / allParticipants) * 100.00;
            double k2Percent = (k2Participants / allParticipants) * 100.00;
            double everestPercent = (everestParticipants / allParticipants) * 100.00;

            //OUTPUT
            Console.WriteLine($"{musalaPercent:f2}%");
            Console.WriteLine($"{monblanPercent:f2}%");
            Console.WriteLine($"{kilimandzharoPercent:f2}%");
            Console.WriteLine($"{k2Percent:f2}%");
            Console.WriteLine($"{everestPercent:f2}%");
        }
    }
}
