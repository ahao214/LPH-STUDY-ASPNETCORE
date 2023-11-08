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

namespace WpfListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }
        }



        public MainWindow()
        {
            InitializeComponent();

            listbox.Items.Add(new Person
            {
                Name = "张三",
                Age = 23,
                Address = "北京"
            });
            listbox.Items.Add(new Person
            {
                Name = "JACK",
                Age = 24,
                Address = "Lakers"
            });
            listbox.Items.Add(new Person
            {
                Name = "大道",
                Age = 30,
                Address = "上海"
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = listbox.SelectedItem;
            var selectedValue = listbox.SelectedValue;
            textblock.Text = $"Item={selectedItem},Value={selectedValue}";


        }
    }
}
