namespace MyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Thread.Sleep(1000);
            //    listBox1.Items.Add(i.ToString());
            //}
            Thread MyThread = new Thread(Test);
            MyThread.Name = "Поток 123";
            MyThread.Start();
        }

        void Test()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                listBox1.Items.Add(i.ToString());
            }
        }
    }
}