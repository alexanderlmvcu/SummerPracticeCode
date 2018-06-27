using System;
using System.Collections.Generic;

namespace Automobiles
{
    public class Sandbox
    {
        public void Execute()
        {
            var sc1 = new SportsCar();
            var sc2 = new SportsCar();
            var pu1 = new PickupTruck();
            var pu2 = new PickupTruck();

            var sedan = new Sedan();

            var motorVehicles = new List<IMotorVehicle>();
            motorVehicles.Add(sc1);
            motorVehicles.Add(sc2);
            motorVehicles.Add(pu1);
            motorVehicles.Add(pu2);
            motorVehicles.Add(sedan);

            foreach (var vehicle in motorVehicles)
            {
                vehicle.MoveForOneHour();
            }


            //var sportsCars = new List<SportsCar>();
            //sportsCars.Add(sc1);
            //sportsCars.Add(sc2);

            //var pickupTrucks = new List<PickupTruck>();
            //pickupTrucks.Add(pu1);
            //pickupTrucks.Add(pu2);

            //foreach (var auto in sportsCars)
            //{
            //    auto.MoveForOneHour();
            //}
            //foreach (var auto in pickupTrucks)
            //{
            //    auto.MoveForOneHour();
            //}
        }
    }
}
