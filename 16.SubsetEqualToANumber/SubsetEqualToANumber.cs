using System;

/* *We are given an array of integers and a number S. Write a program to find if there exists a subset of the 
 *  elements of the array that has a sum S. Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6) */

class SubsetEqualToANumber
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

            Console.Write("Now enter the S value:\n=> ");
            int sumValue = int.Parse(Console.ReadLine());

            int subsetSum = 0;
            bool[] checkSum = new bool[arrayLength];

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                subsetSum += arrayNumbers[i];
                if (subsetSum == sumValue)
                {
                    checkSum[i] = true;
                }
                else if (subsetSum > sumValue)
                {
                    subsetSum = subsetSum - arrayNumbers[i];
                    checkSum[i] = false;
                }
                else
                {
                    checkSum[i] = true;
                }
            }

            if (subsetSum == sumValue)
            {
                for (int i = 0; i < arrayNumbers.Length; i++)
                {
                    if (checkSum[i] == true)
                    {
                        Console.WriteLine(arrayNumbers[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("There isn't a subset equal to {0}", sumValue);
            }
        }
    }
}
