using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public static class TotalFuelConsumption
    {
        public static decimal CalculationOfTotalFuel(decimal fuelConsumption, int capacity, int distance, int numberOfSoldiers)
        {
            var fuelForOneRoute = fuelConsumption * distance / 100;
            var totalFuel = fuelForOneRoute;
            var timeOfFullVehicle = numberOfSoldiers / capacity;
            if (timeOfFullVehicle > 0)
            {
                totalFuel += fuelForOneRoute*timeOfFullVehicle*2;
            }

            if (numberOfSoldiers % capacity != 0)
                totalFuel += timeOfFullVehicle;

            return totalFuel;
        }
    }
}
