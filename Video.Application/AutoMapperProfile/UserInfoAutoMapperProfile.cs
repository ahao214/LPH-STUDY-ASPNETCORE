using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video.Application.Contract.UserInfos.Dtos;
using Video.Domains;

namespace Video.Application.AutoMapperProfile
{
    public class UserInfoAutoMapperProfile:Profile
    {
        public UserInfoAutoMapperProfile()
        {
            CreateMap<UserInfo, UserInfoDto>().ReverseMap();
        }
    }
}
