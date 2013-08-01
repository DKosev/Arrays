using System;

/* Write a program that finds all prime numbers in the range [1...10 000 000]. 
 * Use the sieve of Eratosthenes algorithm (find it in Wikipedia). */

class SieveOfEratosthenes
{
    static void Main()
    {
        Console.Write("Enter a number to see all primes in the range of 1 to 'your number':\n=> ");
        int inputNumber = int.Parse(Console.ReadLine());
        
        var isPrime = new bool[inputNumber + 1];
        for (int i = 2; i <= inputNumber; i++)
        {
            isPrime[i] = true;
        }

        for (int i = 2; (i * i) <= inputNumber; i++)
        {
            for (int j = i * i; j <= inputNumber; j = j + i)
            {
                isPrime[j] = false;
            }
        }

        Console.WriteLine("Results: prime numbers between 2 and {0}:", inputNumber);
        for (int i = 2; i <= inputNumber; i++)
        {
            if (isPrime[i])
            {
                Console.Write("{0}  ", i);
            }
        }

        Console.WriteLine();
    }
}