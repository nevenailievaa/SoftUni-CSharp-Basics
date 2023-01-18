using System;

namespace _06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int numberFloors = int.Parse(Console.ReadLine());
            int numberRooms = int.Parse(Console.ReadLine());

            //ACTION
            for (int f = numberFloors; f >= 1; f--)
            {
                for (int r = 0; r < numberRooms; r++)
                {
                    if (f == numberFloors)
                    {
                        Console.Write($"L{f}{r} ");
                    }
                    else if (f % 2 == 1)
                    {
                        
                        Console.Write($"A{f}{r} ");
                    }
                    else if (f % 2 == 0)
                    {
                        Console.Write($"O{f}{r} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
