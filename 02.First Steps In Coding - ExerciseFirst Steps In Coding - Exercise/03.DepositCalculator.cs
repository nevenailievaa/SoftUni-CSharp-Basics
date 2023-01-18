using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double depositValue = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interestPercentage = double.Parse(Console.ReadLine()) / 100;

            //actions
            double totalSum = depositValue + months * ((depositValue * interestPercentage) / 12);

            //output
            Console.WriteLine(totalSum);
        }
    }
}
