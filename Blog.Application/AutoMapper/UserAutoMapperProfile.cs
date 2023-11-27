using AutoMapper;
using Blog.Application.Contract.Dto;


namespace Blog.Application.AutoMapper
{
    public class UserAutoMapperProfile : Profile
    {
        public UserAutoMapperProfile()
        {
            CreateMap<CreateUserDto, Module.Users>();
            CreateMap<Module.Users, UserDto>()
                .ForMember(x => x.Role, x => x.MapFrom(o => o.Role.ToString()));
        }
    }
}
