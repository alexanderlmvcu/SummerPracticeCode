using System;

namespace Automobiles
{
    public class SportsCar : IMotorVehicle
    {
        private int cargo;
        public bool AddCargo(int cargo)
        {
            if (cargo > 100) return false;
            this.cargo = cargo;
            return true;
            //validation check, with an early evacuation if the weight is too large
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
