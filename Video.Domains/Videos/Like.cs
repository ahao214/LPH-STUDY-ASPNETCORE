using Simple.EntityFramworkCore.Core.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Video.Domains
{
    /// <summary>
    /// 点赞表
    /// </summary>
    public class Like : Entity
    {
        /// <summary>
        /// 视频ID | 评论ID
        /// </summary>
        public Guid VideoId { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// 点赞分类
        /// </summary>
        public LikeType Type {  get; set; }

        public virtual UserInfo? User {  get; set; }

        public virtual Video? Video { get; set; }


    }
}
