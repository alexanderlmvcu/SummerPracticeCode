using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleV2
{
    public class SuperFastVehicle : MotorVehicle
    {
        protected override int CalculateFuelDepletion()
        {
            return 45;
        }
        protected override bool Move()
        {
            return 2;
        }
    }
}
