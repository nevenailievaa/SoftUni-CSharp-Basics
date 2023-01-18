using System;

namespace _04.GameNumberWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            string firstPlayerName = Console.ReadLine();
            string secondPlayerName = Console.ReadLine();

            string command;
            int firstPlayerCardNumber = 0;
            int secondPlayerCardNumber = 0;

            int firstPlayerPoints = 0;
            int secondPlayerPoints = 0;

            int firstPlayerPointsSum = 0;
            int secondPlayerPointsSum = 0;

            //ACTION
            while ((command = Console.ReadLine()) != "End of game")
            {
                firstPlayerCardNumber = int.Parse(command);
                secondPlayerCardNumber = int.Parse(Console.ReadLine());

                //1>2
                if (firstPlayerCardNumber > secondPlayerCardNumber)
                {
                    firstPlayerPoints = firstPlayerCardNumber - secondPlayerCardNumber;
                    firstPlayerPointsSum += firstPlayerPoints;
                }

                //2>1
                else if (firstPlayerCardNumber < secondPlayerCardNumber)
                {
                    secondPlayerPoints = secondPlayerCardNumber - firstPlayerCardNumber;
                    secondPlayerPointsSum += secondPlayerPoints;
                }

                //=
                else if (firstPlayerCardNumber == secondPlayerCardNumber)
                {
                    Console.WriteLine("Number wars!");
                    firstPlayerCardNumber = int.Parse(Console.ReadLine());
                    secondPlayerCardNumber = int.Parse(Console.ReadLine());

                    if (firstPlayerCardNumber > secondPlayerCardNumber)
                    {
                        firstPlayerPoints = firstPlayerCardNumber - secondPlayerCardNumber;
                        Console.WriteLine($"{firstPlayerName} is winner with {firstPlayerPoints} points");
                        return;
                    }
                    else if (firstPlayerCardNumber < secondPlayerCardNumber)
                    {
                        secondPlayerPoints = secondPlayerCardNumber - firstPlayerCardNumber;
                        Console.WriteLine($"{secondPlayerName} is winner with {secondPlayerPoints} points");
                        return;
                    }
                }

                //RESTORE
                firstPlayerPoints = 0;
                secondPlayerPoints = 0;
            }

            //OUTPUT
            Console.WriteLine($"{firstPlayerName} has {firstPlayerPointsSum} points");
            Console.WriteLine($"{secondPlayerName} has {secondPlayerPointsSum} points");
        }
    }
}
