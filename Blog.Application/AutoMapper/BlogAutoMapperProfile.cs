using AutoMapper;
using Blog.Application.Contract.Blogs.Dto;
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
            CreateMap<CreateBlogsDto, Module.Blogs>().ReverseMap();

            CreateMap<CreateBlogTypesDto, Module.BlogTypes>();

            CreateMap<BlogTypeDto, Module.BlogTypes>()
                .ReverseMap();  // 双向配置
        }

    }
}
