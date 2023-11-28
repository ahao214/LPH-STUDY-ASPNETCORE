using Ahao_Blog.Options;
using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Ahao_Blog.Controllers
{



    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {

        private readonly BlogFileOptions options;

        public FileController(IOptions<BlogFileOptions> options)
        {
            this.options = options.Value;
        }


        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<string> UploadAsync(IFormFile file)
        {
            // 限制文件大小
            if (file.Length > ((options.MaxSize * 1024) * 1024))
            {
                throw new BusinessException("文件超过限制的大小");
            }

            var name = Guid.NewGuid().ToString("N") + file.Name;
            // 是否存在文件夹
            if (!Directory.Exists("./wwwroot/file"))
            {
                Directory.CreateDirectory("./wwwroot/file");
            }

            var fileStream = System.IO.File.Create(Path.Combine("./wwwroot/file", name));
            await file.OpenReadStream().CopyToAsync(fileStream);

            // 释放文件流
            await file.OpenReadStream().DisposeAsync();
            fileStream.Close();


            return "file/" + name;
        }
    }
}
