using Simple.EntityFramworkCore.Core.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Video.Domains
{
    /// <summary>
    /// 关注表
    /// </summary>
    public class BeanVermicelli: Entity
    {
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
