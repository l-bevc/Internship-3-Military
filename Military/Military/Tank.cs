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
           
        }

        public static void Input()
        {
            Console.WriteLine("Enter shortest distance for tank:");
            ShortestDistance = int.Parse(Console.ReadLine());
            if (ShortestDistanceFromAll<0)
                ShortestDistanceFromAll = ShortestDistance;
            else if (ShortestDistanceFromAll > ShortestDistance)
                ShortestDistanceFromAll = ShortestDistance;

        }

        public override string Print()
        {
            Input();
            Move(ShortestDistance);
            var totalFuelConsumption = TotalFuelConsumption.CalculationOfTotalFuel(30, 6, ShortestDistance, NumberOfSoldiers );
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

        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
