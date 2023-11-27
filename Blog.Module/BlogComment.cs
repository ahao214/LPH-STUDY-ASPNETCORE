using Blog.Module.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Module
{
    /// <summary>
    /// 博客评论
    /// </summary>
    public class BlogComment:Entity
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// 博客ID
        /// </summary>
        public Guid BlogId { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string Content { get; set; }
    }
}
