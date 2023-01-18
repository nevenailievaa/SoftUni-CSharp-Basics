using System;

namespace _01.MatchTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberPeople = int.Parse(Console.ReadLine());

            double transport = 0;
            double ticketsPrice = 0;


            //Action

            //Transport
            if (numberPeople >= 1 && numberPeople <= 4)
            {
                transport = budget * 0.75;
            }
            else if (numberPeople >= 5 && numberPeople <= 9)
            {
                transport = budget * 0.6;
            }
            else if (numberPeople >= 10 && numberPeople <= 24)
            {
                transport = budget * 0.5;
            }
            else if (numberPeople >= 25 && numberPeople <= 49)
            {
                transport = budget * 0.4;
            }
            else if (numberPeople > 50)
            {
                transport = budget * 0.25;
            }

            double remainingBudget = budget - transport;


            //Tickets

            if (category == "VIP")
            {
                ticketsPrice = numberPeople * 499.99;
            }
            else if (category == "Normal")
            {
                ticketsPrice = numberPeople * 249.99;
            }


            //Budget
            if (remainingBudget >= ticketsPrice)
            {
                Console.WriteLine($"Yes! You have {(remainingBudget - ticketsPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(ticketsPrice - remainingBudget):f2} leva.");
            }
        }
    }
}
