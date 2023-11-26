using System;
using System.Collections.Generic;
using System.Text;

namespace Video.Domains
{
    /// <summary>
    /// 评论表
    /// </summary>
    public class Comment
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
