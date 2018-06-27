using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMobilesApp
{
    public class SportsCar : IMotorVehicle
    {
        public void Go()
        {
            Console.WriteLine("I can go really fast");
        }
    }
}
