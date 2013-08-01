using System;
using System.Collections.Generic;

/* * Write a program that reads a number N and generates 
 * and prints all the permutations of the numbers [1 … N]. Example:
 * n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1} */

class GeneratePermutations
{
    static void Main(string[] args)
    {
        Console.Write("Enter the last number to veiw all combinations of the numbers 1 ... n:\n=> ");
        int lastNumber = int.Parse(Console.ReadLine());

        List<int> listNumbers = new List<int>();
        for (int i = 0; i < lastNumber; i++)
        {
            Console.Write("Enter the {0} number: ", i + 1);
            listNumbers.Add(int.Parse(Console.ReadLine()));
        }

        GetCombination(listNumbers);
    }

    static void GetCombination(List<int> listNumbers)
    {
        double count = Math.Pow(2, listNumbers.Count);
        for (int i = 1; i <= count - 1; i++)
        {
            string str = Convert.ToString(i, 2).PadLeft(listNumbers.Count, '0');
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] == '1')
                {
                    Console.Write(listNumbers[j] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
