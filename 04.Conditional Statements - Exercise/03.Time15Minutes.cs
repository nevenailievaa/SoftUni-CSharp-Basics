using System;
using System.Dynamic;

namespace _03.Time15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            //Action
            minutes += 15;

            if (minutes >= 60)
            {
                hour += 1;
                minutes -= 60;
            }
            if (hour >= 24)
            {
                hour -= 24;
            }

            //Output

            if (minutes <= 9)
            {
                Console.WriteLine($"{hour}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minutes}");
            }

        }
    }
}
