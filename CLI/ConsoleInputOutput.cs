using System;
using Domain;

namespace CLI
{
    class ConsoleInputOutput : IInputOutput
    {
        public string Read()
        {
            return Console.ReadLine();
        }

        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}
