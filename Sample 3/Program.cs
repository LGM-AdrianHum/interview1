using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_3
{
    using System;
    using System.Linq;

    class Program
    {
        /*
         Question:
            Write a function that takes an integer n as input and prints the numbers from 1 to n, following these rules:

                For multiples of 3, print "Fizz" instead of the number.
                For multiples of 5, print "Buzz" instead of the number.
                For numbers that are multiples of both 3 and 5, print "FizzBuzz".
            
        For example, if n is 15, the output should be:
            1
            2
            Fizz
            4
            Buzz
            Fizz
            7
            8
            Fizz
            Buzz
            11
            Fizz
            13
            14
            FizzBuzz
         
         Please read the question carefully.

         */
        
        static void Main()
        {


            // Change the value of 'n' to set the range of numbers (1 to n) for FizzBuzz
            // Do NOT use a for(var i...) loop. Hint... Use Linq or Lambda
            int n = 100;

            var fizzBuzzList = new List<string> { "" };

            foreach (var item in fizzBuzzList)
            {
                Console.WriteLine($"{fizzBuzzList.IndexOf(item)}. {item}");
            }
        }
    }
}
