using System;
using Domain;

namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoApp todoApp;

            Console.WriteLine("- console - to use System.Console as input/output");
            Console.WriteLine("- inmemory - to use in-memory input / output");
            Console.WriteLine("- file - to use file input / output");

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
                case "file":
                    var fileIO = new FileInputOutput();

                    todoApp = new TodoApp(fileIO);
                    break;
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
                        try
                        {
                            todoApp.Add();
                        }
                        catch (NotImplementedException)
                        {
                            Console.WriteLine("Option is not supported yet");
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                        }
                        break;
                    case "print":
                        try
                        {
                            todoApp.Print();
                        }
                        catch (NotImplementedException)
                        {
                            Console.WriteLine("Option is not supported yet");
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                        }
                        break;
                    default: continue;
                }
            }
        }
    }
}
