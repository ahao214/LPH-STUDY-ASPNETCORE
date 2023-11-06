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

            //doc.Load(path);

            XmlReaderSettings settings = new XmlReaderSettings();
            // 忽略XML文件中的注释
            settings.IgnoreWhitespace = true;
            XmlReader xmlReader = XmlReader.Create(path, settings);
            doc.Load(xmlReader);

            XmlNode xmlNode = doc.SelectSingleNode("StudentInfo");

            XmlNodeList xmlNodeList = xmlNode.ChildNodes;
            List<Student> lstStudent = new List<Student>();
            foreach (XmlNode item in xmlNodeList)
            {
                #region

                // 读取到的信息是注释
                //if (item is XmlComment)
                //{
                //    XmlComment comment = (XmlComment)item;
                //    string str = comment.InnerText;
                //}
                //else
                //{
                //    Student student = new Student();
                //    XmlElement ele = (XmlElement)item;
                //    student.Grade = ele.GetAttribute("Grade");
                //    student.Teacher = ele.GetAttribute("Teacher");

                //    XmlNodeList xmlNodeList1 = ele.ChildNodes;
                //    student.Name = xmlNodeList1.Item(0).InnerText;
                //    student.Address = xmlNodeList1.Item(1).InnerText;
                //    student.Age = Convert.ToInt32(xmlNodeList1.Item(2).InnerText);
                //    lstStudent.Add(student);
                //}

                #endregion

                #region 忽略XML文件中的注释

                Student student = new Student();
                XmlElement ele = (XmlElement)item;
                student.Grade = ele.GetAttribute("Grade");
                student.Teacher = ele.GetAttribute("Teacher");

                XmlNodeList xmlNodeList1 = ele.ChildNodes;
                student.Name = xmlNodeList1.Item(0).InnerText;
                student.Address = xmlNodeList1.Item(1).InnerText;
                student.Age = Convert.ToInt32(xmlNodeList1.Item(2).InnerText);
                lstStudent.Add(student);

                #endregion
            }

            listView.ItemsSource = lstStudent;
        }
    }
}
