using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day_1
{
    internal class ValueTypeLesson
    {
        public static void TestValueType()
        {
            char c1 = 'A';
            Console.WriteLine(c1);
            int x = c1;
            Console.WriteLine(x);
            int y = 68;
            char c2 = (char)y;
            Console.WriteLine(c2);
            bool z = false;
            Console.WriteLine(z);
        }
         static void TestMethod() 
        {
            Console.WriteLine("Test");
        }
    }
}
