using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameProcessor = new NameProcessor();
            nameProcessor.Add("Allison");
            nameProcessor.Add("robert");
            nameProcessor.Add("Charles");
            nameProcessor.Add("Bobby");

            var allis = nameProcessor.GetNamesStartingWith("All");
            var bobs = nameProcessor.GetNamesStartingWith("Bob");
            var charso = nameProcessor.GetNamesStartingWith("alina");
            Console.WriteLine(nameProcessor.GetNamesStartingWith("All").ToString());
            Console.ReadKey();
        }
    }
}
