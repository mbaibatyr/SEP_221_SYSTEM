using System.Diagnostics;
using System.Xml.Linq;

namespace MyProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartProcess(@"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE");
            //List<Process> lst = new List<Process>();
            //lst.Add(StartProcess("calc"));
            //lst.Add(StartProcess("calc"));
            //lst.Add(StartProcess("calc"));
            //foreach (Process p in lst) 
            //{ 
            //    p.Kill();
            //}

            //KillProcessesByName("CalculatorApp");

            //GetAllProcesses();

            //if (args.Length != 2)
            //{
            //    Console.WriteLine("кол-во параметров должно быть = 2");
            //    return;
            //}
            //var result =  int.Parse(args[0]) + int.Parse(args[1]);
            //if(Check(args[0]) == -1000000)
            //{

            //}
            //Console.WriteLine(result);
            //Console.ReadLine();
        }
        static int Check(string st)
        {
            try
            {
                return int.Parse(st);
            }
            catch (Exception)
            {
                return -1000000;
            }
        }

        static void GetAllProcesses()
        {
            foreach (var item in Process.GetProcesses().Where(z => z.ProcessName == "chrome"))
            {
                //if (item.ProcessName == "chrome")
                //Console.WriteLine($"{item.Id}  {item.ProcessName}  {item.BasePriority}");
                //item.Kill();
            }
        }

        static void KillProcessesByName(string Name)
        {
            foreach (var item in Process.GetProcessesByName(Name))
            {
                item.Kill();
            }
        }

        static Process StartProcess(string Name)
        {
            var p = Process.Start(Name);            
            return p as Process;
        }
    }
}