using System.Diagnostics.Metrics;
using System.Reflection;
using System.Threading;
using System.Timers;

namespace MyTimer
{
    internal class Program
    {
        static System.Threading.Timer timer1;

        static void Main(string[] args)
        {
            timer1 = new System.Threading.Timer(ShowConsole, null, 0, 1000);
            Thread.Sleep(2000);
            timer1.Change(1000, 0);
            Thread.Sleep(2000);
            timer1.Change(1000, 100);
            Thread.Sleep(2000);
            timer1.Change(1000, 1000);
            //MyTimer1 myTimer1 = new MyTimer1();
            Console.ReadLine();
        }
        static void ShowConsole(object sender)
        {
            Console.WriteLine("Hello step");
        }
    }

    class MyTimer1
    {
        System.Timers.Timer timer;
        System.Timers.Timer timer2;
        public MyTimer1()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 500;
            timer.Elapsed += ShowConsole;
            //timer.Start();

            timer2 = new System.Timers.Timer();
            timer2.Interval = 3000;
            timer2.Elapsed += SWitchConsole;
            timer2.Start();
        }

        public void ShowConsole(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Hello step");
        }

        public void SWitchConsole(object sender, ElapsedEventArgs e)
        {
            timer.Enabled = !timer.Enabled;
        }
    }
}