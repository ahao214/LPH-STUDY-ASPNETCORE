using System;
using System.Collections.Generic;
using System.Text;


namespace Video.Domains
{
    /// <summary>
    /// 用户角色配置表
    /// </summary>
    public class UserRole
    {
        public Guid Id { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public Guid RoleId { get; set; }

    }
}
