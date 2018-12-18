using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Military
{
    public class Amfibia: Vehicle
    {
        
        public Amfibia(int id, decimal weight, decimal averageSpeed, decimal fuelConsumption, int capacity)
            : base(id, weight, averageSpeed, fuelConsumption=70, capacity=20)
        {
        }

        public static void Input()
        {
            Console.WriteLine("Enter shortest distance for amfibia water part:");
            var shortestDistanceWaterAmfibia = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter shortest distance for amfibia land part:");
            var shortestDistanceLandAmfibia = decimal.Parse(Console.ReadLine());
            ShortestDistance = shortestDistanceLandAmfibia + shortestDistanceWaterAmfibia;
        }

        public override string Print()
        {
            Input();
            var totalFuelConsumption = TotalFuelConsumption.CalculationOfTotalFuel(70, 20, ShortestDistance, NumberOfSoldiers);
            return base.Print() + $"Total fuel: {totalFuelConsumption}";
        }
    }
}
