using System;

namespace _05.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int tournirsNumber = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            //CHANGEABLE INPUT
            string gameStatus;
            int sumPoints = 0;
            int wonTournirs = 0;

            //ACTION
            for (int i = 1; i <= tournirsNumber; i++)
            {
                gameStatus = Console.ReadLine();

                //WIN
                if (gameStatus == "W")
                {
                    sumPoints += 2000;
                    wonTournirs++;
                }
                //FINAL
                else if (gameStatus == "F")
                {
                    sumPoints += 1200;
                }
                //SEMI-FINAL
                else if (gameStatus == "SF")
                {
                    sumPoints += 720;
                }
            }

            int finalPoints = sumPoints + startingPoints;

            //OUTPUT
            double averagePoints = (double)sumPoints / tournirsNumber;
            double wonTournirsPercent = (double)wonTournirs / tournirsNumber * 100;

            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{wonTournirsPercent:f2}%");
        }
    }
}
