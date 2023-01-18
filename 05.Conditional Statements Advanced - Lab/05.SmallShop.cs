using System;

namespace _05.SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            string inputProduct = Console.ReadLine();
            string city = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double price = 0;

            //action
            if (city == "Sofia")
            {
                if (inputProduct == "coffee")
                {
                    price = amount * 0.50;
                    Console.WriteLine(price);
                }
                if (inputProduct == "water")
                {
                    price = amount * 0.80;
                    Console.WriteLine(price);
                }
                if (inputProduct == "beer")
                {
                    price = amount * 1.20;
                    Console.WriteLine(price);
                }
                if (inputProduct == "sweets")
                {
                    price = amount * 1.45;
                    Console.WriteLine(price);
                }
                if (inputProduct == "peanuts")
                {
                    price = amount * 1.60;
                    Console.WriteLine(price);
                }
            }

            if (city == "Plovdiv")
            {
                if (inputProduct == "coffee")
                {
                    price = amount * 0.40;
                    Console.WriteLine(price);
                }
                if (inputProduct == "water")
                {
                    price = amount * 0.70;
                    Console.WriteLine(price);
                }
                if (inputProduct == "beer")
                {
                    price = amount * 1.15;
                    Console.WriteLine(price);
                }
                if (inputProduct == "sweets")
                {
                    price = amount * 1.30;
                    Console.WriteLine(price);
                }
                if (inputProduct == "peanuts")
                {
                    price = amount * 1.50;
                    Console.WriteLine(price);
                }
            }

            if (city == "Varna")
            {
                if (inputProduct == "coffee")
                {
                    price = amount * 0.45;
                    Console.WriteLine(price);
                }
                if (inputProduct == "water")
                {
                    price = amount * 0.70;
                    Console.WriteLine(price);
                }
                if (inputProduct == "beer")
                {
                    price = amount * 1.10;
                    Console.WriteLine(price);
                }
                if (inputProduct == "sweets")
                {
                    price = amount * 1.35;
                    Console.WriteLine(price);
                }
                if (inputProduct == "peanuts")
                {
                    price = amount * 1.55;
                    Console.WriteLine(price);
                }
            }
        }
    }
}

