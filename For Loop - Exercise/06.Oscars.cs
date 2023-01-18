using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string actorName = Console.ReadLine();
            double startPoints = double.Parse(Console.ReadLine());
            int numberGraders = int.Parse(Console.ReadLine());

            int nameLenght = 0;
            double pointsSum = 0;

            //Cycle
            for (int i = 1; i <= numberGraders; i++)
            {
                string graderName = (Console.ReadLine());
                double graderGivenPoints = double.Parse(Console.ReadLine());

                nameLenght = graderName.Length;

                if (i == 1)
                {
                    pointsSum += startPoints + ((nameLenght * graderGivenPoints) / 2);
                }
                else
                {
                    pointsSum = pointsSum + ((nameLenght * graderGivenPoints) / 2);
                }

                //Output 1
                if (pointsSum >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsSum:f1}!");
                    return;
                }
            }

            //Output 2
            if (pointsSum < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {(1250.5 - pointsSum):f1} more!");
            }
        }
    }
}

