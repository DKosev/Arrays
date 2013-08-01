using System;

/* Write a program that reads two numbers N and K and generates 
 * all the combinations of K distinct elements from the set [1..N]. Example:
 * N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5} */

class GenerateVariationsDistinct
{
    static void GenerateCombinations(int[] arrayNumbers, int valueN, int valueK, int current)
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
            for (int i = valueK; i <= valueN; i++)
            {
                arrayNumbers[current] = i;
                GenerateCombinations(arrayNumbers, valueN, i + 1, current + 1);
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
        GenerateCombinations(arrayNumbers, valueN, 1, 0);
    }
}
