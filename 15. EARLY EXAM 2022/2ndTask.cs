using System;

namespace _02.GodzillaVs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int picturesTime = int.Parse(Console.ReadLine());
            int scenesCount = int.Parse(Console.ReadLine());
            int oneSceneTime = int.Parse(Console.ReadLine());

            //ACTION
            double terrainTime = picturesTime * 0.15;
            double scenesTimeSum = scenesCount * oneSceneTime;
            double allTimeSum = terrainTime + scenesTimeSum;

            //OUTPUT
            if (picturesTime >= allTimeSum)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(picturesTime - allTimeSum)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(allTimeSum - picturesTime)} minutes.");
            }
        }
    }
}
