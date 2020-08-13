using System;
using FizzBuzzClassLibrary;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = -100; i <= 100; i++)
            {
                var result = FizzBuzzCheck.Check(i);
                
                Console.WriteLine(result);
            }
        }
    }
}
