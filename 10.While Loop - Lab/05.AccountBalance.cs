using System;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0;

            while (input != "NoMoreMoney")
            {
                double inputInNumbers = double.Parse(input);

                if (inputInNumbers >= 0)
                {
                    balance += inputInNumbers;
                    Console.WriteLine($"Increase: {inputInNumbers:f2}");
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
