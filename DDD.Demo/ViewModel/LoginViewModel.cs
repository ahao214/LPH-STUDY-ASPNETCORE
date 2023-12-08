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
    public class LoginViewModel:ViewModelBase
    {
        public AppData AppData { get; set; } = AppData.Instance;


        #region 登录事件

        public RelayCommand <Window> LoginCommand
        {
            get
            {
                return new RelayCommand<Window>((window) =>
                {
                    var list = new MemberProvider().Select();
                    if(list == null || list.Count ==0)
                    {
                        MessageBox.Show("当前数据没有用户");
                    }    
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
