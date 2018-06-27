using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMobilesApp
{
    public class PickUpTruck : IMotorVehicle
    {
        public void Go()
        {
            Console.WriteLine("I can carry lots of heavy stuff");
        }
    }
}
