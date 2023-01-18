using System;

namespace _06.BarcodeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            //ACTION
            for (int i = n1; i <= n2; i++)
            {
                //STRINGS
                string iString = (i.ToString());
                string i2String = (i.ToString());

                //DIGITS
                int n1FirstDigit = int.Parse(iString[0].ToString());
                int n1SecondDigit = int.Parse(iString[1].ToString());
                int n1ThirdDigit = int.Parse(iString[2].ToString());
                int n1FourthDigit = int.Parse(iString[3].ToString());

                //OUTPUT
                if (n1FirstDigit % 2 == 1 && n1SecondDigit % 2 == 1 && n1ThirdDigit % 2 == 1 && n1FourthDigit % 2 == 1)
                {
                    Console.Write($"{n1FirstDigit}{n1SecondDigit}{n1ThirdDigit}{n1FourthDigit} ");
                }
            }
        }
    }
}
