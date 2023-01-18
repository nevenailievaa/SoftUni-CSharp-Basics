using System;

namespace _07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int inputHour = int.Parse(Console.ReadLine());
            string dayOfWeek = (Console.ReadLine());
            //Actions
            switch (dayOfWeek)
            {
                case "Sunday":
                    Console.WriteLine("closed");
                    break;
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    switch (inputHour)
                    {
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                            Console.WriteLine("open");
                            break;
                            default:
                            Console.WriteLine("closed");
                            break;
                    }
                    break;
            }
        }
    }
}
