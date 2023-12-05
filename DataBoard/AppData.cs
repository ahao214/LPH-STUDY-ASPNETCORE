using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBoard.Model;
using DataBoard.Entities;


namespace DataBoard
{
    /// <summary>
    /// 全局数据类
    /// </summary>
    public class AppData : ViewModelBase
    {
        public AppData()
        {
            roleModels = new List<RoleModel>();
            roleModels.Add(new RoleModel { Id = 0, Name = "管理员" });
            roleModels.Add(new RoleModel { Id = 1, Name = "普通用户" });

        }

        private UserInfo userInfo = new UserInfo() { Name = "admin", Password = "1" };

        /// <summary>
        /// 当前用户
        /// </summary>
        public UserInfo CurrentUser
        {
            get { return userInfo; }
            set { userInfo = value; }
        }


        private List<RoleModel> roleModels;

        public List<RoleModel> RoleModels
        {
            get { return roleModels; }
            set { roleModels = value; }

        }
    }
}
