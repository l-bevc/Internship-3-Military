using System;
using System.Collections;

namespace Military
{
    class Program
    {  
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of soldiers:");
            Vehicle.NumberOfSoldiers = int.Parse(Console.ReadLine());
            var firstTank= new Tank(1,500000,100,5,5);
            Console.WriteLine(firstTank.Print());
            var firstWarship= new Warship(2,500000,150, 1,1);
            Console.WriteLine(firstWarship.Print());
            var firstAmfibia= new Amfibia(3,20000000,200, 10,10);
            Console.WriteLine(firstAmfibia.Print());

            
            Console.ReadKey();
        }
    }
}
