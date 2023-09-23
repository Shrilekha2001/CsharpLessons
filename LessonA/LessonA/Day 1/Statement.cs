using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day_1
{
    internal class Statement
    {
        public static void TestOne() 
        {
            Console.WriteLine("ENTER YOUR AGE");
            String ageAsString=Console.ReadLine();

            int age = int.Parse(ageAsString);
            if (age < 18 )
            {
                Console.WriteLine("SORRY!!! YOU CANT DRIVE");
            }
            else {
                Console.WriteLine("YES, YOU CAN DRIVE");
                    }
        }
    }


}
