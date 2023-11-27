using Blog.Module.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Module
{
    /// <summary>
    /// 博客类型表
    /// </summary>
    public class BlogTypes : Entity
    {
        /// <summary>
        /// 类型名称
        /// </summary>
        public string Name { get; set; }


    }
}
