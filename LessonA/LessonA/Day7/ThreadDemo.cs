using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day7
{
    internal class ThreadDemo
    {
        public static void Democurrent()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("ThreadID="+id);
            Console.WriteLine("IsAlive=" + t1.IsAlive);
            Console.WriteLine("Priority="+ t1.Priority);
            Console.WriteLine("Threadstate="+ t1.ThreadState);
            Console.WriteLine("Currentculture="+t1.CurrentCulture); 
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            t1.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
            Console.WriteLine("curentculture="+t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            t1.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
            Console.WriteLine("currentculture="+ t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongTimeString());

        }
        public static void DemoA()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID" + id);
            ServiceA a1 = new ServiceA();
            a1.DoTaskA();
        }
        public static void DemoB()
        {
            Thread t2 = Thread.CurrentThread;
            int id = t2.ManagedThreadId;
            Console.WriteLine("MainTh ID "+ id);
            ServiceA a1= new ServiceA();
            Thread t1 = new Thread(a1.DoTaskA);
            t1.Start();
            a1.DoTaskA();
            Console.WriteLine("-----------------End Of DemoB-----------------");
        }
        public static void DemoB2()
        {
            Thread t2 = Thread.CurrentThread;
            int id = t2.ManagedThreadId;
            Console.WriteLine("MainTh ID " + id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTaskA);
            Console.WriteLine(t1.ManagedThreadId+" t1 state "+t1.ThreadState);
            t1.Start();
            Console.WriteLine(t1.ManagedThreadId+" state after start"+t1.ThreadState);
            Thread.Sleep(6000);
            Console.WriteLine(t1.ManagedThreadId+" t1 state after sleep"+t1.ThreadState);
            Console.WriteLine("-----------------End Of DemoB2-----------------");
        }
        //public static void DemoC() 
        //{
        //    Thread t3 = Thread.CurrentThread;
        //    int id = t3.ManagedThreadId;
        //    Console.WriteLine("MainTh ID " + id);
        //    ServiceA a1 = new ServiceA();
        //    ThreadStart ts = a1.DoTaskA;
        //    Thread t1 = new Thread(ts);
        //    Thread t3 = new Thread(ts);
        //    t1.Start();
        //    t3.Start();
        //    t1.Join(7000);
        //    if(t1.IsAlive) t1.Abort();
        //    t3.Join(7000);
        //    if (t3.IsAlive) t3.Abort();
            
        //    Console.WriteLine("-----------------End Of Democ-----------------");

        //}

    }
}
