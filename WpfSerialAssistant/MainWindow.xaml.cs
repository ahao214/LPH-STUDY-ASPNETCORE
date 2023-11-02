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
        private SerialPort? serialPort;



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

        /// <summary>
        /// 连接串口或者断开串口核心逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOpenSerialPort_Click(object sender, RoutedEventArgs e)
        {
            // 获取按钮
            Button button = (Button)sender;

            // 关闭串口
            if (serialPort != null && serialPort.IsOpen)
            {
                if (CloseSerialPort())
                {
                    button.Content = "打开串口";
                }
            }
            else // 打开串口
            {
                if (OpenSerialPort())
                {
                    button.Content = "关闭串口";

                }
            }



        }


        /// <summary>
        /// 打开串口的方法
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private bool OpenSerialPort()
        {
            bool flag = false;
            try
            {
                // 创建串口对象
                serialPort = new SerialPort();
                // 串口名称 波特率 数据位 校验位 停止位
                // 填充对象需要的内容
                serialPort.PortName = CbPort.Name;
                serialPort.BaudRate = Convert.ToInt32(CbBaudRate.Text);
                // 把校验位文本转换为一个枚举对象
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), CbParity.Text);
                serialPort.DataBits = Convert.ToInt32(CbDataBits.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CbStoBit.Text);
                // 打开串口
                serialPort.Open();
                if (serialPort.IsOpen)
                {
                    flag = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("打开串口失败");
            }
            return flag;
        }

        /// <summary>
        /// 关闭串口
        /// </summary>
        /// <returns></returns>
        private bool CloseSerialPort()
        {
            bool flag = false;

            return flag;
        }
    }
}
