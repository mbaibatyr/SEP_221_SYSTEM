﻿using System.Diagnostics;

namespace Call
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Process.Start("C:\\Users\\байбатыровм\\source\\repos\\SEP_221_SYSTEM\\MyProcess\\bin\\Debug\\net6.0\\MyProcess.exe");

            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "C:\\Users\\байбатыровм\\source\\repos\\SEP_221_SYSTEM\\MyProcess\\bin\\Debug\\net6.0\\MyProcess.exe";
            info.Arguments = "50 120";
            info.WindowStyle = ProcessWindowStyle.Normal;
            info.UseShellExecute = false;
            info.CreateNoWindow = true;
            info.RedirectStandardOutput = true;
            var p = Process.Start(info);
            while (!p.StandardOutput.EndOfStream)
            {
                string line = p.StandardOutput.ReadLine();
                Console.WriteLine($"Результат {line}");
            }
            p.WaitForExit();

        }
    }
}