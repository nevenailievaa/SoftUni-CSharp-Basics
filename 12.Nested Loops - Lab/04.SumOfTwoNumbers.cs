using System;

namespace _04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            int allCombinations = 0;
            int validCombinations = 0;

            //ACTION
            for (int i = start; i <= finish; i++)
            {
                for (int j = start; j <= finish; j++)
                {
                    allCombinations++;

                    if (i + j == number)
                    {
                        validCombinations++;
                        Console.WriteLine($"Combination N:{allCombinations} ({i} + {j} = {number})");
                        return;
                    }
                }
            }
            if (validCombinations == 0)
            {
                Console.WriteLine($"{allCombinations} combinations - neither equals {number}");
            }
        }
    }
}
