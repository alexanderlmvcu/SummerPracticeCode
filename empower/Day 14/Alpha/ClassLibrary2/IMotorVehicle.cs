using System;

namespace Automobiles
{
    public interface IMotorVehicle
    {
        bool AddCargo(int cargo);
        void MoveForOneHour();
        int GetDistanceTravelled();
    }
}
