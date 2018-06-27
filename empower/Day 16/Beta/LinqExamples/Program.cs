using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //var sum = numbers.Sum();
            //Console.WriteLine(sum);
            //var sum = products.Sum(p => p.Price);
            //var max = products.Max(p => p.Price);
            //var min = products.Min(p => p.Price);
            //var avg = products.Average(p => p.Price);

            var products = new List<Product>();
            products.Add(new Product() { Name = "MP3 Player", Price = 31.99m });
            products.Add(new Product() { Name = "Suitcase", Price = 22 });
            products.Add(new Product() { Name = "Car", Price = 3200 });

            //var car = products.Single(p => p.Name == "Car");
            //var any = products.Any(p => p.Name == "Car");
            //var numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.Add(3);
            //numbers.Add(3);
            //var distinct = numbers.Distinct();
            var items = products.Where(p => p.Name == "Car");
            

            Console.ReadKey();
        }
    }
}
