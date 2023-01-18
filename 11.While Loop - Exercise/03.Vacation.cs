using System;
using System.Reflection.Metadata.Ecma335;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            double vacationPrice = double.Parse(Console.ReadLine());
            double moneyBalance = double.Parse(Console.ReadLine());

            int totalDaysCount = 0;
            int spendingDays = 0;


            //ACTION
            while (moneyBalance < vacationPrice)
            {
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());

                if (action == "save")
                {
                    moneyBalance += sum;
                    spendingDays = 0;
                    totalDaysCount++;
                }
                else if (action == "spend")
                {
                    moneyBalance -= sum;

                    if (moneyBalance < 0)
                    {
                        moneyBalance = 0;
                    }

                    spendingDays++;
                    totalDaysCount++;

                    if (spendingDays >= 5)
                    {
                        break;
                    }
                }
            }

            if (spendingDays >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(totalDaysCount);
            }
            else
            {
                Console.WriteLine($"You saved the money for {totalDaysCount} days.");
            }
        }
    }
}
