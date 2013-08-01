using System;

/* Write a program that finds the sequence of maximal sum in given array. Example:
 * {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
 * Can you do it with only one loop (with single scan through the elements of the array)? */

class MaximalSumSequence
{
    static void Main()
    {
        Console.WriteLine("How long to be the array?");
        int arrayLength = int.Parse(Console.ReadLine());

        if (arrayLength <= 0)
        {
            Console.WriteLine("Error! Please try again.");
            Main();
        }
        else
        {
            int[] arrayNumbers = new int[arrayLength];
            Console.WriteLine("You have to enter {0} numbers each on a new line:", arrayLength);
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.Write("Enter the {0} number: ", i + 1);
                arrayNumbers[i] = int.Parse(Console.ReadLine());
            }

            int maximal = arrayNumbers[0];
            int current = arrayNumbers[0];
            int maxIndex = 0;
            int lenght = 1;
            int currIndex = 0;
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                current += arrayNumbers[i];
                if (arrayNumbers[i] > current)
                {
                    current = arrayNumbers[i];
                    currIndex = i;
                }
                else if (current > maximal)
                {
                    maximal = current;
                    maxIndex = currIndex;
                    lenght = i - currIndex + 1;
                }
            }

            for (int i = 0; i < lenght; i++)
            {
                Console.Write(arrayNumbers[maxIndex + i] + " ");
            }

            Console.WriteLine();
        }
    }
}