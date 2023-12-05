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
        private UserInfo userInfo = new UserInfo() { Name = "admin", Password = "0" };

        /// <summary>
        /// 当前用户
        /// </summary>
        public UserInfo UserInfo
        {
            get
            {
                return userInfo;
            }
            set
            {
                userInfo = value;
            }
        }


    }
}
