using System;
using System.Reflection;


namespace MyReflexia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assembly assembly = Assembly.LoadFrom(@"C:\Temp\MyDLL3.dll");
            Assembly assembly = Assembly.LoadFrom(@"C:\Users\байбатыровм\source\repos\SEP_221_SYSTEM\MyDLL3\bin\Debug\net6.0\MyDLL3.dll");
            foreach (var item in assembly.GetTypes())
            {
                foreach (var item2 in item.GetMethods())
                {
                    Console.WriteLine(item2.Name);
                }
                object link = Activator.CreateInstance(item);
                var method = item.GetMethod("SayHello");
                object result = method.Invoke(link, new object[] { "STEP123" });
                Console.WriteLine(result.ToString());
            }


            //foreach (var item in assembly.GetTypes())
            //{
            //    Console.WriteLine(item.FullName);
            //}

            //Type t = typeof(City);
            //foreach (var item in t.GetMembers())
            //{
            //    Console.WriteLine(item.Name + " " + item.MemberType + " " + item.DeclaringType);
            //}


            //foreach (var item in t.GetMethods())
            //{
            //    foreach (var param in item.GetParameters())
            //    {
            //        Console.WriteLine(item.Name + " " + param.Name + " " + param.ParameterType);
            //    }
            //}
        }
    }

    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public City(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public string Concat(int id, string name)
        {
            return id.ToString() + " - " + name;
        }

        public static void Test(List<City> lst)
        {

        }

    }
}