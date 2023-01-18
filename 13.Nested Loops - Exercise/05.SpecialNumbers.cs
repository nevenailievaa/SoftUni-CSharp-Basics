using System;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int n = int.Parse(Console.ReadLine());

            //ACTION
            for (int i = 1111; i <= 9999; i++)
            {
                string iString = i.ToString();

                int letter0 = int.Parse(iString[0].ToString());
                int letter1 = int.Parse(iString[1].ToString());
                int letter2 = int.Parse(iString[2].ToString());
                int letter3 = int.Parse(iString[3].ToString());

                if (letter0 == 0 || letter1 == 0 || letter2 == 0 || letter3 == 0)
                {
                    continue;
                }

                if (n % letter0 == 0 && n % letter1 == 0 && n % letter2 == 0 && n % letter3 == 0)
                {
                    Console.Write($"{letter0}{letter1}{letter2}{letter3} ");
                }

            }
        }
    }
}
