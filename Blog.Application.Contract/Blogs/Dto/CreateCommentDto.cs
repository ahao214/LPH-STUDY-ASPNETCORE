using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contract.Blogs.Dto
{
    /// <summary>
    /// 博客评论
    /// </summary>
    public class CreateCommentDto
    {
        /// <summary>
        /// 评论内容
        /// </summary>
        public string Content { get; set; } = null!;
        /// <summary>
        /// 指定博客ID
        /// </summary>
        public Guid BlogId { get; set; }

    }
}
