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

namespace WpfConsolePannel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 视图缩放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Canvas_MouseWheel(object sender,MouseWheelEventArgs e)
        {
            // 获取实际渲染的高度和宽度
            var width = this.mainView.ActualWidth + e.Delta;
            var height = this.mainView.ActualHeight + e.Delta;
            if (width < 100)
                width = 500;
            if (height < 100)
                height = 100;
            this.mainView.Height = height;
            this.mainView.Width = width;
            // 设置画板缩放的左边位置
            this .mainView .SetValue (Canvas.LeftProperty,(this.RenderSize.Width - this.mainView.Width) / 2);
        }


        bool _isMoving = false;
        Point _point = new Point(0, 0);
        double _left =0, _top = 0;

    }
}
