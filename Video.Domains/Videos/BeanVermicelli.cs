using System;
using System.Collections.Generic;
using System.Text;

namespace Video.Domains
{
    /// <summary>
    /// 关注表
    /// </summary>
    public class BeanVermicelli
    {
        /// <summary>
        /// 编号
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 被关注ID
        /// </summary>
        public Guid BeFocusedId { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public Guid UserId { get; set; }

    }
}
