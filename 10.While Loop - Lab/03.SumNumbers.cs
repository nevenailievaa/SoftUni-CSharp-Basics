using System;

namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            while (n < number)
            {
               int n1 = int.Parse(Console.ReadLine());
               n += n1;
            }
            Console.WriteLine(n);
        }
    }
}
