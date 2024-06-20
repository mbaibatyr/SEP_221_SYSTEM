namespace MyTask2
{
    internal class Program
    {
        static void Test()
        {
            Console.WriteLine("STEP 5");
        }
        static async Task Test2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("STEP 6");
            });
        }

        static async Task Test3Async()
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.ExecuteNonQuery();
            await cmd.ExecuteNonQueryAsync();
        }
        static async Task Main(string[] args)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.ExecuteNonQuery();
            await cmd.ExecuteNonQueryAsync();

            cmd.ExecuteNonQueryAsync();

            Test2();
            Task.Run(() =>
            {
                Console.WriteLine("STEP 1");
                Console.WriteLine("STEP 2");
                Console.WriteLine("STEP 3");
            });

            Task task = new Task(() => Console.WriteLine("STEP 4"));
            Task task2 = new Task(Test);
            task.Start();
            task2.Start();
            Console.ReadLine();
        }
    }
}