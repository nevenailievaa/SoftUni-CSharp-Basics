using System;
using System.Dynamic;

namespace _03.AnimalType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string animal = Console.ReadLine();

            //Action
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;

                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
