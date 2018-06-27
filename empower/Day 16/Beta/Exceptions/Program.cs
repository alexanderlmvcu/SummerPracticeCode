using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var bob = new Person(20);
                var alice = new Person(-12);
            }
            catch (InvalidAgeException)
            {
                Console.WriteLine("There was a problem running the person objects");
            }
            finally
            {
                // always runs
            }

            Console.ReadKey();
        }
    }
}
