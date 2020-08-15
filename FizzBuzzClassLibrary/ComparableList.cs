namespace FizzBuzzClassLibrary
{
    public class ComparableList<TValue>
        where TValue : System.IComparable
    {
        TValue[] values = new TValue[0];

        public int Length() => values.Length;
        public TValue Get(int index) => values[index];

        public void Add(TValue value)
        {
            var newValues = new TValue[values.Length + 1];

            for (var i = 0; i < values.Length; i++)
                newValues[i] = values[i];

            newValues[newValues.Length - 1] = value;
            values = newValues;
        }

        public void Remove(int index)
        {
            var newValues = new TValue[values.Length - 1];

            for (var i = 0; i < values.Length; i++)
            {
                var j = i;

                if (j == index) continue;
                if (j > index) j -= 1;

                newValues[j] = values[i];
            }

            values = newValues;
        }

        public int Compare(int i, int j) => values[i].CompareTo(values[j]);
    }
}
