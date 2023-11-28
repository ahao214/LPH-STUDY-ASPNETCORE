using Blog.Application.Contract.Blogs;
using Blog.Application.Contract.Blogs.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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

        /// <summary>
        /// 更新博客
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task UpdateAsync(CreateBlogsDto input)
        {
            await blogServer.UpdateAsync(input);
        }

        /// <summary>
        /// 删除博客
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task DeleteAsync(Guid id)
        {
            await blogServer.DeleteAsync(id);
        }

        /// <summary>
        /// 获取博客详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<BlogDto> GetAsync(Guid id)
        {
            return await blogServer.GetAsync(id);
        }


        /// <summary>
        /// 点赞博客
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task LikeAsync(Guid id)
        {
            await blogServer.LikeAsync(id);
        }


        



    }


}
