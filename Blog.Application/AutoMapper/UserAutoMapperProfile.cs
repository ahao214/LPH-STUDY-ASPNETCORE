using AutoMapper;
using Blog.Application.Contract.Dto;


namespace Blog.Application.AutoMapper
{
    public class UserAutoMapperProfile : Profile
    {
        public UserAutoMapperProfile()
        {
            CreateMap<CreateUserDto, Module.Users>();
        }
    }
}
