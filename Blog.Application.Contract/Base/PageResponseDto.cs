using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contract.Base
{
    /// <summary>
    /// 分页模型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PageResponseDto<T>
    {
        public PageResponseDto()
        {
        }

        public int Total { get; set; }

        public IReadOnlyList<T> Items { get; set; }

        public PageResponseDto(int total, IReadOnlyList<T> items)
        {
            Total = total;
            Items = items;
        }
    }
}
