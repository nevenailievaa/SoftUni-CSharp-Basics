using System;

namespace _06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int maxNumber = int.MinValue;


            while (input != "Stop")
            {
                int inputInNumbers = int.Parse(input);

                if (inputInNumbers > maxNumber)
                {
                    maxNumber = inputInNumbers;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
