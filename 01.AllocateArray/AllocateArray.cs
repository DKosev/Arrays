using System;

/* Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
   Print the obtained array on the console. */

class AllocateArray
{
    static void Main()
    {
        int[] listNumbers = new int[20];

        for (int i = 0; i < listNumbers.Length; i++)
        {
            listNumbers[i] = i * 5;
            Console.WriteLine(listNumbers[i]);
        }
    }
}