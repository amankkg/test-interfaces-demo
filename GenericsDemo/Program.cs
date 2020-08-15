using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var list1 = new MyStringList();
        }
    }

    class MyStringList
    {
        string[] values = new string[0];
    }
}
