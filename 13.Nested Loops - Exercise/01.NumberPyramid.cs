using System;

namespace _01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int n = int.Parse(Console.ReadLine());

            int cnt = 1;
            bool isReady = false;


            //ACTION
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (cnt > n)
                    {
                        isReady = true;
                        break;
                    }

                    Console.Write($"{cnt} ");
                    cnt++;
                }

                if (isReady)
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}
