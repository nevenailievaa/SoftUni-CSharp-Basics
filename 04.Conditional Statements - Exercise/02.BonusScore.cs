using System;

namespace _02.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int points = int.Parse(Console.ReadLine());
            double bonusPoints = 0;

            //Actions
            if (points <= 100)
            {
                bonusPoints = 5;
            }
            else if (points > 1000)
            {
                bonusPoints = 0.1 * points;
            }
            else if (points > 100)
            {
                bonusPoints = 0.2 * points;
            }

            //Additional Bonus Points
            if (points % 2 == 0)
            {
                bonusPoints += 1;
            }
            else if (points % 10 == 5)
            {
                bonusPoints += 2;
            }

            //Output
            Console.WriteLine(bonusPoints);
            Console.WriteLine(points + bonusPoints);
        }
    }
}
