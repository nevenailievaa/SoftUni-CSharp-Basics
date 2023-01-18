using System;

namespace _04.Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            string playerName = Console.ReadLine();
            int currentPoints = 301;
            string command = null;
            int successfulShots = 0;
            int unsuccessfulShots = 0;

            //ACTION
            while ((command = Console.ReadLine()) != "Retire")
            {
                string gameSector = command;
                int pointsInput = int.Parse(Console.ReadLine());

                //Single
                if (gameSector == "Single")
                {
                    currentPoints -= pointsInput;
                }

                //Double
                if (gameSector == "Double")
                {
                    currentPoints -= pointsInput * 2;
                }

                //Triple
                if (gameSector == "Triple")
                {
                    currentPoints -= pointsInput * 3;
                }

                //Final

                //<0
                if (currentPoints < 0)
                {
                    unsuccessfulShots++;

                    if (gameSector == "Single")
                    {
                        currentPoints += pointsInput;
                    }
                    else if (gameSector == "Double")
                    {
                        currentPoints += pointsInput * 2;
                    }
                    else if (gameSector == "Triple")
                    {
                        currentPoints += pointsInput * 3;
                    }
                    continue;
                }

                //>0
                else if (currentPoints > 0)
                {
                    successfulShots++;
                    continue;
                }

                //=0
                else
                {
                    successfulShots++;
                    Console.WriteLine($"{playerName} won the leg with {successfulShots} shots.");
                    return;
                }

            }

            Console.WriteLine($"{playerName} retired after {unsuccessfulShots} unsuccessful shots.");
        }
    }
}
