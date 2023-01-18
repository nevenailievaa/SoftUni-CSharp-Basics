using System;

namespace _05.GreetingByName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ozeleneni = double.Parse(Console.ReadLine());

            double kvMetriCena = ozeleneni * 7.61;
            double namalenie = 0.18 * kvMetriCena;
            double krainaCena = kvMetriCena - namalenie;

            Console.WriteLine($"The final price is: {krainaCena} lv.");
            Console.WriteLine($"The discount is: {namalenie} lv.");
        }
    }
}
