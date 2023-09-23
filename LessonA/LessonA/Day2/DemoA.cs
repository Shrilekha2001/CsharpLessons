using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//int z=10;should not be decleared here
namespace LessonA.Day2
{
    //int y = 200;should not be decleared before class
    internal class DemoA
    {
        //GLOBAL VARIABLES
        int x = 100;//member variable /class variable should be decleared only here
        static int y = 567;
        public static void Firstmethod()//static method
        {
            int x = 2000;
            int y = 1000;
            Console.WriteLine(x);//non static member can't be accessed
            Console.WriteLine(y);//local variable
            Console.WriteLine(DemoA.y);//global static var
        }

        public  void Secondmethod()//non static method
        {
            //local var
            int y = 5000;
            Console.WriteLine(x);//nonstatic member can be accesses
            Console.WriteLine(y);//local variable
            Console.WriteLine(DemoA.y);//global var


        }

    }
}
namespace LessonA.Gavs
{
    internal class DemoA
    {

    }
}