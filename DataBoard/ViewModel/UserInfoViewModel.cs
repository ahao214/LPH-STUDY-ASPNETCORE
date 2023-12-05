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

namespace DataBoard.ViewModel
{
    public class UserInfoViewModel : ViewModelBase
    {
        private IProvider<UserInfo> provider = new UserInfoProvider();
        
        /// <summary>
        /// 构造函数
        /// </summary>
        public UserInfoViewModel()
        {
            userInfos = provider.Select();
        }

        private List<UserInfo> userInfos;
        public List<UserInfo> UserInfos
        {
            get { return userInfos; }
            set { userInfos = value; RaisePropertyChanged(); }
        }


        /// <summary>
        /// 添加用户
        /// </summary>
        public RelayCommand OpenAddUserInfoWindowCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                    dialog.ShowMessage("AddUserInfoWindow", "提示");
                    UserInfos = provider.Select();
                });
            }
        }


        /// <summary>
        /// 修改用户
        /// </summary>
        public RelayCommand<UserInfo> OpenEditUserInfoWindowCommand
        {
            get
            {
                return new RelayCommand<UserInfo>((userInfo) =>
                {
                    var vm = SimpleIoc.Default.GetInstance<EditUserInfoWindowViewModel>();
                    if (vm == null)
                        return;
                    //                   vm.Line = line;

                    var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                    dialog.ShowMessage("EditUserInfoWindow", "提示");
                    UserInfos = provider.Select();
                });
            }
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        public RelayCommand<UserInfo> DeleteUserInfoWindowCommand
        {
            get
            {
                return new RelayCommand<UserInfo>((line) =>
                {
                    if (line == null) return;
                    var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                    var task = dialog.ShowMessage("确定要删除吗?", "提示", "", () =>
                    {
                        var count = provider.Delete(line);
                        if (count > 0)
                        {
                            dialog.ShowMessageBox("删除成功", "提示");
                            UserInfos = provider.Select();
                        }
                        else
                        {
                            dialog.ShowMessageBox("删除失败", "提示");

                        }
                    });
                    task.Start();
                });

            }
        }
    }
}
