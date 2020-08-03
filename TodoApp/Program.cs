using System;
using TodoAppLogic;

namespace TodoCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoApp todoApp;

            Console.WriteLine("- console - to use System.Console as input/output\n - inmemory - to use in-memory input/output");
            var choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case "console":
                    var consoleIO = new ConsoleInputOutput();

                    todoApp = new TodoApp(consoleIO);
                    break;
                case "inmemory":
                    var inputs = new string[] { "buy a milk", "go to dentist" };
                    var inMemoryIO = new MemoryInputOutput(inputs);

                    todoApp = new TodoApp(inMemoryIO);
                    break;
                //case "file":
                //    break;
                default:
                    throw new Exception("bad choice");
            }

            while (true)
            {
                Console.WriteLine("Available commands: add, print");
                choice = Console.ReadLine();

                switch (choice.ToLower())
                {
                    case "add":
                        todoApp.Add();
                        break;
                    case "print":
                        todoApp.Print();
                        break;
                    default: continue;
                }
            }
        }
    }
}
