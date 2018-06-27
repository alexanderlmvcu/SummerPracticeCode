using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleV2
{
    public abstract class MotorVehicle
    {
        protected int fuel;
        protected abstract int CalculateFuelDepletion();

        public void AddFuel(int fuelToAdd)
        {
            fuel += fuelToAdd;
        }
        public void Move()
        {
                fuel -= CalculateFuelDepletion();
        }
    }
}
