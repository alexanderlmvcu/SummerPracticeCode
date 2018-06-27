using System;
using System.Collections.Generic;

namespace CollectionsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Pet>();
            list.Add(new Pet()
            {
                Name = "Jeff",
                Age = 13,
                IsSpotted = true,
                Color = "Black and White"
            });

            list.Add(new Pet()
            {
                Name = "Loretta",
                Age = 3,
                IsSpotted = false,
                Color = "Brown"
            });

            foreach (var pet in list)
            {
                Console.WriteLine(pet.Name);
            }
            Console.ReadKey();
        }
        static void DictionaryExample()
        {
            var dictionary = new Dictionary<string, Pet>();
            dictionary.Add("Jeff",new Pet()
            {
                Name = "Jeff",
                Age = 13,
                IsSpotted = true,
                Color = "Black and White"
            });

            dictionary.Add("Loretta",new Pet()
            {
                Name = "Loretta",
                Age = 3,
                IsSpotted = false,
                Color = "Brown"
            });

            var loretta = dictionary["Loretta"];
            Console.WriteLine("Found " + loretta.Name + "! Age: " + loretta.Age.ToString());
            Console.ReadKey();
        }
        static void QueueExample()
        {
            var jeff = new Pet() { Name = "Jeff" };
            var loretta = new Pet() { Name = "Loretta" };

            var queue = new Queue<Pet>();
            queue.Enqueue(jeff);
            queue.Enqueue(loretta);

            Console.WriteLine(queue.Dequeue().Name);
            Console.WriteLine(queue.Dequeue().Name);
        }
        static void StackExample()
        {
            var jeff = new Pet() { Name = "Jeff" };
            var loretta = new Pet() { Name = "Loretta" };

            var stack = new Stack<Pet>();
            stack.Push(jeff);
            stack.Push(loretta);

            while (stack.Count > 0)
            {
                var pet = stack.Pop();
                Console.WriteLine(pet.Name);
            }
        }
    }
}
