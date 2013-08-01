using System;

/* Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia). */

class QuickSort
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
            string[] arrayStrings = new string[arrayLength];

            Console.WriteLine("You have to enter {0} strings each on a new line:", arrayLength);
            for (int i = 0; i < arrayStrings.Length; i++)
            {
                Console.Write("Enter the {0} string: ", i + 1);
                arrayStrings[i] = Console.ReadLine();
            }

            for (int i = 0; i < arrayLength; i++)
            {
                int main = i;
                for (int j = 0; j < arrayLength; j++)
                {
                    if ((arrayStrings[j].Length < arrayStrings[main].Length && j > main) || 
                        (arrayStrings[j].Length > arrayStrings[main].Length && j < main))
                    {
                        string temp;
                        temp = arrayStrings[j];
                        arrayStrings[j] = arrayStrings[main];
                        arrayStrings[main] = temp;
                        main = j;
                    }
                }
            }

            Console.Write("The array, quick sorted:\n=> ");
            foreach (var result in arrayStrings)
            {
                Console.Write(result + "  ");
            }

            Console.WriteLine();
        }
    }
}