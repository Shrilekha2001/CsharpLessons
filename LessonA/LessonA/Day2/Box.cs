using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day2
{
    internal class Box
    {
        public static int height;
        public  int width;
        public const string Type = "wooden";
        public int GetHeight() { return height; }
    }
    internal class Testbox
    {
        public static void Testone()
        {
            Box.height = 100;
            //Box.width = 200;
            Box firstbox = new Box();
            Box secondbox = new Box();
            firstbox.width = 12345;
            secondbox.width = 98765;
            Console.WriteLine(Box.Type);

            Console.WriteLine($"firstbox = {firstbox.width},{firstbox.GetHeight()}");
            Console.WriteLine($"secondbox = {secondbox.width},{secondbox.GetHeight()}");
            //Box.type="Glass';
            Box.height = 5555;
            Console.WriteLine($"firstbox = {firstbox.width},{firstbox.GetHeight()}");
            Console.WriteLine($"secondbox = {secondbox.width},{secondbox.GetHeight()}");

        }
    }
}
