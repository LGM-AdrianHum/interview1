using System;

namespace Samples
{
    class Program
    {

        static bool IsPrime(long number)
        {
            if (number <= 1) return false;

            if (number == 2 || number == 3) return true;

            if (number % 2 == 0 || number % 3 == 0) return false;

          //Question: Please fix this code... hint the initial value of i is wrong and so is the incrementer
            for (long i = 1; i <= number; i += 1)
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
}
