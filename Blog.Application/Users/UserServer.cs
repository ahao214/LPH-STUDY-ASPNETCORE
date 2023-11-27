using AutoMapper;
using Blog.Application.Contract.Dto;
using Blog.Application.Contract.User;
using Blog.EntityFrameworkCore;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Users
{
    public class UserServer : IUserServer
    {
        private readonly BlogDbContext dbContext;
        private readonly IMapper mapper;
        public UserServer(BlogDbContext db, IMapper mp)
        {
            dbContext = db;
            mapper = mp;
        }

        #region 创建用户
        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="BusinessException"></exception>
        public async Task CreateUserAsync(CreateUserDto input)
        {
            if (await dbContext.Users.AnyAsync(x => x.UserName == input.UserName))
            {
                throw new BusinessException("用户名已存在");
            }

            // Mapper 映射
            var data = mapper.Map<Module.Users>(input);
            data.CreationTime = DateTime.Now;
            // 添加到数据库
            await dbContext.Users.AddAsync(data);
            // 保存操作
            await dbContext.SaveChangesAsync();
        }
        #endregion

        #region 登录
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<UserDto> LoginAsync(LoginDto input)
        {
            var data = await dbContext.Users.FirstOrDefaultAsync(x => x.UserName == input.UserName && x.Password == input.Password);
            if (data == null)
            {
                throw new BusinessException("账号或密码错误");
            }

            var dto = mapper.Map<UserDto>(data);
            return dto;
        }
        #endregion
    }
}
