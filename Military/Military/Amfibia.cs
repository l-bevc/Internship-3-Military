using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Military
{
    public class Amfibia: Vehicle, IDriveable, ISwimmable
    {

        public Amfibia(decimal weight, decimal averageSpeed, decimal fuelConsumption, int capacity)
            : base( weight, averageSpeed, fuelConsumption=70, capacity=20)
        {
        }
       
        public static void Input()
        {
            var shortestDistanceWaterAmfibia = ShortestDistanceFromAll;
            var shortestDistanceLandAmfibia = ShortestDistanceFromAll;
            if (ShortestDistanceFromAll >= 0)
            {
                while ((shortestDistanceLandAmfibia + shortestDistanceWaterAmfibia) > ShortestDistanceFromAll)
                {
                    Console.WriteLine("Enter shortest distance for amfibia water part:");
                    shortestDistanceWaterAmfibia = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter shortest distance for amfibia land part:");
                    shortestDistanceLandAmfibia = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Enter shortest distance for amfibia water part:");
                shortestDistanceWaterAmfibia = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter shortest distance for amfibia land part:");
                shortestDistanceLandAmfibia = int.Parse(Console.ReadLine());
            }
            ShortestDistance = shortestDistanceLandAmfibia + shortestDistanceWaterAmfibia;
        }

        public override string Print()
        {
            Input();
            Move(ShortestDistance);
            Swim(ShortestDistance);
            var totalFuelConsumption = TotalFuelConsumption.CalculationOfTotalFuel(70, 20, ShortestDistance, NumberOfSoldiers);
            if (minimalConsumption == 0)
            {
                minimalConsumption = totalFuelConsumption;
                BestVehicle = new Amfibia(this.Weight, this.AverageSpeed, this.FuelConsumption, this.Capacity);
            }
            else
            {
                if (minimalConsumption > totalFuelConsumption)
                {
                    minimalConsumption = totalFuelConsumption;
                    BestVehicle = new Amfibia(this.Weight, this.AverageSpeed, this.FuelConsumption, this.Capacity);
                }
            }
            return base.Print() + $"Total fuel: {totalFuelConsumption}";
        }

        public void Move(int distance)
        {
            distance = ShortestDistance;
            int possibilitiesOfBarriers = ShortestDistance / 10;
            for (var i = 0; i < possibilitiesOfBarriers; i++)
            {
                if (RandomNumber(1, 101) <= 30)
                    ShortestDistance += 5;
            }
        }
        public void Swim(int distance)
        {
            distance = ShortestDistance;
            var time = distance / AverageSpeed * 60;
            var periods = time / 10;
            for (var i = 0; i < periods; i++)
            {
                if (RandomNumber(1, 101) <= 50)
                    ShortestDistance += 3;
            }
        }

        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
