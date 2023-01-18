using System;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int priceForOneToy = int.Parse(Console.ReadLine());

            double money = 0;
            double moneySum = 0;
            int numberMoneyGiven = 0;
            int numberToys = 0;
            double savedMoney = 0;

            //Action 
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 1)
                {
                    numberToys += 1;
                }
                else if (i % 2 == 0)
                {
                    money += 10;
                    moneySum += money;
                    numberMoneyGiven += 1;
                }
            }

            savedMoney = moneySum + (numberToys * priceForOneToy) - numberMoneyGiven * 1.00;

            //Output
            if (savedMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {(savedMoney - washingMachinePrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washingMachinePrice - savedMoney):f2}");
            }
        }
    }
}
