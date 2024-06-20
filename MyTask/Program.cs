namespace MyTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string st = "123131313123";
            st = st
                .Replace("1", "2")
                .Replace("3", "4")
                .Replace("12", "")
                .Replace("12", "")
                .Replace("12", "");

            string[] list = new string[] { "1", "2", "3", "3" };
            list = list.Distinct().ToArray();
            

            //using (Sqlconnection db = new Sqlconnection(""))
            //{
            //    //var st = db.ExecuteScalar<string>("select getdate()");
            //    db.Execute("pInsert", new { word = word}, storedprocedure);
            //}

            var content = File.ReadAllText("путь к файлу");
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