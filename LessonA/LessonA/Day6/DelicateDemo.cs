using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day6
{
   
 
        public delegate void MethodHandlerA();
        public delegate   int MethodHandlerB(int x, int y);

        public class MathCalculatror
        {
            public void DoTask()


            {
                Console.WriteLine("Calculator DoTask");
            }
            public int Add(int x, int y)
            {
                Console.WriteLine(x + " " + y);
                return x + y;
            }
            public int multiply(int x, int y)
            {
                Console.WriteLine(x + " " + y);
                return x * y;
            }
            public double divide(double x, double y)
            {
                Console.WriteLine(x + " " + y);
                return x / y;
            }
            public String GetModel()
            {
                return "x500";
            }
        }
        public class DeligateDemoA
        {
            public static void TestOne()
            {
            MathCalculatror mc = new MathCalculatror();
            MethodHandlerA methodHandlerA = mc.DoTask;//new MethodHandlerA(mc.DoTask);
            MethodHandlerB methodHandlerB = mc.Add;//new MethodHandlerB(mc.Add);
            MethodHandlerB methodHandlerTwo = mc.multiply; //new MethodHandlerB(mc.multiply);

                methodHandlerA();
                int addReasult = methodHandlerB(100, 50);
                Console.WriteLine(addReasult);
                int multiplyResult = methodHandlerTwo(20, 5);
                Console.WriteLine(multiplyResult);

            }

        }
    
}
