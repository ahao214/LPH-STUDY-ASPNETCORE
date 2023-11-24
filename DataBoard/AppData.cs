using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBoard.Model;


namespace DataBoard
{
    /// <summary>
    /// 全局数据类
    /// </summary>
    public class AppData : ViewModelBase
    {
        private UserInfo userInfo = new UserInfo() { Name = "admin", Password = "1" };

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
