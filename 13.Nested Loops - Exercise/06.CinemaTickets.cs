using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            string movieName;
            int freeSeats;
            string typeTicket = null; ;

            //CHANGEABLE
            int studentTicketsSum = 0;
            
            int standartTicketsSum = 0;

            int kidTicketsSum = 0;

            int allTicketsSum = 0;

            while ((movieName = Console.ReadLine()) != "Finish")
            {
                freeSeats = int.Parse(Console.ReadLine());

                int currentTicketsSum = 0;
                int studentTicketsCurrentSum = 0;
                int standardTicketsCurrentSum = 0;
                int kidTicketsCurrentSum = 0;

                int takenSeats = 0;

                while (takenSeats < freeSeats && (typeTicket = Console.ReadLine()) != "End")
                {
                    if (typeTicket == "Finish")
                    {
                        break;
                    }

                    if (typeTicket == "student")
                    {
                        studentTicketsSum++;
                        studentTicketsCurrentSum++;
                        takenSeats++;
                    }
                    else if (typeTicket == "standard")
                    {
                        standartTicketsSum++;
                        standardTicketsCurrentSum++;
                        takenSeats++;
                    }
                    else if (typeTicket == "kid")
                    {
                        kidTicketsSum++;
                        kidTicketsCurrentSum++;
                        takenSeats++;
                    }
                }

                currentTicketsSum = studentTicketsCurrentSum + standardTicketsCurrentSum + kidTicketsCurrentSum;
                double percentFilled = ((double)currentTicketsSum / freeSeats) * 100.00;
                Console.WriteLine($"{movieName} - {percentFilled:f2}% full.");

                if (typeTicket == "Finish")
                {
                    break;
                }
            }

            allTicketsSum = studentTicketsSum + standartTicketsSum + kidTicketsSum;
            double studentTicketsPercent = ((double)studentTicketsSum / allTicketsSum) * 100.00;
            double standartTicketsPercent = ((double)standartTicketsSum / allTicketsSum) * 100.00;
            double kidTicketsPercent = ((double)kidTicketsSum / allTicketsSum) * 100.00;

            Console.WriteLine($"Total tickets: {allTicketsSum}");
            Console.WriteLine($"{studentTicketsPercent:f2}% student tickets.");
            Console.WriteLine($"{standartTicketsPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketsPercent:f2}% kids tickets.");
        }
    }
}
