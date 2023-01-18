using System;

namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int numberOpenTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            //Changable 
            double fine = 0;
            double remainingSalary = 0;

            //Cycle
            for (int i = 1; i <= numberOpenTabs; i++)
            {
                string typeOpenTab = Console.ReadLine();

                if (typeOpenTab == "Facebook")
                {
                    fine += 150.00;
                }
                else if (typeOpenTab == "Instagram")
                {
                    fine += 100.00;
                }
                else if (typeOpenTab == "Reddit")
                {
                    fine += 50.00;
                }

                remainingSalary = salary - fine;

                if (remainingSalary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }

            //Output
            if (remainingSalary > 0)
            {
                Console.WriteLine($"{remainingSalary}");
            }
        }
    }
}
