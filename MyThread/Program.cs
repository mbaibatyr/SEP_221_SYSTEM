using System.Threading;

namespace MyThread
{
    internal class Program
    {
        static object MyLock = new();
        static void Main(string[] args)
        {
            //DateTime dt1 = DateTime.Now;
            //DateTime dt2 = DateTime.Now.AddMinutes(2);
            //Console.WriteLine((dt2 - dt1).TotalSeconds);

            //Thread thread = Thread.CurrentThread;
            //thread.Priority = ThreadPriority.Highest;
            //Console.WriteLine($"{thread.Priority}");

            for (int i = 1; i <= 5; i++)
            {
                Thread MyThread = new Thread(Test);
                //Thread MyThread = new Thread(new ParameterizedThreadStart(Test2));
                MyThread.Name = "Поток " + i.ToString();
                //MyThread.Start(i);
                MyThread.Start();
            }

            //Console.ReadLine();
        }

        static void Test()
        {
            lock (MyLock)
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread thread = Thread.CurrentThread;
                    Console.WriteLine($"{thread.Name} - {i}");
                    Thread.Sleep(200);
                }
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