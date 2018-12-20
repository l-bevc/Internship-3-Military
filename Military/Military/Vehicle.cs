using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public abstract class Vehicle
    {
        public static int Id = 0;
        public decimal Weight { get; set; }
        public decimal AverageSpeed { get; set; }
        public decimal FuelConsumption { get; set; }
        public int Capacity { get; set; }
        public static int NumberOfSoldiers { get; set; }
        public static int ShortestDistance { get; set; }
        public static int ShortestDistanceFromAll = -5;
        public static Vehicle BestVehicle { get; set; }
        public decimal minimalConsumption = 0;

        public Vehicle( decimal weight, decimal averageSpeed, decimal fuelConsumption, int capacity)
        {
            Id++;
            this.Weight = weight;
            this.AverageSpeed = averageSpeed;
            this.FuelConsumption = fuelConsumption;
            this.Capacity = capacity;
        }

        public virtual string Print()
        {
            return $"Id: {Id}; Weight: {Weight}; Average Speed: {AverageSpeed}; Fuel consumption: {FuelConsumption}; Capacity: {Capacity}; ";
        }

        public string PrintBestVehicle()
        {
            return $"Id: {Id}; Weight: {Weight}; Average Speed: {AverageSpeed}; Fuel consumption: {FuelConsumption}; Capacity: {Capacity}; ";
        }



    }
}
