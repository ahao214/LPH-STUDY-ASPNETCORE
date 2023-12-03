using System.Text;
using System.Windows;
using System.Windows.Automation.Provider;
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

            List<Employee> lst = new List<Employee>()
            {
                new Employee (){ ID =0,Name ="Jack",Age =24,PhoneType="Iphone 5"},
                new Employee (){ ID =1,Name ="James",Age =45,PhoneType="nikie"},
                new Employee (){ ID =2,Name ="Tom",Age =12,PhoneType="apple"},
                new Employee (){ ID =3,Name ="Blue",Age =34,PhoneType="xiaomi"},
                new Employee (){ ID =4,Name ="Black",Age =24,PhoneType="Iphone max"}
            };

            // 指定条目控件的源和路径实现绑定
            this.EmployeeList_ListBox.ItemsSource = lst;

            // 使用后置代码实现控件之间的绑定
            Binding binding = new Binding("SelectedItem.ID") { Source = this.EmployeeList_ListBox };
            this.ID_TextBox.SetBinding(TextBox.TextProperty, binding);


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