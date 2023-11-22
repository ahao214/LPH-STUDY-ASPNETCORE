using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerBooksManagerModels.Model
{
    public  class UserInfo
    {/// <summary>
     /// 自动编号
     /// </summary>
        public static int Id { get; set; }
        /// <summary>
        /// 登录名称
        /// </summary>
        public static string LoginName { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        public static string LoginPass { get; set; }
        /// <summary>
        /// 是否为超级管理员
        /// </summary>
        public static short IsSupper { get; set; }
    }
}
