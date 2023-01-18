using System;

namespace _02.MovieDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int timeForRecording = int.Parse(Console.ReadLine());
            int numberScenes = int.Parse(Console.ReadLine());
            int sceneTime = int.Parse(Console.ReadLine());

            //ACTION
            double preparing = timeForRecording * 0.15;
            double finalTimeForRecording = numberScenes * sceneTime + preparing;

            //OUTPUT
            if (timeForRecording > finalTimeForRecording)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeForRecording - finalTimeForRecording)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {finalTimeForRecording - timeForRecording} minutes.");
            }
        }
    }
}
