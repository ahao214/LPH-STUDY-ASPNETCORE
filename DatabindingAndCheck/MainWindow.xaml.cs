using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DatabindingAndCheck
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee employee = new Employee() { Name = "Default name" };




        public MainWindow()
        {
            InitializeComponent();

            #region 绑定
            // 实例化Binding 对象
            //Binding binding = new Binding();

            //binding.Source = employee;
            //binding.Path = new PropertyPath("Name");
            //// 使用 BindingOperations.SetBinding() 实现绑定，传入目标的目标名称,依赖属性,传入Binding对象 
            //BindingOperations.SetBinding (this .InputTextBox,TextBox .TextProperty, binding);

            #endregion

            #region 简化绑定

            this.InputTextBox.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = employee, Mode = BindingMode.OneWay });

            #endregion
        }

        private void OutputName_Click(object sender, RoutedEventArgs e)
        {
            this.OutputTextBox.Text = "My name is " + employee.Name;

        }

        private void NameToAmy_Click(object sender, RoutedEventArgs e)
        {
            this.OutputTextBox.Text = "Amy";
        }
    }
}