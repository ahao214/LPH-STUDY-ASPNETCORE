using System;
using System.Collections.Generic;
using System.Text;

namespace Video.Application.Contract.Base
{
    /// <summary>
    /// 
    /// </summary>
    public class PageResultDto<T>
    {
        public IReadOnlyList<T> Items { get; set; }

        public int Count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <param name="items"></param>
        public PageResultDto(int count, IReadOnlyList<T> items)
        {
            Items = items;
            Count = count;
        }

    }

}
