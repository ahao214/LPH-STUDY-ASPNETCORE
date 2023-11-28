using Blog.Application.Contract.User.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contract.User
{
    public interface IUserServer
    {
        /// <summary>
        /// 创建用户
        /// </summary>
        /// <returns></returns>
        Task CreateUserAsync(CreateUserDto input);
        /// <summary>
        /// 登录账号
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<UserDto> LoginAsync(LoginDto input);
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteAsync(Guid id);
        /// <summary>
        /// 编辑用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task UpdateAsync(UpdateUserDto input);
        /// <summary>
        /// 获取用户
        /// </summary>
        /// <returns></returns>
        Task<UserDto> GetAsync();
    }
}
