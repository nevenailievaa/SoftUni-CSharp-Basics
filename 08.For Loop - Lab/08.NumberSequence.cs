using System;

namespace _08.NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;

            //Action
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < minNumber)
                {
                    minNumber = num;
                }
                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
