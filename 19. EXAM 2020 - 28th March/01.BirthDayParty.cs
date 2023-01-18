using System;

namespace _01.BirthDayParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            double rent = double.Parse(Console.ReadLine());

            //ACTION
            double cakePrice = rent * 0.20;
            double drinks = cakePrice - (cakePrice * 0.45);
            double animator = rent / 3;

            double budget = rent + cakePrice + drinks + animator;

            //OUTPUT
            Console.WriteLine(budget);

        }
    }
}
