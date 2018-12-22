using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Military.Enums;

namespace Military
{
    public class Amfibia: Vehicle, IDriveable, ISwimmable
    {

        public Amfibia(decimal weight, decimal averageSpeed)
            : base( weight, averageSpeed)
        {
            this.Weight = weight;
            this.AverageSpeed = averageSpeed;
            this.Capacity = (int) CapacityEnum.Amfibia;
            this.FuelConsumption = (int) FuelEnum.Amfibia;
        }
       
        public static void Input()
        {
            Trip.distanceGround = ShortestDistanceFromAll;
            Trip.distanceWater = ShortestDistanceFromAll;
            if (ShortestDistanceFromAll >= 0)
            {
                while ((Trip.distanceWater + Trip.distanceGround) > ShortestDistanceFromAll)
                {
                    Console.WriteLine("Enter shortest distance for amfibia water part:");
                    Trip.distanceWater = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter shortest distance for amfibia land part:");
                    Trip.distanceGround = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Enter shortest distance for amfibia water part:");
                Trip.distanceWater = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter shortest distance for amfibia land part:");
                Trip.distanceGround = int.Parse(Console.ReadLine());
            }
            ShortestDistance = Trip.distanceGround+Trip.distanceWater;
        }

        public override string Print()
        {
            Input();
            Move(Trip.distanceGround);
            Swim(Trip.distanceWater);
            var totalFuelConsumption = CalculationOfTotalFuel(ShortestDistance, NumberOfSoldiers);
            if (Trip.bestVehicle(totalFuelConsumption)) 
                Trip.BestVehicle= new Amfibia(this.Weight, this.AverageSpeed);
            return base.Print() + $"Total fuel: {totalFuelConsumption}";
        }

        public void Move(int distance)
        {
            int possibilitiesOfBarriers = ShortestDistance / 10;
            for (var i = 0; i < possibilitiesOfBarriers; i++)
            {
                if (Trip.RandomNumber(1, 101) <= 30)
                    ShortestDistance += 5;
            }
        }
        public void Swim(int distance)
        {
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
