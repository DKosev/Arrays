using System;

/* Write a program that finds the most frequent number in an array. Example:
 * {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times) */

class MostFrequentNumber
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

            Array.Sort(arrayNumbers);
            int countNumber = 1;
            int frequency = 0;
            int frequentNumber = 1;
            for (int i = 0; i < arrayNumbers.Length - 1; i++)
            {
                if (arrayNumbers[i] == arrayNumbers[i + 1])
                {
                    countNumber++;
                    frequency = countNumber;
                    frequentNumber = arrayNumbers[i];
                }
                else
                {
                    countNumber = 1;
                }
            }

            if (arrayLength == 1)
            {
                Console.WriteLine("There is only 1 number in the array.");
            }
            else if (frequency == 0)
            {
                Console.WriteLine("There are only different numbers in the array.");
            }
            else
            {
                Console.WriteLine("Result: {0} ({1} times)", frequentNumber, frequency);
            }
        }
    }
}