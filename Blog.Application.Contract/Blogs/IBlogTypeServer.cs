using Blog.Application.Contract.Blogs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contract.Blogs
{
    public interface IBlogTypeServer
    {
        Task CreateAsync(CreateBlogTypesDto input);

    }
}
