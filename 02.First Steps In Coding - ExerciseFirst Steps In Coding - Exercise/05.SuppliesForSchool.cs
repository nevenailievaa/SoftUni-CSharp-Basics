using System;

namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double paketiHimikali = double.Parse(Console.ReadLine());
            double paketiMarkeri = int.Parse(Console.ReadLine());
            double litriPreparat = int.Parse(Console.ReadLine());
            double Namalenie = double.Parse(Console.ReadLine());

            //Actions
            double himikaliCena = paketiHimikali * 5.80;
            double markeriCena = paketiMarkeri * 7.20;
            double preparatCena = litriPreparat * 1.20;
            double namalenieVProcenti = Namalenie / 100;

            double krainaCenaBezNamalenie = himikaliCena + markeriCena + preparatCena;
            double krainaCena = krainaCenaBezNamalenie - (krainaCenaBezNamalenie * namalenieVProcenti);

            //Output
            Console.WriteLine(krainaCena);

        }
    }
}
    

