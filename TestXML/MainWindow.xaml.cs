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
using System.Xml;

namespace TestXML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string path = @"..\..\test.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode xmlNode = doc.SelectSingleNode("StudentInfo");

            XmlNodeList xmlNodeList = xmlNode.ChildNodes;
            List <Student > lstStudent = new List <Student> ();   
            foreach (XmlNode item in xmlNodeList )
            {
                Student student = new Student();
                XmlElement ele = (XmlElement)item;
                student.Grade = ele.GetAttribute("Grade");
                student.Teacher = ele.GetAttribute("Teacher");

                XmlNodeList xmlNodeList1 = ele.ChildNodes;
                student.Name = xmlNodeList1.Item(0).InnerText;
                student.Address = xmlNodeList1.Item(1).InnerText;
                student.Age = Convert.ToInt32(xmlNodeList1.Item(2).InnerText);
                lstStudent.Add(student);
            }

            listView.ItemsSource = lstStudent;
        }
    }
}
