using System;
using System.Collections.Generic;
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
using System.IO.Ports;


namespace WpfSerialAssistant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeSerials();
        }

        /// <summary>
        /// 初始化串口下拉列表框的数据
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void InitializeSerials()
        {
            // 获取当前机器中所有可以使用串口列表
            var portList = SerialPort.GetPortNames();
            // 把列表绑定到串口下拉列表框中
            CbPort.ItemsSource = portList;
            // 选择第一项
            CbPort.SelectedIndex = 0;

        }
    }
}
