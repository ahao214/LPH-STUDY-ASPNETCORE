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
    public class EditUserInfoWindowViewModel : ViewModelBase
    {
        private UserInfo userInfo;

        public UserInfo UserInfo
        {
            get { return userInfo; }
            set { userInfo = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        public RelayCommand<Window> EditUserInfoCommand
        {
            get
            {
                return new RelayCommand<Window>((window) =>
                {
                    if (string.IsNullOrEmpty(UserInfo.Name))
                        return;
                    if (string.IsNullOrEmpty((UserInfo.Password))
                        return;

                    if (UserInfo.Name.Length > 32)
                        return;
                    if (UserInfo.Password.Length > 32)
                        return;

                    var appData = ServiceLocator.Current.GetInstance<AppData>();
                    this.UserInfo.Id = appData.CurrentUser.Id;
                    this.UserInfo.InsertDate = DateTime.Now;
                    UserInfoProvider userInfoProvider = new UserInfoProvider();

                    var count = userInfoProvider.Update(this.UserInfo);
                    if (count > 0)
                    {
                        var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                        dialog.ShowMessageBox("修改用户成功", "提示");
                        window.Close();
                    }
                    else
                    {
                        var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                        dialog.ShowMessageBox("修改用户失败", "提示");
                    }

                });
            }
        }
    }
}
