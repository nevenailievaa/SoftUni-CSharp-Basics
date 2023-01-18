using System;

namespace _06.FavoriteMovie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            string seriesName = Console.ReadLine();
            int numberSeasons = int.Parse(Console.ReadLine());
            int numberEpisodes = int.Parse(Console.ReadLine());
            double episodeLenght = double.Parse(Console.ReadLine());

            //ACTION
            double ads = episodeLenght * 0.2;
            double episodeLenghtWithAds = episodeLenght + ads;
            double plus10MinutesTime = numberSeasons * 10;

            double finalTime = episodeLenghtWithAds * numberEpisodes * numberSeasons + plus10MinutesTime;

            //OUTPUT
            Console.WriteLine($"Total time needed to watch the {seriesName} series is {finalTime} minutes.");
        }
    }
}
