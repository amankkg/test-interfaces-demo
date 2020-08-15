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

            var x = Identity(5m);
            var (foo, theAnswer) = AsTuple("foo", 42);
        }

        static T Identity<T>(T value) => value;
        static (T1, T2) AsTuple<T1, T2>(T1 t1, T2 t2) => (t1, t2);
    }
}
