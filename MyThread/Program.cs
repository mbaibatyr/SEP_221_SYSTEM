﻿using System.Threading;

namespace MyThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread thread = Thread.CurrentThread;
            //thread.Priority = ThreadPriority.Highest;
            //Console.WriteLine($"{thread.Priority}");
            
            for (int i = 1; i <= 5; i++)
            {
                //Thread MyThread = new Thread(Test);
                Thread MyThread = new Thread (new ParameterizedThreadStart(Test2));
                MyThread.Name = "Поток " + i.ToString();
                MyThread.Start(i);
            }

            Console.ReadLine();
        }

        static void Test()
        {
            for (int i = 0; i < 10; i++) 
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine($"{thread.Name} - {i}");
                Thread.Sleep(200);
            }
        }

        static void Test2(object k)
        {
            int p = int.Parse(k.ToString());
            for (int i = 0; i < p; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine($"{thread.Name} - {i}");
                Thread.Sleep(200);
            }
        }
    }
}