using System;

/* Write a program that compares two char arrays lexicographically (letter by letter). */

class CharArrays
{
    static void Main()
    {
        Console.Write("Enter how many chars you want to add in the both arrays:\n=> ");
        int charsInArray = int.Parse(Console.ReadLine());

        if (charsInArray <= 0)
        {
            Console.WriteLine("Error! Please try again.");
            Main();
        }
        else
        {
            char[] firstArray = new char[charsInArray];
            char[] secondArray = new char[charsInArray];
            Console.WriteLine("Add {0} chars to fill the first Array:", charsInArray);
            for (int i = 0; i < charsInArray; i++)
            {
                firstArray[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Add {0} chars to fill the second Array:", charsInArray);
            for (int i = 0; i < charsInArray; i++)
            {
                secondArray[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < charsInArray; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    Console.WriteLine("{0} is the same as {1}", firstArray[i], secondArray[i]);
                }
                else
                {
                    Console.WriteLine("{0} is different than {1}", firstArray[i], secondArray[i]);
                }
            }
        }
    }
}
