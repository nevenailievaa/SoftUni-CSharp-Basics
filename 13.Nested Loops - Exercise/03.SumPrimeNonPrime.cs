using System;

namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int sumPrime = 0;
            int sumNonPrime = 0;

            string command;

            //ACTION
            while ((command = Console.ReadLine()) != "stop")
            {
                int currNumber = int.Parse(command);

                if (currNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                else if (currNumber == 0 || currNumber == 1)
                {
                    sumNonPrime += currNumber;
                    continue;
                }

                bool isPrime = true;

                for (int div = 2; div <= Math.Sqrt(currNumber); div++)
                {
                    if (currNumber % div == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }


                if (isPrime)
                {
                    sumPrime += currNumber;
                }
                else
                {
                    sumNonPrime += currNumber;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
