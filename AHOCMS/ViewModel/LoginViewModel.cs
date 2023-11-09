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
                    MemberProvider memberProvider = new MemberProvider();
                    var list = memberProvider.Select();
                    var user = list.FirstOrDefault(item => item.Name == AppData.CurrentUser.Name && item.Password == AppData.CurrentUser.Password);

                    if (user == null)
                    {
                        MessageBox.Show("用户名或密码错误");
                    }
                    else
                    {
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();



                    }



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
