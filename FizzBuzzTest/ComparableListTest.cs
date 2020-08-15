using FizzBuzzClassLibrary;
using Xunit;

namespace FizzBuzzTest
{
    public class ComparableListTest
    {
        [Fact]
        public void InitializeEmptyList()
        {
            var list = new ComparableList<string>();
            
            Assert.Equal(0, list.Length());
        }

        [Fact]
        public void AddLengthChange()
        {
            var list = new ComparableList<int>();
            
            list.Add(1);

            Assert.Equal(1, list.Length());
        }

        [Fact]
        public void GetByIndex()
        {
            var list = new ComparableList<decimal>();

            list.Add(1m);

            Assert.Equal(1m, list.Get(0));
        }

        [Fact]
        public void RemoveByIndex()
        {
            var list = new ComparableList<bool>();
            list.Add(false);

            list.Remove(0);

            Assert.Equal(0, list.Length());
        }

        [Fact]
        public void CompareByIndices()
        {
            var list = new ComparableList<double>();
            list.Add(2.5);
            list.Add(2.6);

            Assert.Equal(0, list.Compare(0, 0));
            Assert.Equal(1, list.Compare(1, 0));
            Assert.Equal(-1, list.Compare(0, 1));
        }
    }
}
