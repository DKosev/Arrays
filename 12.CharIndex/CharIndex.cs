using System;

/* Write a program that creates an array containing all letters from the alphabet (A-Z). 
 * Read a word from the console and print the index of each of its letters in the array. */

class CharIndex
{
    static void Main()
    {
        char[] alphabet = new char[26];

        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = Convert.ToChar('A' + i);
        }

        Console.Write("Enter the string:\n=> ");
        string inputString = Console.ReadLine().ToUpper();

        for (int j = 0; j < inputString.Length; j++)
        {
            Console.WriteLine(inputString[j] + " = " + (inputString[j] - 'A'));
        }
    }
}
