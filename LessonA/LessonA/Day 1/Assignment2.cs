using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day_1
{
    internal class Assignment2
    {
        public static void Fruit()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Apple" + i);
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Orange" + i);
                }
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("Grapes" + i);
                }
            }
        }
    }
}
