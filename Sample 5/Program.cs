using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    /*
     Question:
        Consider a list of integers. Your task is to find the sum of all even numbers greater than 10. Write a C# code snippet using lambda functions to accomplish this while ensuring that multiple enumerations of the list are avoided. Explain the importance of avoiding multiple enumerations in this scenario and how the lambda function helps achieve this efficiency.
     */
    static void Function1()
    {
        List<int> numbers = new List<int> { 5, 12, 8, 18, 7, 15, 21, 16, 9, 20 };

        
        List<int> evenNumbers = numbers.Where(num => num % 2 == 0).ToList();
        int sumEvenNumbers = evenNumbers.Sum();

        
        List<int> evenNumbersGreaterThanTen = evenNumbers.Where(num => num > 10).ToList();
        int sumEvenNumbersGreaterThanTen = evenNumbersGreaterThanTen.Sum();

        Console.WriteLine($"Sum of all even numbers: {sumEvenNumbers}");
        Console.WriteLine($"Sum of even numbers greater than 10: {sumEvenNumbersGreaterThanTen}");
    }
    static void Function2()
    {
        List<int> numbers = new List<int> { 5, 12, 8, 18, 7, 15, 21, 16, 9, 20 };

        
        Func<int, bool> evenGreaterThanTen = num => num > 10 && num % 2 == 0;

        
        int sum = numbers.Where(evenGreaterThanTen).Sum();

        Console.WriteLine($"Sum of even numbers greater than 10: {sum}");
    }
}