using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public class Tank: Vehicle, IDriveable
    {
        
        public Tank(decimal weight, decimal averageSpeed, decimal fuelConsumption, int capacity)
            : base( weight, averageSpeed, fuelConsumption=30, capacity=6)
        {
            this.Weight = weight;
            this.AverageSpeed = averageSpeed;
        }

        public static void Input()
        {
            Console.WriteLine("Enter shortest distance for tank:");
            ShortestDistance = int.Parse(Console.ReadLine());
            if (ShortestDistanceFromAll < 0)
                ShortestDistanceFromAll = ShortestDistance;
            else if (ShortestDistanceFromAll > ShortestDistance)
                ShortestDistanceFromAll = ShortestDistance;
        }

        public override string Print()
        {
            Input();
            Move(ShortestDistance);
            var totalFuelConsumption = CalculationOfTotalFuel(ShortestDistance, NumberOfSoldiers );
            if (Trip.bestVehicle(totalFuelConsumption))
                Trip.BestVehicle = new Tank(this.Weight, this.AverageSpeed, this.FuelConsumption, this.Capacity);
            return base.Print() + $"Total fuel: {totalFuelConsumption}";
        }

        public void Move(int distance)
        {
            distance = ShortestDistance;
            int possibilitiesOfBarriers = ShortestDistance / 10;
            for (var i = 0; i < possibilitiesOfBarriers; i++)
            {
                if (Trip.RandomNumber(1, 101) <= 30)
                    ShortestDistance += 5;
            }
        }

    }
}
