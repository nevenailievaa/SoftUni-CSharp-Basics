using System;
using System.Dynamic;

namespace _07.AreaofFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = (Console.ReadLine());

            if (type == "square")
            {
                double sideLenght = double.Parse(Console.ReadLine());
                double roundResult = sideLenght * sideLenght;
                Console.WriteLine($"{roundResult:f3}");
            }
            if (type == "rectangle")
            {
                double sideLength1 = double.Parse(Console.ReadLine());
                double sideLength2 = double.Parse(Console.ReadLine());
                double roundResult = sideLength1 * sideLength2;
                Console.WriteLine($"{roundResult:f3}");
            }
            if (type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double roundResult = Math.PI * radius * radius;
                Console.WriteLine($"{roundResult:f3}");
            }
            if (type == "triangle")
            {
                double sideLength = double.Parse(Console.ReadLine());
                double lenght = double.Parse(Console.ReadLine());
                double roundResult = (sideLength * lenght) / 2;
                Console.WriteLine($"{roundResult:f3}");
            }
        }
    }
}
