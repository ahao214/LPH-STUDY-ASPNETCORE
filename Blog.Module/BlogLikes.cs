using Blog.Module.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Module
{
    /// <summary>
    /// 博客点赞表
    /// </summary>
    public class BlogLikes : Entity
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
        /// 导航属性用户
        /// </summary>
        public virtual Users? User { get; set; }
        /// <summary>
        /// 导航属性博客
        /// </summary>
        public virtual Blogs? Blogs { get; set; }

    }
}
