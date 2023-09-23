using LessonA.Day4;
using LessonA.Day6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day6
{
    class Employee
    {
        public int ID;
        public string Name;



        internal class WorkingWithObject
        {
            public static void TestOne()
            {
                Object objectOne = new object();
                Console.WriteLine($"ToString: {objectOne.ToString()}");
                Console.WriteLine($"HashCode: {objectOne.GetHashCode()}");
                Type typeOne = objectOne.GetType();
                Console.WriteLine($"Type: {typeOne.FullName}");



                String stringData = "WorldCup 2023";
                Console.WriteLine($"ToString: {stringData.ToString()}");
                Console.WriteLine($"HashCode: {stringData.GetHashCode()}");
                Type typeTwo = stringData.GetType();
                Console.WriteLine($"Type: {typeTwo.FullName}");
            }
            public static void TestTwo()
            {
                Employee empone = new Employee();
                empone.ID = 1001; empone.Name = "shri";
                Employee emptwo = empone; //new Employee();
                emptwo.ID = 1002; emptwo.Name = "shri";
                Employee empthree = empone; // new Employee();
                empthree.ID = 103; empthree.Name = "shri";
                bool flag = (empone.Equals(emptwo));
                Console.WriteLine(flag);
                flag = empone.Equals(empthree);
                Console.WriteLine(flag);
                Console.WriteLine(empone.GetHashCode());
                Console.WriteLine(emptwo.GetHashCode());
                Console.WriteLine(empthree.GetHashCode());


            }
        }
    }
}
