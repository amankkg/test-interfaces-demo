using System.Collections.Generic;

namespace Domain
{
    public class TodoApp
    {
        private readonly IInputOutput IO;

        public IList<string> Todos { get; private set; }

        public TodoApp(IInputOutput io)
        {
            Todos = new List<string>();
            IO = io;
        }

        public void Add()
        {
            var todo = IO.Read();

            Todos.Add(todo);
        }

        public void Print()
        {
            foreach (var todo in Todos)
                IO.Write(todo);
        }
    }
}
