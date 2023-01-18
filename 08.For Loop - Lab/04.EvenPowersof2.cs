using System;

namespace _04.EvenPowersof2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());

            //Action
            for (int i = 0; i <= n; i+=2)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
