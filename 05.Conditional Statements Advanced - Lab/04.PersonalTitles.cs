using System;

namespace _04.PersonalTitles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            //Action
            if (gender == "m")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else if (age < 16)
                {
                    Console.WriteLine("Master");
                }
            }
            else if (gender == "f")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
