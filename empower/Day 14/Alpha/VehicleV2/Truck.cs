using System;

namespace VehicleV2
{
    public class Truck : MotorVehicle
    {
        protected override int CalculateFuelDepletion()
        {
            return 2;
        }
    }
}
