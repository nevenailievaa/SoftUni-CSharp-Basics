using System;

namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int tournirsParticipated = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            //Changeable
            int points = 0;
            int onlyPoints = 0;
            int allPoints = 0;
            int numberWonTournirs = 0;

            //Cycle
            for (int i = 1; i <= tournirsParticipated; i++)
            {
                //Input
                string tournirPosition = Console.ReadLine();

                if (tournirPosition == "W")
                {
                    points = 2000;
                    onlyPoints += 2000;
                    numberWonTournirs++;
                }
                else if (tournirPosition == "F")
                {
                    points = 1200;
                    onlyPoints += 1200;
                }
                else if (tournirPosition == "SF")
                {
                    points = 720;
                    onlyPoints += 720;
                }

                if (i == 1)
                {
                    allPoints = startingPoints + points;
                }
                else
                {
                    allPoints += points;
                }
            }

            int averagePoints = onlyPoints / tournirsParticipated;
            double percentWonTournirs = ((double)numberWonTournirs / tournirsParticipated) * 100;

            //Output
            Console.WriteLine($"Final points: {allPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{percentWonTournirs:f2}%");
        }
    }
}
