using System;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string town = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());
            double comission = 0;

            //Actions
            if (town == "Sofia")
            {
                if (sells >= 0 && sells <= 500)
                {
                    comission = 0.05;
                }
                else if (sells > 500 && sells <= 1000)
                {
                    comission = 0.07;
                }
                else if (sells > 1000 && sells <= 10000)
                {
                    comission = 0.08;
                }
                else if (sells > 10000)
                {
                    comission = 0.12;
                }
                else if (sells < 0)
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Varna")
                {
                    if (sells >= 0 && sells <= 500)
                    {
                        comission = 0.045;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        comission = 0.075;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        comission = 0.1;
                    }
                    else if (sells > 10000)
                    {
                        comission = 0.13;
                    }
                    else if (sells < 0)
                    {
                        Console.WriteLine("error");
                    }
            }
            else if (town == "Plovdiv")
            {
                if (sells >= 0 && sells <= 500)
                {
                    comission = 0.055;
                }
                else if (sells > 500 && sells <= 1000)
                {
                    comission = 0.08;
                }
                else if (sells > 1000 && sells <= 10000)
                {
                    comission = 0.12;
                }
                else if (sells > 10000)
                {
                    comission = 0.145;
                }
                else if (sells < 0)
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            //Output
            double finalComission = sells * comission;

            if (finalComission > 0)
            {
                Console.WriteLine($"{finalComission:f2}");
            }
        }
    }
}
