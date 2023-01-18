using System;

namespace _5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int moneyGoal = int.Parse(Console.ReadLine());

            //Haircuts
            double mensHaircutPrice = 15.00;
            double ladiesHaircutPrice = 20.00;
            double kidsHaircutPrice = 10.00;
            //Coloring
            double touchUpColoringPrice = 20.00;
            double fullColoringPrice = 30.00;


            //CHANGEABLE INPUT
            string command = null;
            string typeService = null;
            string typeHaircut = null;
            string typeColoring = null;

            double earnedMoney = 0;

            //ACTION
            while ((command = Console.ReadLine()) != "closed")
            {
                typeService = command;

                //Haircut
                if (typeService == "haircut")
                {
                    typeHaircut = Console.ReadLine();

                    if (typeHaircut == "mens")
                    {
                        earnedMoney += mensHaircutPrice;
                    }
                    else if (typeHaircut == "ladies")
                    {
                        earnedMoney += ladiesHaircutPrice;
                    }
                    else if (typeHaircut == "kids")
                    {
                        earnedMoney += kidsHaircutPrice;
                    }
                }
                //Coloring
                else if (typeService == "color")
                {
                    typeHaircut = Console.ReadLine();

                    if (typeHaircut == "touch up")
                    {
                        earnedMoney += touchUpColoringPrice;
                    }
                    else if (typeHaircut == "full color")
                    {
                        earnedMoney += fullColoringPrice;
                    }
                }
                //If Target Reached
                if (earnedMoney >= moneyGoal)
                {
                    Console.WriteLine("You have reached your target for the day!");
                    Console.WriteLine($"Earned money: {earnedMoney}lv.");
                    return;
                }
            }

            if (earnedMoney < moneyGoal)
            {
                Console.WriteLine($"Target not reached! You need {moneyGoal - earnedMoney}lv. more.");
                Console.WriteLine($"Earned money: {earnedMoney}lv.");
            }
        }
    }
}
