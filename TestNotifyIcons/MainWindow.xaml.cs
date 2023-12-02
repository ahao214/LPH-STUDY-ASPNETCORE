using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace TestNotifyIcons
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        NotifyIcon icon;

        public MainWindow()
        {
            InitializeComponent();
            InitIcon();
        }


        private void InitIcon()
        {
            icon = new NotifyIcon();
            icon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);

            icon.Text = "我的应用程序";
            icon.Visible = true;

            // 右键菜单命令
            MenuItem menuItem = new MenuItem("退出");
            menuItem.Click += MenuItem_Click;

            MenuItem mi1 = new MenuItem("关于");
            mi1.Click += Mi1_Click;

            System.Windows.Forms.MenuItem[] ms = new System.Windows.Forms.MenuItem[] { menuItem, mi1 };
            icon.ContextMenu = new System.Windows.Forms.ContextMenu(ms);

        }

        private void Mi1_Click(object sender, EventArgs e)
        {
            System.Windows.MessageBox.Show("关于程序的信息");
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            icon.Dispose();
            this.Close();
        }
    }
}
