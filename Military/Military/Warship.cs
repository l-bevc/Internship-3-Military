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
            var totalFuelConsumption = TotalFuelConsumption.CalculationOfTotalFuel(200, 50, ShortestDistance, NumberOfSoldiers);
            return base.Print() + $"Total fuel: {totalFuelConsumption}";
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

