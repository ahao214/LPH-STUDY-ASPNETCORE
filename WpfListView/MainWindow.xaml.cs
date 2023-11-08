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

namespace WpfListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Person
        {
            public string? Name { get; set; }
            public int Age { get; set; }
            public string? Address { get; set; }

        }

        public MainWindow()
        {
            InitializeComponent();

            listview.Items.Add(new Person { Name = "张三", Age = 22, Address = "广东省廉江市车板镇大坝村" });
            listview.Items.Add(new Person { Name = "李四", Age = 23, Address = "江西省景德镇市市辖区" });
            listview.Items.Add(new Person { Name = "王五", Age = 24, Address = "上海市虹口区" });
        }
        private void listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView listView = sender as ListView;
            if (listView == null) return;

            var person = listView.SelectedItem as Person;
            if (person == null) return;

            _TextBlockName.Text = person.Name;
            _TextBlockAge.Text = person.Age + "岁";
            _TextBlockAddress.Text = person.Address;
        }
    }
}
