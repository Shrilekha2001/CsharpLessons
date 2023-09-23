using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day3
{
    internal class Stringlesson
    {
        int y;
        public static void DemoA()
        {
            String firststring = "Hello";
            char[] data = { 'H', 'e', 'l', 'l', 'o' };
            String secondstring = new String(data);
            Console.WriteLine(firststring + " " + secondstring);
            String thirdstring = String.Empty;
            int x = 0;
        }
        public static void DemoB()
        {
            String s1 = "Tom and Jerry are good friends";
            Console.WriteLine("Length" + s1.Length);
            char[] data = s1.ToCharArray();
            foreach (char c1 in data)
            {
                Console.WriteLine(c1);
            }
        }
        public static void Democ()
        {
            String s1 = "Tom nd Jerry are good friends";
            String[] word = s1.Split(' ');
            Console.WriteLine("word count" + word.Count());
            foreach (var item in word)
            {
                Console.WriteLine(item);
            }
        }
        public static void DemoD()
        {
            String firststring = "Tom and Jerry are good friends";
            String stringInUPPER = firststring.ToUpper();
            Console.WriteLine("firststring: " + firststring);
            Console.WriteLine("stringInUPPER: " + stringInUPPER);
            String stringInLOWER = firststring.ToLower();
            Console.WriteLine("firststring: " + firststring);
            Console.WriteLine("stringInLOWER: " + stringInLOWER);
        }
        public static void DemoE()
        {


            String secondString = "    abcdef    ";
            String trimmedString = secondString.Trim();
            Console.WriteLine(secondString);
            Console.WriteLine("secondString Length: " + secondString.Length);
            Console.WriteLine(trimmedString);
            Console.WriteLine("trimmedString Length: " + trimmedString.Length);
            String trimmedAtEnd = secondString.TrimEnd();
            Console.WriteLine(trimmedAtEnd);
            Console.WriteLine("trimmedAtEnd Length: " + trimmedAtEnd.Length);
            String trimmedAtStart = secondString.TrimStart();
            Console.WriteLine(trimmedAtStart);
            Console.WriteLine("trimmedAtStart Length: " + trimmedAtStart.Length);
        }
        public static void TestStringEquals()
        {
            String firstString = "Hello";
            String secondString = "Hello";
            String thirdString = "Gavs";



            bool firstResult = (firstString == secondString);
            bool secondResult = (firstString == thirdString);
            Console.WriteLine("firstString==secondString " + firstResult); // true
            Console.WriteLine("firstString==thirdString " + secondResult);// true



            firstResult = (firstString.Equals(secondString));
            secondResult = (firstString.Equals(thirdString));
            Console.WriteLine("firstString.Equals(secondString) " + firstResult); // true
            Console.WriteLine("firstString.Equals(thirdString) " + secondResult);

        }
        public static void TestSubstring()
        {
            String s1 = "It looks like September is going to have more rain";
            Console.WriteLine(s1);
            Console.WriteLine("Length " + s1.Length);
            String s2 = s1.Substring(5);
            Console.WriteLine(s2);
            Console.WriteLine("s2 Length " + s2.Length);
            String s3 = s1.Substring(5, 10);
            Console.WriteLine(s3);
            Console.WriteLine("s3 Length " + s3.Length);
        }

    }

}


    

