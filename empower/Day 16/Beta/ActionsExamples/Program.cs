using System;

namespace ActionsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute();
            Action exec = Execute;
            Func<bool> execBool = ExecuteBool;
            exec(); //can invoke action via variable name, capturing a pointer (the ability to execute) to a method
            var result = execBool();

            Action doStuff = () => { };

            Console.ReadKey();
        }
        static void Execute()
        {
            Console.WriteLine("Execute was called.");
        }
        static bool ExecuteBool()
        {
            Console.WriteLine("ExecuteBool was called.");
            return true;
        }
    }
}
