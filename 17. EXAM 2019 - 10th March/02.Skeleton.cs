using System;

namespace _02.Skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int controlMinutes = int.Parse(Console.ReadLine());
            int controlSeconds = int.Parse(Console.ReadLine());
            double uleiLenght = double.Parse(Console.ReadLine());
            int secondsFor100Meters = int.Parse(Console.ReadLine());

            //ACTION
            double delaySeconds = (uleiLenght / 120) * 2.5;
            double finalTime = (uleiLenght / 100) * secondsFor100Meters - delaySeconds;

            double controlInSeconds = (controlMinutes * 60) + controlSeconds;

            if (finalTime <= controlInSeconds)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {finalTime:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {(finalTime - controlInSeconds):f3} second slower.");
            }
        }
    }
}
