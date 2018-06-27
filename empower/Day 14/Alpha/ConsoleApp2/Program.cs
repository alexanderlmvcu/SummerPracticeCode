using System;
using System.Text;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var adder = new Adder();
            foreach (var arg in args)
            {
                var value = int.Parse(arg);
                adder.Add(value);
            }
            Console.WriteLine(adder.Calculate());
            Console.ReadKey();

            //var adder = new Adder();
            //adder.Add(1);
            //adder.Add(2);
            //adder.Add(3);

            //var result = adder.Calculate();
            //Console.WriteLine(result.ToString());

            //var adder2 = new Adder();
            //adder2.Add(10);
            //adder2.Add(25);
            //Console.WriteLine(adder2.Calculate().ToString());
            ////Console.WriteLine();
            //Console.ReadKey();
        }
    }
}
