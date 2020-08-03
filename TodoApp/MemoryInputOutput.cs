using System.Collections.Generic;
using TodoAppLogic;

namespace TodoCLI
{
    class MemoryInputOutput : IInputOutput
    {
        private readonly List<string> Inputs;
        public IList<string> Outputs { get; private set; }
        private int current = 0;

        public MemoryInputOutput(IEnumerable<string> inputs)
        {
            Outputs = new List<string>();
            Inputs = new List<string>();

            Inputs.AddRange(inputs);
        }

        public string Read()
        {
            return Inputs[current++];
        }

        public void Write(string text)
        {
            Outputs.Add(text);
        }
    }
}
