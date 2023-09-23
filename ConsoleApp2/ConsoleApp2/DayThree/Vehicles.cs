using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DayThree
{
    internal abstract class Vehicle
    {
        public Vehicle()
        {
            Console.WriteLine("Vehicle Constructor");
        }
        public void start()
        {
            Console.WriteLine("Vehicle started");
        }
    }
    // End of Class
    internal class Car:Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car Constructor");
        }
    }
    class VehicleTestery
    {
      public static void TestOne()
        {
            Vehicle tester = new Car();
            tester.start();
        }
    }
}
