using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_2
{
    internal class Program
    {
        static IEnumerable<int> GetEvenNumbers(int start, int end)
        {
            //Complete this program...
        }

        static void Main()
        {
            // Call the iterator method and get the even numbers from 1 to 10
            var evenNumbers = GetEvenNumbers(1, 10);

            // The iteration happens when you enumerate the sequence (e.g., with foreach)
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
