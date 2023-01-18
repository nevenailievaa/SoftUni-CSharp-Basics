using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int freeWidth = int.Parse(Console.ReadLine());
            int freeLidth = int.Parse(Console.ReadLine());
            int freeHeight = int.Parse(Console.ReadLine());

            int spaceSum = freeWidth * freeLidth * freeHeight;

            int numberBoxes = 0;

            int filledSpace = 0;

            //ACTION
            while (true)
            {
                string command = Console.ReadLine();

                if (command != "Done")
                {
                    numberBoxes = int.Parse(command);
                    filledSpace += numberBoxes;

                    if (spaceSum <= filledSpace)
                    {
                        Console.WriteLine($"No more free space! You need {filledSpace - spaceSum} Cubic meters more.");
                        return;
                    }
                }
                else
                {
                    if (spaceSum <= filledSpace)
                    {
                        Console.WriteLine($"No more free space! You need {filledSpace - spaceSum} Cubic meters more.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{spaceSum - filledSpace} Cubic meters left.");
                        return;
                    }
                }
            }
        }
    }
}
