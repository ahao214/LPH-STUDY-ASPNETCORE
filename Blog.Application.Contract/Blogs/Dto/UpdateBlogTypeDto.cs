using Blog.Application.Contract.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contract.Blogs.Dto
{
    public class UpdateBlogTypeDto : EntityDto
    {
        [Required(ErrorMessage = "类型名称不能为空")]
        [MinLength(2, ErrorMessage = "博客类型长度不能小于两位")]
        public string Name { get; set; }
    }
}
