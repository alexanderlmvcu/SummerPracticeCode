using System;
using System.Collections.Generic;

namespace AddingExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var sumFunction = new SumFunction();
            //sumFunction.Insert(3);
            //sumFunction.Insert(4);
            //Console.WriteLine(sumFunction.Calculate());
            //Console.ReadKey();

            //var averageFunction = new AverageFunction();
            //averageFunction.Insert(3);
            //averageFunction.Insert(4);
            //Console.WriteLine(averageFunction.Calculate());
            var function = new SumFunction();
            Execute(function);

            Console.ReadKey();

        }
        static void Execute(IAggregate function)
        {
            function.Insert(4);
            function.Insert(4);
            Console.WriteLine(function.Calculate());
        }
    }
}
