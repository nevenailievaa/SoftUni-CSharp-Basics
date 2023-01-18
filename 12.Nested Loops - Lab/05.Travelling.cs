using System;

namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            string destination = Console.ReadLine();
            double budget = 0;
            double currentMoney = 0;
            double savedMoney = 0;

            //ACTION
            while (destination != "End")
            {
                budget = double.Parse(Console.ReadLine());
                savedMoney = 0;

                while (savedMoney < budget)
                {
                    currentMoney = double.Parse(Console.ReadLine());

                    savedMoney += currentMoney;
                }
                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
