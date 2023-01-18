using System;

namespace _02.CatWalking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int minutesWalkPerDay = int.Parse(Console.ReadLine());  
            int walksPerDay = int.Parse(Console.ReadLine());
            int caloriesPerDay = int.Parse(Console.ReadLine());

            //ACTION
            int dayWalksMinutesSum = walksPerDay * minutesWalkPerDay;
            int caloriesBurn = dayWalksMinutesSum * 5;

            double neededBurnCalories = caloriesPerDay * 0.5;

            if (caloriesBurn > neededBurnCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurn}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurn}.");
            }
        }
    }
}
