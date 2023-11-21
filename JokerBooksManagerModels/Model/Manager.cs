using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerBooksManagerModels.Model
{
    /// <summary>
    /// 管理员表
    /// </summary>
    public class Manager
    {
        /// <summary>
        /// 自动编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 登录名称
        /// </summary>
        public string LoginName { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        public string LoginPass { get; set; }
        /// <summary>
        /// 是否为超级管理员
        /// </summary>
        public short IsSupper { get; set; }





    }
}
