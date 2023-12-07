using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace DDD.Demo.ViewModel
{
    public class LoginViewModel:ViewModelBase
    {
        public AppData AppData { get; set; } = AppData.Instance;




        #region 关闭事件
        public RelayCommand<Window> CloseCommand
        {
            get
            {
                return new RelayCommand<Window>((window) =>
                {
                    window.Close();
                });
            }
        } 
        #endregion
    }
}
