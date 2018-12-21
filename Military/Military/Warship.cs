using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Military
{
    public class Warship: Vehicle, ISwimmable
    {
        
        public Warship( decimal weight, decimal averageSpeed, decimal fuelConsumption, int capacity)
            : base(weight, averageSpeed, fuelConsumption=200, capacity=50)
        {
        }

        public static void Input()
        {
            Console.WriteLine("Enter shortest distance for warship:");
            ShortestDistance = int.Parse(Console.ReadLine());
            if (ShortestDistanceFromAll < 0)
                ShortestDistanceFromAll = ShortestDistance;
            else if (ShortestDistanceFromAll > ShortestDistance)
                ShortestDistanceFromAll = ShortestDistance;
        }

        public override string Print()
        {
            Input();
            Swim(ShortestDistance);
            var totalFuelConsumption = CalculationOfTotalFuel(ShortestDistance, NumberOfSoldiers);
            if (Trip.bestVehicle(totalFuelConsumption))
                Trip.BestVehicle = new Warship(this.Weight, this.AverageSpeed, this.FuelConsumption, this.Capacity);
            return base.Print() + $"Total fuel: {totalFuelConsumption}";
        }

        public void Swim(int distance)
        {
            distance = ShortestDistance;
            var time = distance / AverageSpeed * 60;
            var periods = time / 10;
            for (var i = 0; i < periods; i++)
            {
                if (Trip.RandomNumber(1, 101) <= 50)
                    ShortestDistance += 3;
            }
        }

    }
}

