using System;

namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int stepsGoal = 10000;
            string command = Console.ReadLine();

            int stepsSum = 0;

            //ACTION
            while (true)
            {
                if (command != "Going home")
                {
                    int steps = int.Parse(command);

                    stepsSum += steps;

                    if (stepsSum >= stepsGoal)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{stepsSum - stepsGoal} steps over the goal!");
                        return;
                    }

                    command = Console.ReadLine();
                }
                else
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    stepsSum += stepsToHome;

                    if (stepsSum >= stepsGoal)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{stepsSum - stepsGoal} steps over the goal!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{stepsGoal - stepsSum} more steps to reach goal.");
                        return;
                    }
                }
            }
        }
    }
}
