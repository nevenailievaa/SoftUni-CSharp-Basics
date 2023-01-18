using System;

namespace _06.VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string word = Console.ReadLine();
            int sum = 0;

            //Action
            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
