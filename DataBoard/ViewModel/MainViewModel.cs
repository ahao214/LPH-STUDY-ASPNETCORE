using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace DataBoard.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            appData = ServiceLocator.Current.GetInstance<AppData>();

            Task.Run(() =>
            {
                while (true)
                {
                    this.SystemTime = DateTime.Now.ToString();
                    Thread.Sleep(1000);
                }
            });
        }

        private AppData appData;
        public AppData AppData
        {
            get { return appData; }
            set { appData = value; }
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
                var cmd = new RelayCommand(() =>
                {
                    Application.Current.Shutdown();
                });
                return cmd;
            }
        } 
        #endregion


    }
}