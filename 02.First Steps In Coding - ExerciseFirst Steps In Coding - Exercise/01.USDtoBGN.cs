using System;

namespace _01.USDtoBGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            int wholenum = (int)input;

            double bgn = input * 1.79549;

            Console.WriteLine(bgn);
            Console.WriteLine(wholenum);

        }
    }
}
