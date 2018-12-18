using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Military
{
    public class Warship: Vehicle
    {
        
        public Warship(int id, decimal weight, decimal averageSpeed, decimal fuelConsumption, int capacity)
            : base(id, weight, averageSpeed, fuelConsumption=200, capacity=50)
        {
        }

        public static void Input()
        {
            Console.WriteLine("Enter shortest distance for warship:");
            ShortestDistance = decimal.Parse(Console.ReadLine());
        }

        public override string Print()
        {
            Input();
            var totalFuelConsumption = TotalFuelConsumption.CalculationOfTotalFuel(200, 50, ShortestDistance, NumberOfSoldiers);
            return base.Print() + $"Total fuel: {totalFuelConsumption}";
        }
    }
}

