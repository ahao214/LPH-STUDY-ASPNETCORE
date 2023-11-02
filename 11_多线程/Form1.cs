using System.Threading;


namespace _11_多线程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 单线程做菜
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            MessageBox.Show("素菜做好了");
            Thread.Sleep(5000);
            MessageBox.Show("荤菜做好了");
        }

        /// <summary>
        /// Thread做菜
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("素菜做好了", "友情提示");
                Thread.Sleep(5000);
                MessageBox.Show("荤菜做好了", "友情提示");
            });
            t.Start();
        }

        /// <summary>
        /// Task做菜
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("素菜做好了", "友情提示");
                Thread.Sleep(5000);
                MessageBox.Show("荤菜做好了", "友情提示");
            });

        }

        /// <summary>
        /// 同时做多道菜
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("素菜做好了", "友情提示");
            });
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                MessageBox.Show("荤菜做好了", "友情提示");
            });
        }

        /// <summary>
        /// 菜都做好了吃饭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("素菜做好了", "友情提示");
                Thread.Sleep(5000);
                MessageBox.Show("荤菜做好了", "友情提示");
            });
            MessageBox.Show("菜都做好了，大家来吃饭");
        }
    }
}