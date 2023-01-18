using System;

namespace _01.OscarsCeremony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int hallRent = int.Parse(Console.ReadLine());

            //ACTIONS
            double statuets = hallRent - (hallRent * 0.3);
            double catering = statuets - (statuets * 0.15);
            double sound = catering / 2;

            double sumRent = hallRent + statuets + catering + sound;

            //OUTPUT
            Console.WriteLine($"{sumRent:f2}");
        }
    }
}
