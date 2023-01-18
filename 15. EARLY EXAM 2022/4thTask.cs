using System;

namespace _04.CinemaVoucher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int paintedEggsCount = int.Parse(Console.ReadLine());
            string eggColor = Console.ReadLine();

            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
            int allEggsCount = 0;

            int maxEggs = int.MinValue;
            string maxEggsColor = null;

            //ACTION
            for (int i = 1; i <= paintedEggsCount; i++)
            {
                if (eggColor == "red")
                {
                    redEggs++;
                    allEggsCount++;

                    if (redEggs > maxEggs)
                    {
                        maxEggs = redEggs;
                        maxEggsColor = "red";
                    }
                }
                else if (eggColor == "orange")
                {
                    orangeEggs++;
                    allEggsCount++;

                    if (orangeEggs > maxEggs)
                    {
                        maxEggs = orangeEggs;
                        maxEggsColor = "orange";
                    }
                }
                else if (eggColor == "blue")
                {
                    blueEggs++;
                    allEggsCount++;

                    if (blueEggs > maxEggs)
                    {
                        maxEggs = blueEggs;
                        maxEggsColor = "blue";
                    }
                }
                else if (eggColor == "green")
                {
                    greenEggs++;
                    allEggsCount++;

                    if (greenEggs > maxEggs)
                    {
                        maxEggs = greenEggs;
                        maxEggsColor = "green";
                    }
                }

                //RESTART
                if (i < paintedEggsCount)
                {
                    eggColor = Console.ReadLine();
                }  
            }

            //OUTPUT
            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {maxEggsColor}");
        }
    }
}
