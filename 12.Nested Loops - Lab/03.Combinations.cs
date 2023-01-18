using System;

namespace _03.Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int n = int.Parse(Console.ReadLine());
            int validCombinations = 0;

            //ACTION
            for (int f = 0; f <= n; f++)
            {
                for (int s = 0; s <= n; s++)
                {
                    for (int t = 0; t <= n; t++)
                    {
                        if (f + s + t == n)
                        {
                            validCombinations++;
                        }
                    }
                }
            }

            //OUTPUT
            Console.WriteLine(validCombinations);
        }
    }
}
