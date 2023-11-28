using AutoMapper;
using Blog.Application.Contract.User;
using Blog.Application.Contract.User.Dto;
using Blog.EntityFrameworkCore;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Users
{
    public class UserServer : IUserServer
    {
        private readonly BlogDbContext dbContext;
        private readonly IMapper mapper;
        private readonly CurrentServer currentServer;
        public UserServer(BlogDbContext db, IMapper mp, CurrentServer currentServer)
        {
            dbContext = db;
            mapper = mp;
            this.currentServer = currentServer;
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



        #region 删除用户


        public async Task DeleteAsync(Guid id)
        {
            var user = await dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (user != null)
            {
                // 删除用户
                dbContext.Users.Remove(user);
                // 保存操作
                await dbContext.SaveChangesAsync();
            }
        }

        #endregion

        #region 编辑用户
        public async Task UpdateAsync(UpdateUserDto user)
        {
            var userId = currentServer.GetUserId();
            var result = await dbContext.Users.FirstOrDefaultAsync(x => x.Id == userId);
            if (result == null)
                return;

            mapper.Map(user, result);
            dbContext.Users.Update(result);
            await dbContext.SaveChangesAsync();

        }

        #endregion
    }
}
