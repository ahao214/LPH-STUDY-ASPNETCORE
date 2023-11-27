using Blog.Application.Contract.Dto;
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

        Task LoginAsync(LoginDto input);
    }
}
