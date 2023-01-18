using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());

            int wholeCakePieces = cakeWidth * cakeLenght;

            int ateCakePieces = 0;
            int remainingPieces = 0;

            string inputCommand = null;


            //ACTION
            while (true)
            {
                if (ateCakePieces < wholeCakePieces)
                {
                    inputCommand = Console.ReadLine();

                    if (inputCommand != "STOP")
                    {
                        int eatingPieces = int.Parse(inputCommand);

                        ateCakePieces += eatingPieces;
                        remainingPieces = wholeCakePieces - ateCakePieces;
                    }
                    else
                    {
                        Console.WriteLine($"{remainingPieces} pieces are left.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine($"No more cake left! You need {ateCakePieces - wholeCakePieces} pieces more.");
                    return;
                }
            }
        }
    }
}
