using AutoMapper;
using Blog.Application.Contract.Dto;
using Blog.Application.Contract.User;
using Blog.EntityFrameworkCore;
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

        public async Task CreateUserAsync(CreateUserDto input)
        {
            if (await dbContext.Users.AnyAsync(x => x.UserName == input.UserName))
            {

            }

            var data = mapper.Map<Module.Users>(input);

        }
    }
}
