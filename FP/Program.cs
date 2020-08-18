using System.Collections.Generic;

namespace FP
{
    class Program
    {
        delegate bool PredicateDelegate(string value);

        static IEnumerable<string> Filter(IEnumerable<string> values, PredicateDelegate predicate)
        {
            var result = new List<string>();

            foreach (var value in values) if (predicate(value)) result.Add(value);

            return result;
        }

        static void Main(string[] args)
        {
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
