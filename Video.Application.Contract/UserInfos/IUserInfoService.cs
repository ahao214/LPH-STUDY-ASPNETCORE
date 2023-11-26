using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Video.Application.Contract.UserInfos.Dtos;

namespace Video.Application.Contract.UserInfos
{
    public interface IUserInfoService
    {
        Task<UserInfoDto> GetAsync();


    }
}
