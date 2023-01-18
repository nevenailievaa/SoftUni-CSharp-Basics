using System;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int yearFeeInput = int.Parse(Console.ReadLine());

            //Actions
            double shoes = yearFeeInput - (yearFeeInput * 0.4);
            double clothes = (shoes - (shoes * 0.2));
            double ball = clothes / 4.0;
            double accessory = ball / 5.0;

            double yearFee = yearFeeInput + shoes + clothes + ball + accessory;

            //Output

            Console.WriteLine(yearFee);
        }
    }
}
