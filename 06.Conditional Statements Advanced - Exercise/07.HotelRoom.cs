using System;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string month = Console.ReadLine();
            int numberStays = int.Parse(Console.ReadLine());
            string typeRoom = null;
            double finalPriceStudio = 0;
            double finalPriceApartment = 0;


            //Actions

            //May and October
            if (month == "May" || month == "October")
            {
                //Studio
                finalPriceStudio = numberStays * 50.00;

                if (numberStays > 14)
                {
                    finalPriceStudio -= finalPriceStudio * 0.3;
                }
                else if (numberStays > 7)
                {
                    finalPriceStudio -= finalPriceStudio * 0.05;
                }

                //Apartment
                finalPriceApartment = numberStays * 65.00;

                if (numberStays > 14)
                {
                    finalPriceApartment -= finalPriceApartment * 0.1;
                }
            }

            //June and September
            if (month == "June" || month == "September")
            {
                //Studio
                finalPriceStudio = numberStays * 75.20;

                if (numberStays > 14)
                {
                    finalPriceStudio -= finalPriceStudio * 0.2;
                }

                //Apartment
                finalPriceApartment = numberStays * 68.70;

                if (numberStays > 14)
                {
                    finalPriceApartment -= finalPriceApartment * 0.1;
                }
            }

            //July and August
            if (month == "July" || month == "August")
            {
                //Studio
                finalPriceStudio = numberStays * 76.00;
                
                //Apartment
                finalPriceApartment = numberStays * 77.00;

                if (numberStays > 14)
                {
                    finalPriceApartment -= finalPriceApartment * 0.1;
                }
            }


            //Output
            Console.WriteLine($"Apartment: {finalPriceApartment:f2} lv.");
            Console.WriteLine($"Studio: {finalPriceStudio:f2} lv.");


        }
    }
}
