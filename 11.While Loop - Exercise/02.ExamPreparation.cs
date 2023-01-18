using System;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int numberNeededBadGrades = int.Parse(Console.ReadLine());
            string taskName = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());

            string lastTaskName = null;
            int numberTasks = 0;
            int numberBadGrades = 0;

            double gradesSum = 0;



            //ACTION
            while (taskName != "Enough")
            {
                numberTasks++;

                if (grade <= 4.00)
                {
                    numberBadGrades++;

                    if (numberBadGrades == numberNeededBadGrades)
                    {
                        Console.WriteLine($"You need a break, {numberBadGrades} poor grades.");
                        return;
                    }
                }

                gradesSum += grade;
                lastTaskName = taskName;
                taskName = Console.ReadLine();
                if (taskName != "Enough")
                {
                    grade = double.Parse(Console.ReadLine());
                }
            }

            double averageGrade = gradesSum / numberTasks;


            //OUTPUT
            Console.WriteLine($"Average score: {averageGrade:f2}");
            Console.WriteLine($"Number of problems: {numberTasks}");
            Console.WriteLine($"Last problem: {lastTaskName}");

        }
    }
}
