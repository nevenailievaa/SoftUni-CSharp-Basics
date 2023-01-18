using System;

namespace _09.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            //Action
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                leftSum += num;
            }
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                rightSum += num;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
