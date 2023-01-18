using System;

namespace _04.FoodForPets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = int.Parse(Console.ReadLine());

            int eatenFoodByCat = 0;
            int eatenFoodByDog = 0;

            double catSum = 0;
            double dogSum = 0;
            double sumAllDays = 0;
            double daySum = 0;

            double biscuits = 0;
            double biscuitsSum = 0;

            for (int i = 1; i <= days; i++)
            {
                eatenFoodByDog = int.Parse(Console.ReadLine());
                eatenFoodByCat = int.Parse(Console.ReadLine());

                catSum += eatenFoodByCat;
                dogSum += eatenFoodByDog;

                daySum = eatenFoodByCat + eatenFoodByDog;
                sumAllDays += daySum;

                if (i % 3 == 0)
                {
                    biscuits = Math.Round(daySum * 0.1);
                    biscuitsSum += biscuits;
                }
            }

            double percentEaten = (sumAllDays / food) * 100;
            double percentEatenDog = (dogSum / sumAllDays) * 100;
            double percentEatenCat = (catSum / sumAllDays) * 100;

            //OUTPUT
            Console.WriteLine($"Total eaten biscuits: {biscuitsSum}gr.");
            Console.WriteLine($"{percentEaten:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentEatenDog:f2}% eaten from the dog.");
            Console.WriteLine($"{percentEatenCat:f2}% eaten from the cat.");
        }
    }
}
