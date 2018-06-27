using System;

namespace ConsoleApp3Review
{
    class Program
    {
        static void Main(string[] args)
        {

            var person1 = new Person();
            var person2 = new Person();

            person1.Name = "Bob";
            person1.Age = 30;

            person2.Name = "Alice";
            person2.Age = 25;

            var person3 = person2;
            person3.Age = 27;

            Console.WriteLine("Hello World!");
        }
    }
}
