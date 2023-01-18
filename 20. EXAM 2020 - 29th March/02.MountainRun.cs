
using System;

namespace _02_1_MountainRun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            //ACTION
            double timeForClimbing = distanceInMeters * timeForOneMeter;
            double delaySeconds = (Math.Floor(distanceInMeters / 50)) * 30;
            double finalClimbingInSeconds = timeForClimbing + delaySeconds;

            if (recordInSeconds <= finalClimbingInSeconds)
            {
                Console.WriteLine($"No! He was {(finalClimbingInSeconds - recordInSeconds):f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes! The new record is {finalClimbingInSeconds:f2} seconds.");
            }
        }
    }
}
