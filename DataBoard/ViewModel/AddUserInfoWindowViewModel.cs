using CommonServiceLocator;
using DataBoard.Model;
using DataBoard.Model.Provider;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DataBoard.ViewModel
{
    public class AddUserInfoWindowViewModel : ViewModelBase
    {
        public AddUserInfoWindowViewModel()
        {
            appData = ServiceLocator.Current.GetInstance<AppData>();
        }

        private AppData appData;
        public AppData AppData
        {
            get { return appData; }
            set { appData = value; }
        }
        private UserInfo userInfo = new UserInfo();


        /// <summary>
        /// 当前用户
        /// </summary>
        public UserInfo CurrentUser
        {
            get { return userInfo; }
            set { userInfo = value; }
        }


        /// <summary>
        /// 添加用户
        /// </summary>
        public RelayCommand<Window> AddUserInfoCommand
        {
            get
            {
                return new RelayCommand<Window>((window) =>
                {
                    if (string.IsNullOrEmpty(CurrentUser.Name))
                        return;
                    if (string.IsNullOrEmpty(CurrentUser.Password))
                        return;

                    if (CurrentUser.Name.Length > 32)
                        return;
                    if (CurrentUser.Password.Length > 32)
                        return;

                    var appData = ServiceLocator.Current.GetInstance<AppData>();
                    
                    this.CurrentUser.InsertDate = DateTime.Now;
                    UserInfoProvider provider = new UserInfoProvider();
                    var count = provider.Insert(this.CurrentUser);
                    if (count > 0)
                    {
                        var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                        dialog.ShowMessageBox("添加成功", "提示");
                        window.Close();
                        this.CurrentUser = new UserInfo();
                    }
                    else
                    {
                        var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                        dialog.ShowMessageBox("添加失败", "提示");
                    }

                });
            }
        }

    }
}
