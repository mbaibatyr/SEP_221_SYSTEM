using System.Diagnostics.Metrics;
using System.Reflection;
using System.Timers;

namespace MyTimer
{
    internal class Program
    {
        System.Threading.Timer timer1;

        static void Main(string[] args)
        {
            MyTimer1 myTimer1 = new MyTimer1();
            Console.ReadLine();
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