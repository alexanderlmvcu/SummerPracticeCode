using System;
using System.Collections.Generic;
using System.Text;

namespace InteriorDesign
{
    public class MinimalistHouse : HouseLayout
    {
        protected override void Decorating()
        {
            Console.WriteLine("You picked a minimalist style!");
        }

        protected override void Flooring()
        {
            Console.WriteLine("You picked tile flooring!");
        }

        protected override void FloorPlan()
        {
            Console.WriteLine("You picked an open floor plan!");
        }

        protected override void Lighting()
        {
            Console.WriteLine("You picked a recessed and sky lighting!");
        }
    }
}
