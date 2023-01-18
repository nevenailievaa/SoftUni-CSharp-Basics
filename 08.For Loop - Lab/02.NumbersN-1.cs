using System;

namespace _02.NumbersN_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());

            //Action
            for (int number = n; number >= 1; number--)
            {
                Console.WriteLine(number);
            }
        }
    }
}
