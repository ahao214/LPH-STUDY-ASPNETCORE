using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AHOCMS.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        public AppData AppData { get; set; } = AppData.Instance;

        public LoginViewModel()
        {
           
        }

        /// <summary>
        /// 登录命令
        /// </summary>
        public RelayCommand LoginCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    MessageBox.Show("登录成功");
                });
            }
        }

        /// <summary>
        /// 取消命令
        /// </summary>
        public RelayCommand CloseCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    MessageBox.Show("取消");
                });
            }
        }


    }
}
