using System.Collections.Generic;
using Domain;

namespace CLI
{
    class MemoryInputOutput : IInputOutput
    {
        private readonly List<string> Inputs;
        private int current = 0;

        public MemoryInputOutput(IEnumerable<string> inputs)
        {
            Inputs = new List<string>();

            Inputs.AddRange(inputs);
        }

        public string Read()
        {
            return Inputs[current++];
        }
    }
}
