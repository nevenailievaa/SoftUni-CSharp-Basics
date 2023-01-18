using System;

namespace _09.FruitOrVegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string product = Console.ReadLine();

            //Actions
            switch (product)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                    default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
