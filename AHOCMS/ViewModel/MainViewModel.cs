using AHOCMS.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Controls;

namespace AHOCMS.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public AppData AppData { get; set; } = AppData.Instance;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {

        }


        public RelayCommand<RadioButton> SelectViewCommand
        {
            get
            {
                return new RelayCommand<RadioButton>((arg) =>
                {
                    if (!(arg is RadioButton button))
                        return;
                    if (string.IsNullOrEmpty(button.Content.ToString()))
                        return;
                    switch (button.Content.ToString())
                    {
                        case "��ҳ":
                            AppData .Instance .MainWindow .container.Content = new IndexView();
                            break;
                        case "�����":
                            AppData.Instance.MainWindow.container.Content = new RecordView();
                            break;
                        case "���ʹ���":
                            AppData.Instance.MainWindow.container.Content = new CargoView();
                            break;
                        case "�û�����":
                            AppData.Instance.MainWindow.container.Content = new MemberView();
                            break;
                        case "��������":
                            AppData.Instance.MainWindow.container.Content = new CargoTypeView();
                            break;
                        default:
                            break;
                    }
                });
            }
        }


    }
}