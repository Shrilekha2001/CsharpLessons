using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day3
{
    internal class BOX
    {
        
            public int Height;
            public int Length;
            public int Width;



            public BOX(int x)
            {
                Console.WriteLine("Box Object Created");
            }
            public void Open()
            {
                Console.WriteLine("Box is Open");
            }
            public void Close()
            {
                Console.WriteLine("Box is Closed");
            }
        public override string ToString()
        {
            return $"Height:{Height}, Length:{Length}, Width:{Width}";  
        }
    }
    internal class WoodenBox : BOX
    {
        public int x;
        public WoodenBox():base(1)
        {
            Console.WriteLine(" Wooden Box Constructor ");
        }
        public WoodenBox(int x):base(x)
        {
            Console.WriteLine("Wooden Box constructor ");
        }
        public WoodenBox(int x,int y):base(x)
        {
            Console.WriteLine("Wooden Box Constructor");
        }
        public override string ToString()
        {
            return "Tom and Jerry";
        }
        public void Move()
        { Console.WriteLine("Wooden Box Shifted");
        }
    }

    internal class BoxTester
    {
        public static void TestOne()
        {
            BOX box = new BOX(100);
            box.Height = 10;
            box.Width = 5;
            box.Length = 20;
            box.Open();
            box.Close();
            box.ToString();
            String output = box.ToString();
            Console.WriteLine(output);

        }
       


        public static void Testtwo()
        {
            WoodenBox box = new WoodenBox();
            box.Height = 100;
            box.Length = 100;
            box.Width = 200;
            box.Open();
            box.Close();
            box.x = 100;
            box.Move();
            String output = box.ToString();
            Console.WriteLine(output);
        }
        public static void Testthree()
        {
            BOX box = new WoodenBox(100);
            box.Height = 100;
            box.Width = 50;
            box.Length = 200;
            box.Open();
            box.Close();
            String output = box.ToString();
            Console.WriteLine(output);
        }
    }

    
}

