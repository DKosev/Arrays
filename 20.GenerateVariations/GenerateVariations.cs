using System;

/* Write a program that reads two numbers N and K and generates all the 
 * variations of K elements from the set [1..N]. Example:
 * N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3} */

class GenerateVariations
{
    static void GenerateCombinations(int[] arrayNumbers, int valueN, int current)
    {
        if (current == arrayNumbers.Length)
        {
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.Write(arrayNumbers[i] + " ");
            }

            Console.WriteLine();
        }
        else
        {
            for (int i = 1; i <= valueN; i++)
            {
                arrayNumbers[current] = i;
                GenerateCombinations(arrayNumbers, valueN, current + 1);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter a value for N:\n=> ");
        int valueN = int.Parse(Console.ReadLine());
        Console.Write("Enter a value for K:\n=> ");
        int valueK = int.Parse(Console.ReadLine());

        if (valueN <= 0 || valueK <= 0)
        {
            Console.WriteLine("Error! Please try again.");
            Main();
        }

        int[] arrayNumbers = new int[valueK];
        GenerateCombinations(arrayNumbers, valueN, 0);
    }
}