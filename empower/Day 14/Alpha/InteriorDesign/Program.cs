using System;

namespace InteriorDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            var decoStyle1 = new MinimalistHouse();
            decoStyle1.Build();
            var decoStyle2 = new VictorianHouse();
            decoStyle2.Build();

            Console.ReadKey();
        }
    }
}
