using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day3
{
    internal class Vehicle
    {
        public Vehicle() 
        {
            Console.WriteLine("Vehicle constructor");
        }
        public void Start()
        {
            Console.WriteLine("Vehicle start");
        }
    }
    //End of class
    internal class car: Vehicle 
    {
        public car()
        {
            Console.WriteLine("car constructor");
        }
    }
    class VehicleTester
    {
        public static void Testone()
        { 
        //Vehicle tester = new Vehicle();
        Vehicle tester = new car();
            tester.Start();
        }
    }
}
