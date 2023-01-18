using System;

namespace _10.OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;
            int sum = 0;

            //Action
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    int numEven = int.Parse(Console.ReadLine());
                    sumEven += numEven;
                }
                else
                {
                    int numOdd = int.Parse(Console.ReadLine());
                    sumOdd += numOdd;
                }
            }

            //Output
            if (sumEven == sumOdd )
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sumOdd}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumOdd - sumEven)}");
            }
        }
    }
}
