using System;

/* *Write a program that reads an array of integers and removes from it a minimal number of 
 * elements in such way that the remaining array is sorted in increasing order. 
 * Print the remaining sorted array. Example:
 * {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5} */

class RemoveFromArray
{
    static int[] resultArray;
    static int resultElementsCount;

    static void CreateSubset(int[] arrayNumbers, int[] subset, int i, int current, int k)
    {
        if (i == k)
        {
            CheckSubset(subset, k);
            return;
        }

        for (int j = current; j < arrayNumbers.Length; j++)
        {
            subset[i] = arrayNumbers[j];
            CreateSubset(arrayNumbers, subset, i + 1, j + 1, k);
        }
    }
 
    static void CheckSubset(int[] subset, int elements)
    {      
        for (int i = 1; i < elements; i++)
        {
            if (subset[i] < subset[i - 1])
            {
                return;
            }
         
            if (i > resultElementsCount)
            {
                resultElementsCount = i;                
                for (int j = 0; j <= resultElementsCount; j++)
                {
                    resultArray[j] = subset[j];
                }
            }
        }      
    }
 
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

            resultArray = new int[arrayLength];
            int[] subset = new int[arrayLength];
            for (int k = 1; k <= arrayLength; k++)
            {
                CreateSubset(arrayNumbers, subset, 0, 0, k);
            }

            for (int i = 0; i <= resultElementsCount; i++)
            {
                Console.WriteLine("{0} ", resultArray[i]);
            }
        }
    }
}