using Blog.Application.Contract.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contract.Blogs.Dto
{
    public class BlogInput : PageInput
    {
        /// <summary>
        /// 搜索关键词
        /// </summary>
        public string? Keyword { get; set; }

        /// <summary>
        /// 类型ID       
        /// </summary>
        public Guid? TypeId { get; set; }

    }
}
