﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day8
{
    internal class TaskLessons
    {
        public static void TestOne()
        {
            int id = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"CurrentThreadID:{id}");
            TaskFactory tf = new TaskFactory();
            Task t1 = tf.StartNew(ClassA.TaskMethodA);         



            Task t2 = Task.Factory.StartNew(ClassA.TaskMethodA);



            Task t3 = new Task(ClassA.TaskMethodA);
            t3.Start();
            Task t4 = new Task(ClassA.TaskMethodA);
            t4.Start();
        }
        public static void ContinueTask()
        {
            Task t1 = new Task(ClassA.TaskMethodA);
            Task t2 = t1.ContinueWith(ClassA.TaskMethodB);
            Task t3 = t1.ContinueWith(ClassA.TaskMethodC);
            Task t4 = t2.ContinueWith(ClassA.TaskMethodB1);



            t1.Start();
            Console.WriteLine("Bye from ContinueTask");
            Task.WaitAll(t1, t2, t3, t4);
        }
    }
}
