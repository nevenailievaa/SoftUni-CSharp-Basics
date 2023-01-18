using System;

namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            //Action
            if (n >= 1 && n <= 1000)
            {
                for (int i = 0; i < n; i++)
                {
                    int number = int.Parse(Console.ReadLine());

                    if (number >= 1 && number < 200)
                    {
                        p1 += 1;
                    }
                    else if (number >= 200 && number <= 399)
                    {
                        p2 += 1;
                    }
                    else if (number >= 400 && number <= 599)
                    {
                        p3 += 1;
                    }
                    else if (number >= 600 && number <= 799)
                    {
                        p4 += 1;
                    }
                    else if (number >= 800)
                    {
                        p5 += 1;
                    }
                }

            }

            double p1Procent = p1 / n * 100;
            double p2Procent = p2 / n * 100;
            double p3Procent = p3 / n * 100;
            double p4Procent = p4 / n * 100;
            double p5Procent = p5 / n * 100;

            //Output
            Console.WriteLine($"{p1Procent:f2}%");
            Console.WriteLine($"{p2Procent:f2}%");
            Console.WriteLine($"{p3Procent:f2}%");
            Console.WriteLine($"{p4Procent:f2}%");
            Console.WriteLine($"{p5Procent:f2}%");
        }
    }
}