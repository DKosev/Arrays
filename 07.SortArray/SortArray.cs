using System;

/* Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
 * Use the "selection sort" algorithm: Find the smallest element, move it at the first position, 
 * find the smallest from the rest, move it at the second position, etc. */

class SortArray
{
    static void Sorting(int[] arrayNumbers)
    {
        for (int i = 0; i < arrayNumbers.Length - 1; i++)
        {
            int smallestNumber = arrayNumbers[i];
            int changedNumber = -1;
            int temp = 0;
            for (int j = i + 1; j < arrayNumbers.Length; j++)
            {
                if (arrayNumbers[j] < smallestNumber)
                {
                    smallestNumber = arrayNumbers[j];
                    changedNumber = j;
                }
            }

            if (changedNumber > -1)
            {
                temp = arrayNumbers[i];
                arrayNumbers[i] = arrayNumbers[changedNumber];
                arrayNumbers[changedNumber] = temp;
            }
        }
    }
    
    static void Main()
    {
        Console.WriteLine("How long to be the array?");
        int arrayLength = int.Parse(Console.ReadLine());

        if (arrayLength <= 0)
        {
            Console.WriteLine("Error!. Please try again.");
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
            
            Sorting(arrayNumbers);
            Console.WriteLine("The entered numbers in increasing order:");
            for (int k = 0; k < arrayNumbers.Length; k++)
            {
                Console.Write(arrayNumbers[k] + " ");
            }

            Console.WriteLine();
        }
    }
}