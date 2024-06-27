using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyReflexia2
{
    internal class Program
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, int options);
        static void Main(string[] args)
        {

            //StringBuilder sTitleBar = new StringBuilder(255);
            //MessageBox(IntPtr.Zero, "Hello!", sTitleBar.ToString(), 0);

            Assembly assembly = null;

            assembly = Assembly.LoadFrom(@"C:\Users\байбатыровм\source\repos\SEP_221_SYSTEM\MyDLL4\bin\Debug\MyDLL4.dll");
            foreach (var item in assembly.GetTypes())
            {
                foreach (var item2 in item.GetMethods())
                {
                    //    //    foreach (var item3 in item2.GetParameters())
                    //    //    {
                    //    //        Console.WriteLine(item2.Name + " " + item3.Name + " " + item3.ParameterType);
                    //    //    }
                }
                //    object link = Activator.CreateInstance(item);
                //    var method = item.GetMethod("Sum");
                //    object result = method.Invoke(link, new object[] { 10, 30 });
                //    Console.WriteLine(result.ToString());
            }
        }
    }
}
