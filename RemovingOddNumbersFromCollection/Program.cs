using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RemovingOddNumbersFromCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Remove odd numbers

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 1)
                {
                    numbers.RemoveAt(i);
                }
            }

            // lambda expression
            numbers.ForEach(number => Console.Write(number + ", "));


        }
    }
}
