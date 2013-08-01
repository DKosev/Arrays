using System;

/* Write a program that finds in given array of integers a sequence of given sum S (if present).
 * Example: {4, 3, 1, 4, 2, 5, 8}, S = 11 => {4, 2, 5} */

class SequenceOfGivenSum
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

            Console.Write("Enter a value for S:\n=> ");
            int valueS = int.Parse(Console.ReadLine());
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                int tempSum = 0;
                for (int j = i; j < arrayNumbers.Length; j++)
                {
                    int current = j - i + 1;
                    if ((tempSum += arrayNumbers[j]) == valueS)
                    {
                        for (int k = 0; k < current; k++)
                        {
                            Console.Write(arrayNumbers[i + k] + " ");
                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}