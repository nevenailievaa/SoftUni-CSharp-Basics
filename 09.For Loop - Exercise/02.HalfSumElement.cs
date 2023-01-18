using System;

namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int r = int.Parse(Console.ReadLine());
            int sumNumbers = 0;
            int max = int.MinValue;

            //Action
            for (int i = 0; i < r; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sumNumbers += number;

                if (number > max)
                {
                    max = number;
                }
            }

            int sumWithoutMaxNumber = sumNumbers - max;

            if (max == sumWithoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int diff =  Math.Abs(sumWithoutMaxNumber - max);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
