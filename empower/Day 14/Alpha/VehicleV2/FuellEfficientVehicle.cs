using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleV2
{
    public class FuellEfficientVehicle : MotorVehicle
    {
        protected override int CalculateFuelDepletion()
        {
            return 1;
        }
        protected override int Move()
        {
            return 5;
        }
    }
}
