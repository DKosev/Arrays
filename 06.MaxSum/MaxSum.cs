using System;

/* Write a program that reads two integer numbers N and K and an array of N elements from the console. 
 * Find in the array those K elements that have maximal sum. */

class MaxSum
{
    static void Main()
    {
        Console.WriteLine("Enter a value for N:");
        int inputN = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value for K:");
        int inputK = int.Parse(Console.ReadLine());

        if (inputK > inputN || inputN <= 0)
        {
            Console.WriteLine("N have to be greater than K. Please try again!");
            Main();
        }
        else
        {
            int[] arrayNumbers = new int[inputN];
            Console.WriteLine("You have to enter {0} numbers each on a new line:", inputN);
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.Write("Enter the {0} number: ", i + 1);
                arrayNumbers[i] = int.Parse(Console.ReadLine());
            }

            int temp = 0;
            for (int i = 0; i < arrayNumbers.Length - 1; i++)
            {
                for (int j = 1; j < arrayNumbers.Length; j++)
                {
                    if (arrayNumbers[j] > arrayNumbers[j - 1])
                    {
                        temp = arrayNumbers[j - 1];
                        arrayNumbers[j - 1] = arrayNumbers[j];
                        arrayNumbers[j] = temp;
                    }
                }
            }

            Console.WriteLine("The maximal sum is between these numbers from the array:");
            for (int k = 0; k < inputK; k++)
            {
                Console.Write(arrayNumbers[k] + " ");
            }

            Console.WriteLine();
        }
    }
}