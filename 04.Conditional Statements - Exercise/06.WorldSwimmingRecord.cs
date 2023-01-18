using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double inputTheRecordInSeconds = double.Parse(Console.ReadLine());
            double inputTheDistanceInMeters = double.Parse(Console.ReadLine());
            double inputTheTimeForAMeter = double.Parse(Console.ReadLine());

            //Action
            double totalTime = inputTheDistanceInMeters * inputTheTimeForAMeter;
            double delay = Math.Floor(inputTheDistanceInMeters / 15);
            totalTime = totalTime + (delay * 12.5);

            if (totalTime < inputTheRecordInSeconds)
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            else
                Console.WriteLine($"No, he failed! He was {totalTime - inputTheRecordInSeconds:F2} seconds slower.");
        }
    }
}