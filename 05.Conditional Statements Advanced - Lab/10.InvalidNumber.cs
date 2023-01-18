using System;

namespace _10.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int inputNumber = int.Parse(Console.ReadLine());
            bool isValid = inputNumber >= 100 && inputNumber <= 200 || inputNumber == 0;

            //Actions
            if (!isValid)
            {
                Console.WriteLine("invalid");
            }
            else if (!isValid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
