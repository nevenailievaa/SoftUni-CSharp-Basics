using System;

namespace _04.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int hallSeats = int.Parse(Console.ReadLine());

            //CHANGEABLE INPUT
            string command = null;
            int peopleEntering = 0;
            double peopleEnteringBill = 0;
            double peopleEnteringDiscount = 0;
            double finalBill = 0;

            int numberTakenSeats = 0;

            //ACTION
            while ((command = Console.ReadLine()) != "Movie time!")
            {
                peopleEntering = int.Parse(command);
                numberTakenSeats += peopleEntering;

                if (hallSeats < numberTakenSeats)
                {
                    Console.WriteLine("The cinema is full.");
                    Console.WriteLine($"Cinema income - {finalBill} lv.");
                    return;
                }

                peopleEnteringBill = peopleEntering * 5.00;

                if (peopleEntering % 3 == 0)
                {
                    peopleEnteringDiscount = 5;
                    peopleEnteringBill -= peopleEnteringDiscount;
                }

                finalBill += peopleEnteringBill;

                //RESTORE DATA
                peopleEnteringBill = 0;
                peopleEnteringDiscount = 0;
            }

            //OUTPUT
            if (hallSeats >= numberTakenSeats)
            {
                Console.WriteLine($"There are {hallSeats - numberTakenSeats} seats left in the cinema.");
                Console.WriteLine($"Cinema income - {finalBill} lv.");
            }
        }
    }
}
