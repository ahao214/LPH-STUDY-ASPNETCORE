using Simple.EntityFramworkCore.Core.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Video.Domains
{
    /// <summary>
    /// 视频表
    /// </summary>
    public class Video : Entity
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// 视频地址
        /// </summary>
        public string? VideoUrl { get; set; }
        /// <summary>
        /// 分类ID
        /// </summary>
        public Guid ClassifyId { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public Guid UserId { get; set; }

        public virtual UserInfo? User { get; set; }

        public virtual Classify? Classify { get; set; }
    }
}
