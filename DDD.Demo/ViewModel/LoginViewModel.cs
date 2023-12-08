using DDD.Demo.Dao;
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
    public class LoginViewModel : ViewModelBase
    {
        public AppData AppData { get; set; } = AppData.Instance;


        #region 登录事件

        public RelayCommand<Window> LoginCommand
        {
            get
            {
                return new RelayCommand<Window>((window) =>
                {
                    var list = new MemberProvider().Select();
                    if (list == null || list.Count == 0)
                    {
                        MessageBox.Show("当前数据没有用户");
                        return;
                    }
                    if (string.IsNullOrEmpty(AppData.CurrentUser.Name) == true)
                    {
                        MessageBox.Show("请输入用户名");
                        return;
                    }
                    if (string.IsNullOrEmpty(AppData.CurrentUser.Password) == true)
                    {
                        MessageBox.Show("请输入密码");
                        return;
                    }
                    var user = list.FirstOrDefault(t => t.Name == AppData.CurrentUser.Name && t.Password == AppData.CurrentUser.Password);

                    if (user == null)
                    {
                        MessageBox.Show("用户名或密码错误");
                        return;
                    }

                    var mainWindow = new MainWindow();
                    mainWindow.Show();
                    window.Close();
                });
            }
        }

        #endregion

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
