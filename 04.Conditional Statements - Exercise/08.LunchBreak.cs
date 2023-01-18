
using System;
using System.Text.RegularExpressions;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string seriesName = (Console.ReadLine());
            int episodeLenght = int.Parse(Console.ReadLine()) ;
            int breakLenght = int.Parse(Console.ReadLine());

            //Actions
            double timeForLunch = breakLenght * 0.125;
            double timeForRest = breakLenght * 0.25;
            double timeLeftForWatching = breakLenght - (timeForLunch + timeForRest);

            if (timeLeftForWatching >= episodeLenght)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeLeftForWatching - episodeLenght)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodeLenght - timeLeftForWatching)} more minutes.");
            }
        }
    }
}
