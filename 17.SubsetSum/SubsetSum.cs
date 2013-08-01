using System;

class SubsetSum
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

            Console.WriteLine("Enter the sum that you want to check:");
            int subsetSum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of elements:");
            int sumElements = int.Parse(Console.ReadLine());

            int columns = arrayNumbers.Length;
            int rows = (int)Math.Pow(2, arrayLength) - 1;
            int[] sumSeq = new int[arrayLength];
            bool addSum = false;

            for (int i = rows - 1; i > 1; i--)
            {
                int remainder = i;
                int sum = 0;
                int sumSec = 0;

                for (int j = 0; j < columns; j++)
                {
                    if (remainder % 2 != 0)
                    {
                        addSum = true;
                        for (int p = 0; p < sumSec; p++)
                        {
                            if (arrayNumbers[j] == sumSeq[p])
                            {
                                addSum = false;
                            }
                        }

                        if (addSum == true)
                        {
                            sumSeq[sumSec++] = arrayNumbers[j];
                            sum += arrayNumbers[j];
                        }
                    }

                    remainder = remainder / 2;
                }

                if (sum == subsetSum)
                {
                    if (sumSec == sumElements)
                    {
                        for (int k = 0; k < sumSec; k++)
                        {
                            Console.Write("{0} ", sumSeq[k]);
                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}