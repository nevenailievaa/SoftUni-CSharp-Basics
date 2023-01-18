using System;


internal class Program
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        for (int i = firstNum; i <= secondNum; i++)
        {
            int totalNum = i;
            int currentNum = 0;
            int odd = 0;
            int even = 0;

            currentNum = (totalNum % 10) / 1;
            odd += currentNum;
            totalNum -= currentNum;

            currentNum = (totalNum % 100) / 10;
            even += currentNum;
            totalNum -= currentNum;

            currentNum = (totalNum % 1000) / 100;
            odd += currentNum;
            totalNum -= currentNum;

            currentNum = (totalNum % 10000) / 1000;
            even += currentNum;
            totalNum -= currentNum;

            currentNum = (totalNum % 100000) / 10000;
            odd += currentNum;
            totalNum -= currentNum;

            currentNum = (totalNum % 1000000) / 100000;
            even += currentNum;
            totalNum -= currentNum;

            if (even == odd) Console.Write($"{i} ");
        }
    }
}