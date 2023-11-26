using System;
using System.Collections.Generic;
using System.Text;

namespace Video.Domains
{
    /// <summary>
    /// 点赞表
    /// </summary>
    public class Like
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
