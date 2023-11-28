﻿using Blog.Module.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Module
{
    /// <summary>
    /// 博客文章
    /// </summary>
    public class Blogs : Entity
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 文章内容
        /// </summary>
        public string? Content { get; set; }
        /// <summary>
        /// 浏览量
        /// </summary>
        public long PageView { get; set; }
        /// <summary>
        /// 文章类型ID
        /// </summary>
        public Guid TypeId { get; set; }
        /// <summary>
        /// 作者ID
        /// </summary>
        public Guid AuthorId { get; set; }
        /// <summary>
        /// 导航属性博客类型
        /// </summary>
        public virtual BlogTypes Type { get; set; }
        /// <summary>
        /// 导航属性用户
        /// </summary>
        public virtual Users? Author { get; set; }
        /// <summary>
        /// 点赞人员
        /// </summary>
        public virtual List<BlogLikes> BlogLikes { get; set; }

        public Blogs()
        {
            BlogLikes = new List<BlogLikes>();
        }



    }
}
