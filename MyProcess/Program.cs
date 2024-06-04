namespace MyProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("кол-во параметров должно быть = 2");
                return;
            }
            var result =  int.Parse(args[0]) + int.Parse(args[1]);
            if(Check(args[0]) == -1000000)
            {

            }
            Console.WriteLine(result);
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
    }
}