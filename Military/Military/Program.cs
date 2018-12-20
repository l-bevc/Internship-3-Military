using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Military
{
    class Program
    {  
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of soldiers:");
            Vehicle.NumberOfSoldiers = int.Parse(Console.ReadLine());
            var firstTank= new Tank(500000,100,5,5);
            Console.WriteLine(firstTank.Print());
            var secondTank = new Tank(500, 100000, 5, 5);
            Console.WriteLine(secondTank.Print());
            var firstWarship= new Warship(500000,150, 1,1);
            Console.WriteLine(firstWarship.Print());
            var secondWarship = new Warship(500000, 1500, 1, 1);
            Console.WriteLine(secondWarship.Print());
            var firstAmfibia= new Amfibia(20000000,10000, 10,10);
            Console.WriteLine(firstAmfibia.Print());
            Console.WriteLine("Best vehicle is: ");
            Console.WriteLine(Vehicle.BestVehicle.PrintBestVehicle());


            Console.ReadKey();
        }
    }
}
