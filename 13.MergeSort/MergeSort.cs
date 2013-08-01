using System;

/* *Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia). */

public class MergeSort
{
    public static void Sort(int[] numbers, int leftPart, int rightPart)
    {
        if (leftPart < rightPart)
        {
            int middlePart = (leftPart + rightPart) / 2;
            Sort(numbers, leftPart, middlePart);
            Sort(numbers, middlePart + 1, rightPart);
            Merge(numbers, leftPart, middlePart, middlePart + 1, rightPart);
        }
    }
    
    public static void Merge(int[] numbers, int leftPart, int middlePart, int middleSecond, int rightPart)
    {
        int oldPosition = leftPart;
        int size = rightPart - leftPart + 1;
        int[] temp = new int[size];
        int i = 0;

        while (leftPart <= middlePart && middleSecond <= rightPart)
        {
            if (numbers[leftPart] <= numbers[middleSecond])
            {
                temp[i++] = numbers[leftPart++];
            }
            else
            {
                temp[i++] = numbers[middleSecond++];
            }
        }

        if (leftPart > middlePart)
        {
            for (int j = middleSecond; j <= rightPart; j++)
            {
                temp[i++] = numbers[middleSecond++];
            }
        }
        else
        {
            for (int j = leftPart; j <= middlePart; j++)
            {
                temp[i++] = numbers[leftPart++];
            }
        }

        Array.Copy(temp, 0, numbers, oldPosition, size);
    }

    public static void Main()
    {
        Console.WriteLine("How long to be the array?");
        int inputN = int.Parse(Console.ReadLine());

        if (inputN <= 0)
        {
            Console.WriteLine("Error! Please try again.");
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

            Console.Write("The entered unsorted array:\n=> ");
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.Write(arrayNumbers[i] + " ");
            }

            Sort(arrayNumbers, 0, arrayNumbers.Length - 1);

            Console.Write("\nThe same array, merge sorted:\n=> ");
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.Write(arrayNumbers[i] + " ");
            }

            Console.WriteLine();
        }
    }
}