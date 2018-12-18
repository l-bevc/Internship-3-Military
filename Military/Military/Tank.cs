using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public class Tank: Vehicle
    {
        
        public Tank(int id, decimal weight, decimal averageSpeed, decimal fuelConsumption, int capacity)
            : base(id, weight, averageSpeed, fuelConsumption=30, capacity=6)
        {  
        }

        public static void Input()
        {
            Console.WriteLine("Enter shortest distance for tank:");
            ShortestDistance = decimal.Parse(Console.ReadLine());
        }

        public override string Print()
        {
            Input();
            var totalFuelConsumption = TotalFuelConsumption.CalculationOfTotalFuel(30, 6, ShortestDistance, NumberOfSoldiers );
            return base.Print() + $"Total fuel: {totalFuelConsumption}";
        }
    }
}
