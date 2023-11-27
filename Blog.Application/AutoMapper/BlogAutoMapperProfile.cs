using AutoMapper;
using Blog.Application.Contract.Blogs.Dto;
using Blog.Application.Contract.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.AutoMapper
{
    public class BlogAutoMapperProfile : Profile
    {
        public BlogAutoMapperProfile()
        {
            CreateMap<CreateBlogsDto, Module.Blogs>();
            //CreateMap<Module.Blogs, UserDto>()
            //    .ForMember(x => x.Role, x => x.MapFrom(o => o.Role.ToString()));
        }

    }
}
