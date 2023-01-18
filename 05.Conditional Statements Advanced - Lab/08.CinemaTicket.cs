using System;

namespace _08.CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string dayOfWeek = Console.ReadLine();

            //Actions
            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Friday")
            {
                Console.WriteLine("12");
            }
            else if (dayOfWeek == "Wednesday" || dayOfWeek == "Thursday")
            {
                Console.WriteLine("14");
            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                Console.WriteLine("16");
            }
        }
    }
}
