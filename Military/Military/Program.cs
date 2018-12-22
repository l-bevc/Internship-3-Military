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
            Console.WriteLine("Enter average speed for tank:");
            var speedTank = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter weight of tank:");
            var weightTank = decimal.Parse(Console.ReadLine());
            var firstTank= new Tank(weightTank,speedTank);
            Console.WriteLine(firstTank.Print());
            Console.WriteLine("Enter average speed for warship:");
            var speedWarship = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter weight of warship:");
            var weightWarship = decimal.Parse(Console.ReadLine());
            var firstWarship= new Warship(weightWarship,speedWarship);
            Console.WriteLine(firstWarship.Print());
            Console.WriteLine("Enter average speed amfibia:");
            var speedAmfibia = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter weight of amfibia:");
            var weightAmfibia = decimal.Parse(Console.ReadLine());
            var firstAmfibia= new Amfibia(weightAmfibia,speedAmfibia);
            Console.WriteLine(firstAmfibia.Print());
            Console.WriteLine("Best vehicle is: ");
            Console.WriteLine(Trip.BestVehicle.PrintBestVehicle());


            Console.ReadKey();
        }
    }
}
