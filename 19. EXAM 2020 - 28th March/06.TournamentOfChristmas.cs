using System;

namespace _06.TournamentOfChristmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int daysInput = int.Parse(Console.ReadLine());

            //CHANGEABLE-INPUT
            string gameName = null;

            string gameStatus;

            double allWonGamesMoney = 0;
            double dayWonGamesMoney = 0;

            int timesWon = 0;
            int timesWonDay = 0;

            int timesLost = 0;
            int timesLostDay = 0;

            bool wonTournir = false;

            //FOR-CONSTRUCTION
            for (int i = 1; i <= daysInput; i++)
            {
                gameName = Console.ReadLine();
                
                //WHILE-CONSTRUCTION
                while (gameName != "Finish")
                {
                    gameStatus = Console.ReadLine();

                    if (gameStatus == "win")
                    {
                        allWonGamesMoney += 20;
                        dayWonGamesMoney += 20;

                        timesWon++;
                        timesWonDay++;
                    }
                    if (gameStatus == "lose")
                    {
                        timesLost++;
                        timesLostDay++;
                    }

                    gameName = Console.ReadLine();
                }
                
                //FOR-CONSTRUCTION-CONTINUE
                if (timesWonDay > timesLostDay)
                {
                    allWonGamesMoney += (dayWonGamesMoney * 0.1);
                }

                timesWonDay = 0;
                timesLostDay = 0;
                dayWonGamesMoney = 0;

            }

            //OUTPUT
            if (timesWon > timesLost)
            {
                allWonGamesMoney += (allWonGamesMoney * 0.2);
                wonTournir = true;
            }

            if (wonTournir)
            {
                Console.WriteLine($"You won the tournament! Total raised money: {allWonGamesMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {allWonGamesMoney:f2}");
            }
        }
    }
}
