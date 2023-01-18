using System;

namespace _05.CharacterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string input = Console.ReadLine();

            //Actions
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                Console.WriteLine(letter);
            }
        }
    }
}
