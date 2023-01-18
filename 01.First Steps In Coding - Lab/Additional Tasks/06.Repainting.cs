using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int nylonNeeded = int.Parse(Console.ReadLine());
            int paintNeeded = int.Parse(Console.ReadLine());
            int diluentNeeded = int.Parse(Console.ReadLine());
            int hoursNeeded = int.Parse(Console.ReadLine());

            //Action
            double nylonPrice = (nylonNeeded + 2) * 1.50;
            double paintPrice = (paintNeeded + (0.1 * paintNeeded)) * 14.50;
            double diluentPrice = diluentNeeded * 5.00;

            double bill = nylonPrice + paintPrice + diluentPrice + 0.40;
            double billForWork = (bill * 0.3) * hoursNeeded;
            double result = billForWork + bill;
            //Output
            Console.WriteLine(result);
        }
    }
}
