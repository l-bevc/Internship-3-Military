using System;
using System.Collections.Generic;
using System.Text;
using Military.Enums;

namespace Military
{
    public class Tank: Vehicle, IDriveable
    {
        
        public Tank(decimal weight, decimal averageSpeed)
            : base( weight, averageSpeed)
        {
            this.Weight = weight;
            this.AverageSpeed = averageSpeed;
            this.Capacity = (int) CapacityEnum.Tank;
            this.FuelConsumption = (int) FuelEnum.Tank;

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
                Trip.BestVehicle = new Tank(this.Weight, this.AverageSpeed);
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
