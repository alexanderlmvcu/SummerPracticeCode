using System;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 0;
            foreach (var stringValue in args)
            {
               // var intValue = int.Parse(stringValue);
                if (int.TryParse(stringValue, out int intValue))
                {
                    //Success location
                    result += intValue;
                }
                
            }
            Console.WriteLine(result.ToString());

            Console.ReadKey();
        }
    }
}
