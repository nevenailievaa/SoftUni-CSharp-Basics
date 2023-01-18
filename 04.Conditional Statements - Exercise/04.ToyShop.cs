using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzlesCnt = int.Parse(Console.ReadLine());
            int dollsCnt = int.Parse(Console.ReadLine());
            int bearsCnt = int.Parse(Console.ReadLine());
            int minionsCnt = int.Parse(Console.ReadLine());
            int trucksCnt = int.Parse(Console.ReadLine());

            //Actions
            double puzzlesPrice = puzzlesCnt * 2.60;
            double dollsPrice = dollsCnt * 3;
            double bearsPrice = bearsCnt * 4.10;
            double minionsPrice = minionsCnt * 8.20;
            double trucksPrice = trucksCnt * 2;

            int allToysCnt = puzzlesCnt + dollsCnt + bearsCnt + minionsCnt + trucksCnt;

            double totalPrice = puzzlesPrice + dollsPrice + bearsPrice +
            minionsPrice + trucksPrice;

            if (allToysCnt >= 50)
            {
                totalPrice = totalPrice - (totalPrice * 0.25);
            }

            double rent = 0.10 * totalPrice;
            totalPrice -= rent;

            //Output
            if (totalPrice >= tripPrice)
            {
                Console.WriteLine($"Yes! {(totalPrice-tripPrice):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(tripPrice-totalPrice):f2} lv needed.");
            }
        }
    }
}
