using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBoard.Controls
{
    /// <summary>
    /// DateTimeControl.xaml 的交互逻辑
    /// </summary>
    public partial class DateTimeControl : UserControl
    {
        public DateTimeControl()
        {
            InitializeComponent();
            Loaded += (s, e) =>
            {
                DateTime now = DateTime.Now;
                // 初始化年数据
                for (int i = 1949; i < 2049; i++)
                {
                    comboxYear.Items.Add(i);
                }
                // 初始化月数据
                for (int i = 0; i < 13; i++)
                {
                    comboxMonth.Items.Add(i);
                }
                // 初始化日数据
                for (int i = 1; i < 32; i++)
                {
                    comboxDay.Items.Add(i);
                }
                // 初始化时数据
                for (int i = 0; i < 24; i++)
                {
                    comboxHour.Items.Add(i);
                }
                // 初始化分数据
                for (int i = 0; i < 60; i++)
                {
                    comboxMinute.Items.Add(i);
                }
                // 初始化秒数据
                for (int i = 0; i < 60; i++)
                {
                    comboxSecond.Items.Add(i);
                }

            };


        }
    }
}
