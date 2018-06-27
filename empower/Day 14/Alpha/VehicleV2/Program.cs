using System;

namespace VehicleV2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var efficient = new FuellEfficientVehicle();
            var fast = new SuperFastVehicle();

            efficient.AddFuel(100);
            fast.AddFuel(100);

            efficient.Move();
            fast.Move();

            var truck = new Truck();
            truck.AddFuel(100);
        }
    }
}
