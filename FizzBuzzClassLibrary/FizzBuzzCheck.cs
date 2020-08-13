using System;

namespace FizzBuzzClassLibrary
{
    public class FizzBuzzCheck
    {
        public static string Check(int number)
        {
            if (number == 0) return number.ToString();
            if (number % 15 == 0) return "FizzBuzz";
            if (number % 5 == 0) return "Buzz";
            if (number % 3 == 0) return "Fizz";
            return number.ToString();
        }
    }
}
