using System;

namespace _01._Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clock

            for (int h = 0; h <= 23; h++)
            {
                for (int m = 0; m <= 59; m++)
                {
                    Console.WriteLine($"{h}:{m}");
                }
            }
        }
    }
}
