using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int chickenMenuInput = int.Parse(Console.ReadLine());
            int fishMenuInput = int.Parse(Console.ReadLine());
            int vegerarianMenuInput = int.Parse(Console.ReadLine());

            //Actions
            double chickenMenu = chickenMenuInput * 10.35;
            double fishMenu = fishMenuInput * 12.40;
            double vegerarianMenu = vegerarianMenuInput * 8.15;

            double billMenus = chickenMenu + fishMenu + vegerarianMenu;
            double dessert = billMenus * 0.2;
            double finalBill = billMenus + dessert + 2.50;

            //Output
            Console.WriteLine(finalBill);
        }
    }
}
