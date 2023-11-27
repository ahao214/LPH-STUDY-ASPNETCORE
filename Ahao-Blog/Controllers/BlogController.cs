using Blog.Application.Contract.Blogs;
using Blog.Application.Contract.Blogs.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ahao_Blog.Controllers
{
    /// <summary>
    /// 博客文章
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BlogController : ControllerBase
    {
        private readonly IBlogServer blogServer;

        public BlogController(IBlogServer blogServer)
        {
            this.blogServer = blogServer;
        }

        [HttpPost]
        public async Task CreateAsync(CreateBlogsDto input)
        {
            await blogServer.CreateBlogAsync(input);
        }


    }


}
