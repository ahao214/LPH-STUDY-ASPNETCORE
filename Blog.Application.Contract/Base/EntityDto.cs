using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contract.Base
{
    public class EntityDto
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
    }
}
