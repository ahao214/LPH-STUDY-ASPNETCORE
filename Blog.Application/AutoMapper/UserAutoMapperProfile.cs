using AutoMapper;
using Blog.Application.Contract.Blogs.Dto;
using Blog.Application.Contract.User.Dto;


namespace Blog.Application.AutoMapper
{
    public class UserAutoMapperProfile : Profile
    {
        public UserAutoMapperProfile()
        {
            CreateMap<CreateUserDto, Module.Users>();
            CreateMap<Module.Users, UserDto>()
                .ForMember(x => x.Role, x => x.MapFrom(o => o.Role.ToString()));

            CreateMap<Module.Users, BlogUserDto>();
        }
    }
}
