using System;

namespace _06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int minNumber = int.MaxValue;


            while (input != "Stop")
            {
                int inputInNumbers = int.Parse(input);

                if (inputInNumbers < minNumber)
                {
                    minNumber = inputInNumbers;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
