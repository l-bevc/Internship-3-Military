using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Military
{
    class Program
    {  
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();
            Console.WriteLine("Enter number of soldiers:");
            Vehicle.NumberOfSoldiers = int.Parse(Console.ReadLine());
            var firstTank= new Tank(500000,100,5,5);
            Console.WriteLine(firstTank.Print());
            var firstWarship= new Warship(500000,150, 1,1);
            Console.WriteLine(firstWarship.Print());
            var firstAmfibia= new Amfibia(20000000,200, 10,10);
            Console.WriteLine(firstAmfibia.Print());
            vehicles.Add(firstTank);
            vehicles.Add(firstWarship);
            vehicles.Add(firstAmfibia);

            Console.ReadKey();
        }
    }
}
