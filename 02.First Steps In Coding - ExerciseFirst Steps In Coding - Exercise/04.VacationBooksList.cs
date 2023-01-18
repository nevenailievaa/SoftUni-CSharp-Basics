using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int pages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            //actions
            int readingPerDay = (pages / pagesPerHour);
            int readingPerHour = (readingPerDay / days);

            //outputs
            Console.WriteLine(readingPerHour);
        }
    }
}
