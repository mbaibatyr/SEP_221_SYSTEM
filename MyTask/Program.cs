namespace MyTask
{
    internal class Program
    {
        static void Test123(object arr)
        {
            if (arr is string[])
            {

                string[] strings = (string[])arr;
                foreach (string s in strings)
                {
                    Console.WriteLine(s);
                }
            }
        }



        static void Main(string[] args)
        {

            Console.WriteLine("STEP 1");
            Console.WriteLine("STEP 2");
            Console.WriteLine("STEP 3");


            //string st = "qwe;fgh!fgh#sdf#####";
            //var aaa = st.Split(new string[] { ";", "!", "#" }, StringSplitOptions.RemoveEmptyEntries);

            //string[] arr = { "1", "2", "3" };
            //Test123(arr);
            //return;
            //string[] list = new string[] { "1", "2", "3", "3" };
            //list = list.Distinct().ToArray();


            //using (Sqlconnection db = new Sqlconnection(""))
            //{
            //    //var st = db.ExecuteScalar<string>("select getdate()");
            //    db.Execute("pInsert", new { word = word}, storedprocedure);
            //}

            //var content = File.ReadAllText("путь к файлу");
            //for (int i = 0; i < 5; i++) 
            //{
            //    //Test();
            //    //Task.Run(() =>
            //    //{
            //    //    //Test();
            //    //    for (int i = 1; i <= 10; i++)
            //    //    {
            //    //        Console.WriteLine(i);
            //    //        Thread.Sleep(200);
            //    //    }
            //    //});
            //    var task = new Task(Test);
            //    task.Start();
            //}

            Task[] tasks = new Task[5];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = new Task(Test);
                tasks[i].Start();
            }
            Task.WaitAll(tasks);
            //Console.ReadLine();
        }

        static void Test()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }
    }
}