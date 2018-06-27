using System;
using System.Collections.Generic;

namespace AutoMobilesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var motorvehicles = new List<IMotorVehicle>();
            motorvehicles.Add(new SportsCar());
            motorvehicles.Add(new PickUpTruck());
            motorvehicles.Add(new SportsCar());
            motorvehicles.Add(new PickUpTruck());

            foreach (var motorVehicle in motorvehicles)
            {
                motorVehicle.Go();
            }
            Console.ReadKey();
        }
    }
}
