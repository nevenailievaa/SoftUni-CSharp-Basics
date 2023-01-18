using System;

namespace _01.TennisEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            double tennisRacketPrice = double.Parse(Console.ReadLine());
            int tennisRacketCount = int.Parse(Console.ReadLine());
            int shoePacksCount = int.Parse(Console.ReadLine());

            //ACTION
            double shoePackPrice = tennisRacketPrice / 6;
            double firstBill = (shoePackPrice * shoePacksCount) + (tennisRacketPrice * tennisRacketCount);
            double otherStuff = firstBill * 0.2;
            double secondBill = firstBill + otherStuff;

            double playerBill = secondBill / 8;
            double sponsorsBill = secondBill - playerBill;

            //OUTPUT
            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(playerBill)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(sponsorsBill)}");
        }
    }
}
