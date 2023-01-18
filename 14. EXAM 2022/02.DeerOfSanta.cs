using System;

namespace _2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int daysMissing = int.Parse(Console.ReadLine());
            int leftFoodKilograms = int.Parse(Console.ReadLine());
            double firstDeerFoodPerDayKilograms = double.Parse(Console.ReadLine());
            double secondDeerFoodPerDayKilograms = double.Parse(Console.ReadLine());
            double thirdDeerFoodPerDayKilograms = double.Parse(Console.ReadLine());

            //ACTION
            double allTimeFirstDeerFood = daysMissing * firstDeerFoodPerDayKilograms;
            double allTimeSecondDeerFood = daysMissing * secondDeerFoodPerDayKilograms;
            double allTimeThirdDeerFood = daysMissing * thirdDeerFoodPerDayKilograms;

            double allNeededFood = allTimeFirstDeerFood + allTimeSecondDeerFood + allTimeThirdDeerFood;

            //OUTPUT
            if (leftFoodKilograms >= allNeededFood)
            {
                Console.WriteLine($"{Math.Floor(leftFoodKilograms - allNeededFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(allNeededFood - leftFoodKilograms)} more kilos of food are needed.");
            }
        }
    }
}
