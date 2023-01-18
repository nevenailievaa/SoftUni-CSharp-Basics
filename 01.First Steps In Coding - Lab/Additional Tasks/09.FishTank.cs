using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int cmLenght = int.Parse(Console.ReadLine());
            int cmWidth = int.Parse(Console.ReadLine());
            int cmHeight = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            //Actions
            int volume = cmLenght * cmHeight * cmWidth;
            double volumeLitres = volume / 1000.0;
            double spaceNeeded = percent / 100;
            double neededLitres = volumeLitres * (1 - spaceNeeded);

            //Output
            Console.WriteLine(neededLitres);
        }
    }
}
