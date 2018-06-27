using System;
using System.Collections.Generic;
using System.Text;

namespace InteriorDesign
{
    public class VictorianHouse : HouseLayout
    {
        protected override void Decorating()
        {
            Console.WriteLine("You picked a Victorian style!");
        }

        protected override void Flooring()
        {
            Console.WriteLine("You picked dark stain walnut flooring!");
        }

        protected override void FloorPlan()
        {
            Console.WriteLine("You picked a traditional floor plan!");
        }

        protected override void Lighting()
        {
            Console.WriteLine("You picked a chandelier!");
        }
    }
}
