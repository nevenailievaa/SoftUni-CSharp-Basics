using System;

namespace _3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int dancersCount = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            //CHANGEABLE INPUT
            double moneyPrize = 0;
            double postMoneyPrize = 0;
            double finalMoneyPrize = 0;
            double expensesSum = 0;

            //ACTIONS

            //Bulgaria
            if (place == "Bulgaria")
            {
                moneyPrize = points * dancersCount;

                //Seasons
                if (season == "summer")
                {
                    finalMoneyPrize = moneyPrize - (0.05 * moneyPrize);
                }
                else if (season == "winter")
                {
                    finalMoneyPrize = moneyPrize - (0.08 * moneyPrize);
                }
            }

            //Abroad
            else if (place == "Abroad")
            {
                postMoneyPrize = (dancersCount * points);
                moneyPrize = postMoneyPrize + (postMoneyPrize / 2);

                //Seasons
                if (season == "summer")
                {
                    finalMoneyPrize = moneyPrize - (0.1 * moneyPrize);
                }
                else if (season == "winter")
                {
                    finalMoneyPrize = moneyPrize - (0.15 * moneyPrize);
                }
            }

            //CALCULATIONS
            double moneyForCharity = finalMoneyPrize * 0.75;
            double leftMoney = finalMoneyPrize - moneyForCharity;
            double moneyForOneDancer = leftMoney / dancersCount;

            //OUTPUT
            Console.WriteLine($"Charity - {moneyForCharity:f2}");
            Console.WriteLine($"Money per dancer - {moneyForOneDancer:f2}");
        }
    }
}
