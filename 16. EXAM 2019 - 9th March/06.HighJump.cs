using System;

namespace _06.HighJump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int wantedHeight = int.Parse(Console.ReadLine());
            int startingHeight = wantedHeight - 30;

            int jumpHeight = 0;
            int fails = 0;
            int jumps = 0;

            //ACTION
            for (int currentHeight = startingHeight; currentHeight <= wantedHeight; currentHeight += 5)
            {
                for (int tryNumber = 1; tryNumber <= 3; tryNumber++)
                {
                    jumpHeight = int.Parse(Console.ReadLine());

                    //succeeds
                    if (jumpHeight > currentHeight)
                    {
                        jumps++;
                        tryNumber = 3;
                    }
                    //fails
                    else if (jumpHeight <= currentHeight)
                    {
                        fails++;
                        jumps++;

                        if (fails == 3)
                        {
                            Console.WriteLine($"Tihomir failed at {currentHeight}cm after {jumps} jumps.");
                            return;
                        }
                    }
                }
                //RESTORE
                fails = 0;
            }

            //OUTPUT
            Console.WriteLine($"Tihomir succeeded, he jumped over {wantedHeight}cm after {jumps} jumps.");
        }
    }
}
