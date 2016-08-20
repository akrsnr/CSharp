/*

The challenge is to print out all of the numbers from 1 to 100. Except if a number is a multiple of
3, print out the word “Fizz” instead. If the number is a multiple of 5, print out “Buzz”. If a number
is a multiple of both 3 and 5 (like 15 or 30) then print out “FizzBuzz”.

*/

using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 101; ++i)
            {
                Console.WriteLine(
                    (i % 15 == 0) ? "FizzBuzz" : (i % 5 == 0) ? "Buzz" : (i % 3 == 0) ? "Fizz" : $"{i}"
                );
            }
            Console.ReadKey();
            }
    }
}
