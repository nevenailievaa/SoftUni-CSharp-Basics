using System;

namespace _01.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int yearTax = int.Parse(Console.ReadLine());

            //ACTION
            double shoes = yearTax - ((double)yearTax * 0.4);
            double set = shoes - (shoes * 0.2);
            double ball = set / 4;
            double accessories = ball / 5;
            double yearTaxSum = yearTax + shoes + set + ball + accessories;

            //OUTPUT
            Console.WriteLine($"{yearTaxSum:f2}");
        }
    }
}
