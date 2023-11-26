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
using Video.Domains.Users;

namespace Video.Application.UserInfos
{
    public class UserInfoService : IUserInfoService
    {
        private readonly IMapper _mapper;
        private readonly IUserInfoRepository _userInfoRepository;


        private readonly RedisClient _redisClient;
        public UserInfoService(IMapper mapper, RedisClient redisClient, IUserInfoRepository userInfoRepository)
        {
            _mapper = mapper;
            _redisClient = redisClient;
            _userInfoRepository = userInfoRepository;
        }

        public async Task<UserInfoDto> GetAsync()
        {
            var userInfo = new UserInfo()
            {
                Avatar = "cs",
                //CreateTime = DateTime.Now,
                Enable = false,
                Id = Guid.NewGuid(),
                Name = "test",
                UserName = "test"
            };
            var dto = _mapper.Map<UserInfoDto>(userInfo);
            return await Task.FromResult(dto);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<UserInfoRoleDto> LoginAsync(LoginInput input)
        {
            var data = await _userInfoRepository.GetUserInfoRoleAsync(input.UserName, input.Password);
            var dto = _mapper.Map<UserInfoRoleDto>(data);
            return dto;
        }
    }
}
