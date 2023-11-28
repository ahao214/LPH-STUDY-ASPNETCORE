using NSwag.Annotations;
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
    public class PageInput
    {
        private int? _page = 1;
        private int? _pageSize = 20;


        /// <summary>
        /// 当前页
        /// </summary>
        public int? Page
        {
            get => _page;
            set => _page = value is null or <= 0 ? 1 : value;
        }
        /// <summary>
        /// 每页的数量
        /// </summary>
        public int? PageSize
        {
            get => _pageSize;
            set => _pageSize = value is null or <= 0 ? 1 : value;
        }
        /// <summary>
        /// 忽略 只传Page 和PageSize
        /// </summary>
        [OpenApiIgnore]
        public new int SkipCount => (Page!.Value - 1) * MaxResultCount;

        [OpenApiIgnore]
        public new int MaxResultCount => PageSize!.Value > 1000 ?
            1000
            : PageSize!.Value;

    }
}
