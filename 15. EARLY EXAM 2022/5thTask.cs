using System;
using System.Data;

namespace _05.MovieRatings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            string playerName = Console.ReadLine();

            //CHANGEABLE INPUT
            string command = null;
            string typeShoot = null;
            int points = 0;
            int pointsSum = 301;

            int successShoots = 0;
            int failShoots = 0;

            //ACTION
            while ((command = Console.ReadLine()) != "Retire")
            {
                typeShoot = command;
                points = int.Parse(Console.ReadLine());

                //Single
                if (typeShoot == "Single")
                {
                    pointsSum -= points;
                }
                //Double
                else if (typeShoot == "Double")
                {
                    points *= 2;
                    pointsSum -= points;
                }
                //Triple
                else if (typeShoot == "Triple")
                {
                    points *= 3;
                    pointsSum -= points;
                }

                //0
                if (pointsSum < 0)
                {
                    pointsSum += points;
                    failShoots++;
                }
                else if (pointsSum > 0)
                {
                    successShoots++;
                }
                else if (pointsSum == 0)
                {
                    successShoots++;
                    Console.WriteLine($"{playerName} won the leg with {successShoots} shots.");
                    return;
                }
            }

            //OUTPUT
            Console.WriteLine($"{playerName} retired after {failShoots} unsuccessful shots.");
        }
    }
}
