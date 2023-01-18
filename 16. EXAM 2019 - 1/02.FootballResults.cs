using System;

namespace _02.FootballResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            string firstMatchResultString = Console.ReadLine();
            string secondMatchResultString = Console.ReadLine();
            string thirdMatchResultString = Console.ReadLine();

            int win = 0;
            int allWins = 0;

            int lose = 0;
            int allLoses = 0;

            int drawnGames = 0;

            //ACTION

            //STRINGS
            string firstMatchDigitOneString = (firstMatchResultString[0].ToString());
            string firstMatchDigitTwoString = (firstMatchResultString[2].ToString());

            string secondMatchDigitOneString = (secondMatchResultString[0].ToString());
            string secondMatchDigitTwoString = (secondMatchResultString[2].ToString());

            string thirdMatchDigitOneString = (thirdMatchResultString[0].ToString());
            string thirdMatchDigitTwoString = (thirdMatchResultString[2].ToString());

            //INTS
            int firstMatchDigitOne = int.Parse(firstMatchDigitOneString);
            int firstMatchDigitTwo = int.Parse(firstMatchDigitTwoString);

            int secondMatchDigitOne = int.Parse(secondMatchDigitOneString);
            int secondMatchDigitTwo = int.Parse(secondMatchDigitTwoString);

            int thirdMatchDigitOne = int.Parse(thirdMatchDigitOneString);
            int thirdMatchDigitTwo = int.Parse(thirdMatchDigitTwoString);

            //OUTPUT

            //FIRST
            if (firstMatchDigitOne > firstMatchDigitTwo)
            {
                win += 1;
            }
            else if (firstMatchDigitOne == firstMatchDigitTwo)
            {
                drawnGames += 1;
            }
            else
            {
                lose += 1;
            }
            //SECOND
            if (secondMatchDigitOne > secondMatchDigitTwo)
            {
                win += 1;
            }
            else if (secondMatchDigitOne == secondMatchDigitTwo)
            {
                drawnGames += 1;
            }
            else
            {
                lose += 1;
            }
            //THIRD
            if (thirdMatchDigitOne > thirdMatchDigitTwo)
            {
                win += 1;
            }
            else if (thirdMatchDigitOne == thirdMatchDigitTwo)
            {
                drawnGames += 1;
            }
            else
            {
                lose += 1;
            }

            //OUTPUT
            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {lose} games.");
            Console.WriteLine($"Drawn games: {drawnGames}");
        }
    }
}
