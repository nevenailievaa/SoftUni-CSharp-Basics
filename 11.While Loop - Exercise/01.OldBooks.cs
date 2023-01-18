using System;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            string searchedBookName = Console.ReadLine();
            string inputBookName = Console.ReadLine();
            int numberBooks = 0;

            //ACTION
            while (inputBookName != searchedBookName)
            {
                if (inputBookName == "No More Books")
                {
                    break;
                }

                numberBooks++;
                inputBookName = Console.ReadLine();
            }

            //OUTPUT
            if (inputBookName == "No More Books" && inputBookName != searchedBookName)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {numberBooks} books.");
            }

            if (inputBookName == searchedBookName)
            {
                Console.WriteLine($"You checked {numberBooks} books and found it.");
            }
        }
    }
}
