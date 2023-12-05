using CommonServiceLocator;
using DataBoard.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
