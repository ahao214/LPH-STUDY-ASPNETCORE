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

namespace TestComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<CbbData> cbbDatas = new List<CbbData>();
            CbbData cbbData = new CbbData()
            {
                ID = 0,
                Name = "Please Choose"
            };
            cbbDatas.Add(cbbData);
            for (int i = 0; i < 20; i++)
            {
                CbbData c1 = new CbbData();
                c1.ID = i;
                c1.Name = "a" + i.ToString();
                cbbDatas.Add(c1);
            }
            myCbb.ItemsSource = cbbDatas;
        }
    }
}