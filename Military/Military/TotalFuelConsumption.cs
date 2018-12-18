using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public static class TotalFuelConsumption
    {
        public static decimal CalculationOfTotalFuel(decimal fuelConsumption, int capacity, decimal distance, int numberOfSoldiers)
        {
            var fuelForOneRoute = distance / 100 * fuelConsumption * 2;
            int timeOfFullVehicle = numberOfSoldiers / capacity;
            if (numberOfSoldiers % capacity != 0)
                timeOfFullVehicle++;
            return (timeOfFullVehicle * fuelForOneRoute);
        }
    }
}
