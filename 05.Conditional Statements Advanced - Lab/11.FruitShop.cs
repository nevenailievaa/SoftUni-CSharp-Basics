using System;

namespace _11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string product = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            double priceOfFruit = 0;

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (product)
                    {
                        case "banana":
                            priceOfFruit = 2.5;
                            break;
                        case "apple":
                            priceOfFruit = 1.2;
                            break;
                        case "orange":
                            priceOfFruit = 0.85;
                            break;
                        case "grapefruit":
                            priceOfFruit = 1.45;
                            break;
                        case "kiwi":
                            priceOfFruit = 2.7;
                            break;
                        case "pineapple":
                            priceOfFruit = 5.5;
                            break;
                        case "grapes":
                            priceOfFruit = 3.85;
                            break;
                        default:
                            Console.WriteLine("error");
                            return;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (product)
                    {
                        case "banana":
                            priceOfFruit = 2.7;
                            break;
                        case "apple":
                            priceOfFruit = 1.25;
                            break;
                        case "orange":
                            priceOfFruit = 0.9;
                            break;
                        case "grapefruit":
                            priceOfFruit = 1.6;
                            break;
                        case "kiwi":
                            priceOfFruit = 3;
                            break;
                        case "pineapple":
                            priceOfFruit = 5.6;
                            break;
                        case "grapes":
                            priceOfFruit = 4.2;
                            break;
                        default:
                            Console.WriteLine("error");
                            return;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    return;
            }

            double finalPrice = amount * priceOfFruit;
            Console.WriteLine($"{finalPrice:f2}");
        }
        
    }
}
