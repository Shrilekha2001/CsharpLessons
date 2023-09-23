using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day3
{
    internal class Bubblesort
    {
        public static void BB()
        {
            String[] array = { "xavier", "basker", "akash ", "Anand" };
            Array.Sort(array);
            foreach(string s1 in array)
            {
                Console.WriteLine(s1);
            }
        } 
    }
}
