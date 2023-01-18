using System;

namespace _08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            //Actions
            int examTotalMinutesAM = examHour * 60 + examMinute;
            int arriveTotalMinutesAM = arriveHour * 60 + arriveMinutes;

            int diff = examTotalMinutesAM - arriveTotalMinutesAM;

            if (diff < 0)
            {
                Console.WriteLine("Late");

                diff = Math.Abs(diff);
                int hoursLate = diff / 60;
                int minutesLate = diff % 60;

                if (hoursLate <= 0)
                {
                    Console.WriteLine($"{minutesLate} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{hoursLate}:{minutesLate:d2} hours after the start");
                }
            }
            else if (diff >= 0 && diff <= 30)
            {
                Console.WriteLine("On time");
                if (diff > 0)
                {
                    Console.WriteLine($"{diff} minutes before the start");
                }
            }
            else
            {
                int hoursEarly = diff / 60;
                int minutesEarly = diff % 60;
                Console.WriteLine("Early");
                if (hoursEarly == 0)
                {
                    Console.WriteLine($"{minutesEarly} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{hoursEarly}:{minutesEarly:d2} hours before the start");
                }
            }
        }
    }
}
