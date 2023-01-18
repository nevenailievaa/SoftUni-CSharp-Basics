using System;

namespace _6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int procentFats = int.Parse(Console.ReadLine());
            int procentProteins = int.Parse(Console.ReadLine());
            int procentCarbohydrates = int.Parse(Console.ReadLine());
            int procentCalories = int.Parse(Console.ReadLine());
            int procentWater = int.Parse(Console.ReadLine());

            //ACTION
            double sumFats = (((double)procentFats / 100) * procentCalories) / 9;
            double sumProteins = (((double)procentProteins / 100) * procentCalories) / 4;
            double sumCarbohydrates = (((double)procentCarbohydrates / 100) * procentCalories) / 4;

            //OUTPUT
            double foodWeight = sumFats + sumProteins + sumCarbohydrates;
            double caloriesFor1GramFood = (procentCalories / foodWeight);

            double foodWithoutWaterPercent = 100 - procentWater;
            double foodWithoutWater = ((double)foodWithoutWaterPercent / 100) * caloriesFor1GramFood;


            Console.WriteLine($"{foodWithoutWater:f4}");
        }
    }
}
