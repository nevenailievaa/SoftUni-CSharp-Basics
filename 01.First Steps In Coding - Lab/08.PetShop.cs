using System;

namespace _05.GreetingByName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int cats = int.Parse(Console.ReadLine());

            double dogs2 = dogs * 2.5;
            double cats2 = cats * 4;

            double dogsAndCats = dogs2 + cats2;

            Console.WriteLine($"{dogsAndCats} lv.");
        }
    }
}