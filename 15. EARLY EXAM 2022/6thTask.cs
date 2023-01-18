using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int shoppersCount = int.Parse(Console.ReadLine());
            double basketPrice = 1.50;
            double wreathPrice = 3.80;
            double chocolateBunnyPrice = 7.00;


            //CHANGEABLE INPUT
            int numberBoughtProducts = 0;
            string command = null;
            string chosenProduct = null;

            double clientSum = 0;
            double allSum = 0;
            double averageSpentMoney = 0;


            //ACTION
            for (int i = 1; i <= shoppersCount; i++)
            {
                command = Console.ReadLine();

                while (command != "Finish")
                {
                    chosenProduct = command;
                    numberBoughtProducts++;

                    if (chosenProduct == "basket")
                    {
                        clientSum += basketPrice;
                    }
                    else if (chosenProduct == "wreath")
                    {
                        clientSum += wreathPrice;
                    }
                    else if (chosenProduct == "chocolate bunny")
                    {
                        clientSum += chocolateBunnyPrice;
                    }

                    command = Console.ReadLine();
                }

                //20% Discount
                if (numberBoughtProducts % 2 == 0)
                {
                    clientSum -= clientSum * 0.2;
                }

                allSum += clientSum;

                //Client Output
                Console.WriteLine($"You purchased {numberBoughtProducts} items for {clientSum:f2} leva.");

                //Restart
                numberBoughtProducts = 0;
                clientSum = 0;
            }

            //Average Bill
            averageSpentMoney = allSum / shoppersCount;

            //OUTPUT
            Console.WriteLine($"Average bill per client is: {averageSpentMoney:f2} leva.");
        }
    }
}
