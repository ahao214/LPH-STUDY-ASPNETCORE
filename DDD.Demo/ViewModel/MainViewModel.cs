using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;

namespace DDD.Demo.ViewModel
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
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }


        /// <summary>
        /// 系统时间
        /// </summary>
        private string systemTime;
        public string SystemTime
        {
            get { return systemTime; }
            set { systemTime = value; RaisePropertyChanged(); }

        }


        #region 退出程序
        /// <summary>
        /// 退出程序
        /// </summary>
        public RelayCommand ExitCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    Application.Current.Shutdown();
                });

            }
        }
        #endregion
    }
}