using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LessonA.Day5
{
    internal class Task1
    {
        public static void DoTask(int x)//1000=x;
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }
        public static void DoTaskA(ref int x)
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }
        
        


    }
}
