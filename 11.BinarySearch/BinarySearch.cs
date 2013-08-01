using System;

/* Write a program that finds the index of given element in a sorted array of integers 
 * by using the binary search algorithm (find it in Wikipedia). */

class BinarySearch
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

            Console.Write("Enter the number that you want to check if exist in the array:\n=> ");
            int searchedNumber = int.Parse(Console.ReadLine());

            Array.Sort(arrayNumbers);
            int result = Array.BinarySearch(arrayNumbers, searchedNumber);
            if (result < 0)
            {
                Console.WriteLine("The entered number doesn't exist in the array.");
            }
            else
            {
                Console.Write("The sorted array: ");
                for (int i = 0; i < arrayNumbers.Length; i++)
                {
                    Console.Write(arrayNumbers[i] + " ");
                }

                Console.WriteLine("\nThe entered number has index {0} in the array and it is on {1} position.", result, result + 1);
            }
        }
    }
}