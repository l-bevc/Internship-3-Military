using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public decimal Weight { get; set; }
        public decimal AverageSpeed { get; set; }
        public decimal FuelConsumption { get; set; }
        public int Capacity { get; set; }
        public static int NumberOfSoldiers { get; set; }
        public static decimal ShortestDistance { get; set; }

        public Vehicle(int id, decimal weight, decimal averageSpeed, decimal fuelConsumption, int capacity)
        {
            this.Id = id;
            this.Weight = weight;
            this.AverageSpeed = averageSpeed;
            this.FuelConsumption = fuelConsumption;
            this.Capacity = capacity;
        }

        public virtual string Print()
        {
            return $"Id: {Id}; Weight: {Weight}; Average Speed: {AverageSpeed}; Fuel consumption: {FuelConsumption} Capacity: {Capacity} ";
        }



    }
}
