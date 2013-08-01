﻿using System;

/* Write a program that finds the maximal sequence of equal elements in an array. */

class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter the lenght of the array:\n=> ");
        int arrayLength = int.Parse(Console.ReadLine());

        if (arrayLength <= 0)
        {
            Console.WriteLine("Error! Please try again.");
            Main();
        }
        else
        {
            int[] arrayOfNumbers = new int[arrayLength];
            Console.WriteLine("Now enter the {0} numbers:", arrayLength);
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.Write("{0} number = ", i + 1);
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            int previousIndex = 1, currentValue = 0, finalPrint = 0;
            for (int j = 0; j < arrayOfNumbers.Length - 1; j++)
            {
                if (arrayOfNumbers[j] == arrayOfNumbers[j + 1])
                {
                    previousIndex++;
                }

                if (previousIndex > currentValue)
                {
                    currentValue = previousIndex;
                    finalPrint = arrayOfNumbers[j];
                }
                else
                {
                    previousIndex = 1;
                }
            }

            Console.Write("The sequence is: ");
            for (int k = 0; k < currentValue; k++)
            {
                if (arrayLength == 1)
                {
                    Console.WriteLine("There isn't a sequence.");
                }
                else
                {
                    Console.Write(finalPrint + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
