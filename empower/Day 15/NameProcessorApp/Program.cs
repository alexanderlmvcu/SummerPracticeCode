using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            var nameProcessor = new NameProcessor();
            nameProcessor.Add("bob");
            nameProcessor.Add("Alice");
            nameProcessor.Add("Bobby");
            nameProcessor.Add("alina");

            var bobs = nameProcessor.GetNamesStartingWith("Bob");
            var alis = nameProcessor.GetNamesStartingWith("Ali");
            var charlies = nameProcessor.GetNamesStartingWith("Charlie");

        }
    }
}