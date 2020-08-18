using System;
using System.Collections.Generic;

namespace FP
{
    class Program
    {
        Func<int, int, double> Division; // (int, int) => double
        Func<int, int, bool> IsEqual; // (int, int) => bool
        Predicate<int> IsEven; // (int) => bool
        Action<string> Log; // (string) => void

        static Func<int, int, Func<int>> GetAddFunction = (int a, int b) => () => a + b;

        static Func<int, int, Func<int, double>> AddAndDivide = (int a, int b) =>
        {
            var sum = a + b;

            return (int c) => sum / (double)c;
        };

        static IEnumerable<string> Filter(IEnumerable<string> values, Predicate<string> predicate)
        {
            var result = new List<string>();

            foreach (var value in values) if (predicate(value)) result.Add(value);

            return result;
        }

        static void Main(string[] args)
        {
            var addFn = GetAddFunction(5, 7);
            var addResult = addFn();
            Console.WriteLine(addResult);

            var divideBy = AddAndDivide(2, 3);
            var divideResult = divideBy(2);
            Console.WriteLine(divideResult);

            string[] values = new string[] { "", "1", "2", "" };

            var emptyValues0 = Filter(values, delegate (string x) { return x.Length > 0; });
            var emptyValues1 = Filter(values, x => x.Length > 0);
            var emptyValues2 = Filter(values, NotEmpty);
            var emptyValues3 = Filter(values, LocalNotEmpty);

            return;

            bool LocalNotEmpty(string value) => value.Length > 0;
        }

        static bool NotEmpty(string value) => value.Length > 0;
    }
}
