﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day7
{
    internal class ServiceA
    {
        int x = 0;
        public void DoTaskA()
        {
            Monitor.Enter(this);
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("inside servicesA");
            Console.WriteLine("\t Thread ID : " + id);
            //int x = 0;
            try
            {


                for (int icount = 0; icount < 10; icount++)
                {
                    x += icount;
                    Console.WriteLine("\t ID=" + id + ": x=" + x + " icount=" + icount);
                    Thread.Sleep(1000);//loop will delay for 1s

                }
            }
            finally
            { 
                Monitor.Exit(this); 
            } 
        }

       

        
    }
}
