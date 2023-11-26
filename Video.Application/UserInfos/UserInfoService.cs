using AutoMapper;
using FreeRedis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video.Application.Contract.UserInfos;
using Video.Application.Contract.UserInfos.Dtos;
using Video.Domains;

namespace Video.Application.UserInfos
{
    public class UserInfoService : IUserInfoService
    {
        private readonly IMapper _mapper;
        private readonly RedisClient _redisClient;
        public UserInfoService(IMapper mapper, RedisClient redisClient)
        {
            _mapper = mapper;
            _redisClient = redisClient;
        }

        public async Task<UserInfoDto> GetAsync()
        {            
            var userInfo = new UserInfo()
            {
                Avatar = "cs",
                CreateTime = DateTime.Now,
                Enable = false,
                Id = Guid.NewGuid(),
                Name = "test",
                UserName = "test"
            };
            var dto = _mapper.Map<UserInfoDto>(userInfo);
            return await Task.FromResult(dto);

        }

        public Task<UserInfoDto> LoginAsync(LoginInput input)
        {
            throw new NotImplementedException();
        }
    }
}
