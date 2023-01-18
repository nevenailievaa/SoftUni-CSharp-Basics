using System;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string presentationName = null;
            double grade = 0;

            double averageGrade = 0;
            double gradesSum = 0;

            double averageGradeAll = 0;
            double allGradesSum = 0;

            int gradedTimes = 0;

            while ((presentationName = Console.ReadLine()) != "Finish")
            {
                averageGrade = 0;
                gradesSum = 0;

                for (int i = 1; i <= juryCount; i++)
                {
                    grade = double.Parse(Console.ReadLine());
                    allGradesSum += grade;
                    gradesSum += grade;
                    gradedTimes++;
                }

                averageGrade = gradesSum / juryCount;
                Console.WriteLine($"{presentationName} - {averageGrade:f2}.");
            }

            averageGradeAll = allGradesSum / gradedTimes;
            Console.WriteLine($"Student's final assessment is {averageGradeAll:f2}.");
        }
    }
}
