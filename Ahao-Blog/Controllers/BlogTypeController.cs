using Blog.Application.Contract.Blogs;
using Blog.Application.Contract.Blogs.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ahao_Blog.Controllers
{
    /// <summary>
    /// 博客类型
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BlogTypeController : ControllerBase
    {
        private readonly IBlogTypeServer blogTypeServer;

        public BlogTypeController(IBlogTypeServer blogTypeServer)
        {
            this.blogTypeServer = blogTypeServer;
        }

        [HttpPost]
        public async Task CreateAsync(CreateBlogTypesDto input)
        {
            await blogTypeServer.CreateAsync(input);
        }

    }
}
