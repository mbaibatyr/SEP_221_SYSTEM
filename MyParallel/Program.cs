namespace MyParallel
{
    class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Test123(City city)
        {            
            Console.WriteLine($"{city.Id} {city.Name} {Task.CurrentId}");
            Thread.Sleep(200);            
        }
        static void Test()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i} {Task.CurrentId}");
                Thread.Sleep(200);
            }
        }

        static void Test2()
        {
            Thread.Sleep(5000);
            Console.WriteLine($"LONG TIME");
        }
        static void Test3(int k)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"{k} - {Task.CurrentId}");
        }
        static void Main(string[] args)
        {
            List<City> lst = new List<City>()
            {
                new City { Id = 1, Name="Almaty"},
                new City { Id = 2, Name="Aktobe"},
                new City { Id = 3, Name="Astana"}
            };
            Parallel.ForEach<City>(lst, Test123);


            //Parallel.For(1, 20, Test3);
            //List<int> lst = new List<int>()
            //{
            //    1,10, 0,-5, 50
            //};
            //Parallel.ForEach<int>(lst, Test3);

            //Action[] actions = new Action[3];
            //actions[0] = () => { Test(); };
            //actions[1] = () => { Test(); };
            //actions[2] = () => Test2();
            //Parallel.Invoke(actions);
            //return;

            //Parallel.Invoke(
            //    Test,
            //    Test,
            //    Test,
            //    () =>
            //    {
            //        for (int i = 0; i < 5; i++)
            //        {
            //            Console.WriteLine($"-{i} {Task.CurrentId}");
            //            Thread.Sleep(200);
            //        }
            //    },
            //    () => Console.WriteLine("HELLO STEP"),
            //    Test2
            //);
            Console.WriteLine("FINISH");
        }
    }
}