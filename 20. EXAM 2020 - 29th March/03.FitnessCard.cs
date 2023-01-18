using System;

namespace _03_1_FitnessCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            double moneyWeHave = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string typeSport = Console.ReadLine();
            double sportTax = 0;

            //ACTION
            if (sex == "m")
            {
                if (typeSport == "Gym")
                {
                    sportTax = 42.00;
                }
                else if (typeSport == "Boxing")
                {
                    sportTax = 41.00;
                }
                else if (typeSport == "Yoga")
                {
                    sportTax = 45.00;
                }
                else if (typeSport == "Zumba")
                {
                    sportTax = 34.00;
                }
                else if (typeSport == "Dances")
                {
                    sportTax = 51.00;
                }
                else if (typeSport == "Pilates")
                {
                    sportTax = 39.00;
                }
            }
            else if (sex == "f")
            {
                if (typeSport == "Gym")
                {
                    sportTax = 35.00;
                }
                else if (typeSport == "Boxing")
                {
                    sportTax = 37.00;
                }
                else if (typeSport == "Yoga")
                {
                    sportTax = 42.00;
                }
                else if (typeSport == "Zumba")
                {
                    sportTax = 31.00;
                }
                else if (typeSport == "Dances")
                {
                    sportTax = 53.00;
                }
                else if (typeSport == "Pilates")
                {
                    sportTax = 37.00;
                }
            }

            double finalBill = sportTax;
            //DISCOUNT
            if (age <= 19)
            {
                finalBill -= (finalBill * 0.2);
            }

            //OUTPUT
            if (finalBill <= moneyWeHave)
            {
                Console.WriteLine($"You purchased a 1 month pass for {typeSport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${(finalBill - moneyWeHave):f2} more."
);
            }
        }
    }
}
