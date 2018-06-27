using System;

namespace Automobiles
{
    public class PickupTruck : IMotorVehicle
    {
        private int cargo;
        public bool AddCargo(int cargoToAdd)
        {
            if (cargoToAdd > 2000) return false;
            cargo = cargoToAdd;
            return true;
        }
        public void MoveForOneHour ()
        {
            //empty
        }
        public int GetDistanceTravelled()
        {
            return 0;
        }
    }
}
