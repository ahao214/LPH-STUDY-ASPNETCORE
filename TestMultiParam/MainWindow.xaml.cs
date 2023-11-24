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

namespace TestMultiParam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();


        public MainWindow()
        {
            InitializeComponent();
            InitData();
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            for (int i = 0; i < 10; i++)
            {
                Student stu = new Student()
                {
                    Name = "刘" + (i + 1).ToString(),
                    Grade = i + 1,
                    Major = "计算机" + (i + 1).ToString(),
                    Age = 20 + i
                };
                students.Add(stu);
            }
            MyDataGrid.ItemsSource = students;
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(students[MyDataGrid.SelectedIndex].Name);
        }
    }
}