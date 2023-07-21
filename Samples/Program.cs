﻿using System;

class Program
{
    static bool IsPrime(long number)
    {
        if (number <= 1)
            return false;

        if (number == 2 || number == 3)
            return true;

        if (number % 2 == 0 || number % 3 == 0)
            return false;

        // Use trial division to check for divisors up to the square root of 'number'
        for (long i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        long num = long.Parse(Console.ReadLine());

        bool isPrime = IsPrime(num);

        Console.WriteLine($"{num} is {(isPrime ? "prime" : "not prime")}.");
    }
}