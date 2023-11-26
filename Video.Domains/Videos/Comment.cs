using Simple.EntityFramworkCore.Core.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Video.Domains
{
    /// <summary>
    /// 评论表
    /// </summary>
    public class Comment : Entity
    {
       
        /// <summary>
        /// 上级ID
        /// </summary>
        public Guid ParentId { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        public string? Content { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// 视频ID
        /// </summary>
        public Guid VideoId { get; set; }

        public virtual UserInfo? User { get; set; }

        public virtual Video? Video { get; set; }
    }
}
