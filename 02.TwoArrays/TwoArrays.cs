using System;

/* Write a program that reads two arrays from the console and compares them element by element. */

class TwoArrays
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want to add in the both arrays:\n=> ");
        int numbersInArray = int.Parse(Console.ReadLine());

        if (numbersInArray <= 0)
        {
            Console.WriteLine("Error! Please try again.");
            Main();
        }
        else
        {
            int[] firstArray = new int[numbersInArray];
            int[] secondArray = new int[numbersInArray];
            Console.WriteLine("Add {0} numbers to fill the first Array:", numbersInArray);
            for (int i = 0; i < numbersInArray; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Add {0} numbers to fill the second Array:", numbersInArray);
            for (int i = 0; i < numbersInArray; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbersInArray; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    Console.WriteLine("{0} is equal to {1}", firstArray[i], secondArray[i]);
                }
                else
                {
                    Console.WriteLine("{0} isn't equal to {1}", firstArray[i], secondArray[i]);
                }
            }
        }
    }
}