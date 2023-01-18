using System;

namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int groupsNumber = int.Parse(Console.ReadLine());

            //Changeable
            int musalaClimbers = 0;
            int monblanClimbers = 0;
            int kilimandzharoClimbers = 0;
            int k2Climbers = 0;
            int everestClimbers = 0;

            double percentMusalaClimbers = 0;
            double percentMonblanClimbers = 0;
            double percentKilimandzharoClimbers = 0;
            double percentK2Climbers = 0;
            double percentEverestClimbers = 0;

            //Cycle
            for (int i = 1; i <= groupsNumber; i++)
            {
                //Input
                int participantsNumber = int.Parse(Console.ReadLine());

                if (participantsNumber >= 1 && participantsNumber <= 5)
                {
                    musalaClimbers += participantsNumber;
                }
                else if (participantsNumber >= 6 && participantsNumber <= 12)
                {
                    monblanClimbers += participantsNumber;
                }
                else if (participantsNumber >= 13 && participantsNumber <= 25)
                {
                    kilimandzharoClimbers += participantsNumber;
                }
                else if (participantsNumber >= 26 && participantsNumber <= 40)
                {
                    k2Climbers += participantsNumber;
                }
                else if (participantsNumber >= 41)
                {
                    everestClimbers += participantsNumber;
                }
            }

            double allClimbers = musalaClimbers + monblanClimbers + kilimandzharoClimbers + k2Climbers + everestClimbers;

            percentMusalaClimbers = musalaClimbers / allClimbers * 100;
            percentMonblanClimbers = monblanClimbers / allClimbers * 100;
            percentKilimandzharoClimbers = kilimandzharoClimbers / allClimbers * 100;
            percentK2Climbers = k2Climbers / allClimbers * 100;
            percentEverestClimbers = everestClimbers / allClimbers * 100;

            //Output
            Console.WriteLine($"{percentMusalaClimbers:f2}%");
            Console.WriteLine($"{percentMonblanClimbers:f2}%");
            Console.WriteLine($"{percentKilimandzharoClimbers:f2}%");
            Console.WriteLine($"{percentK2Climbers:f2}%");
            Console.WriteLine($"{percentEverestClimbers:f2}%");
        }
    }
}