using System;

namespace _03.Numbers1_N_with_Step3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());

            //Action
            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
