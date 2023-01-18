using System;

namespace _03.FilmPremiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            string movie = Console.ReadLine();
            string movieBox = Console.ReadLine();
            int numberTickets = int.Parse(Console.ReadLine());

            //CHANGEABLE INPUT
            double boxPrice = 0;

            //ACTION
            //JohnWick
            if (movie == "John Wick")
            {
                if (movieBox == "Drink")
                {
                    boxPrice = 12.00;
                }
                else if (movieBox == "Popcorn")
                {
                    boxPrice = 15.00;
                }
                else if (movieBox == "Menu")
                {
                    boxPrice = 19.00;
                }
            }
            //StarWars
            else if (movie == "Star Wars")
            {
                if (movieBox == "Drink")
                {
                    boxPrice = 18.00;
                }
                else if (movieBox == "Popcorn")
                {
                    boxPrice = 25.00;
                }
                else if (movieBox == "Menu")
                {
                    boxPrice = 30.00;
                }
            }
            //Jumanji
            else if (movie == "Jumanji")
            {
                if (movieBox == "Drink")
                {
                    boxPrice = 9.00;
                }
                else if (movieBox == "Popcorn")
                {
                    boxPrice = 11.00;
                }
                else if (movieBox == "Menu")
                {
                    boxPrice = 14.00;
                }
            }

            double price = boxPrice * numberTickets;
            double finalPrice = price;

            //DISCOUNTS
            if (movie == "Star Wars" && numberTickets >= 4)
            {
                finalPrice = price - (price * 0.3);
            }
            else if (movie == "Jumanji" && numberTickets == 2)
            {
                finalPrice = price - (price * 0.15);
            }

            //OUTPUT
            Console.WriteLine($"Your bill is {finalPrice:f2} leva.");
        }
    }
}
