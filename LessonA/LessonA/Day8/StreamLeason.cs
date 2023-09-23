using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LessonA.Day8
{
    internal class StreamLeason
    {
        public static void Testone()
        {
            char ch;
            Console.WriteLine("Press a key followed by ENTER:");
            int x=Console.Read();
            ch=(char)x;
            Console.WriteLine("\n" +x+"Your Key is : "+ch);
        }
        public static void Testtwo()
        {
            char ch= ' ';
            Console.WriteLine("Press a Key q to Exit:");
            while(ch !='q')
            {
                ch=(char)Console.Read();
                Console.WriteLine("Your Key is :"+ch);

            }
        }
        public static void Testthree() 
        {
            Console.Out.WriteLine("Enter a Sentences");
            string? str=Console.ReadLine();
            Console.Out.WriteLine(str);

        }
        public static void TestNullableTable()
        {
            int? x = 0;
            x = null;
           
            if(x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
                Console.WriteLine(x.GetValueOrDefault());


        }

    }
}
