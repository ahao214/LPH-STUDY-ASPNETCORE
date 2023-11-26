using System;
using System.Collections.Generic;
using System.Text;

namespace Video.Domain
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
        public Guid RoelId { get; set; }

    }
}
