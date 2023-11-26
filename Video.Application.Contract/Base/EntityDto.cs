using System;
using System.Collections.Generic;
using System.Text;

namespace Video.Application.Contract.Base
{
    public class EntityDto
    {
        /// <summary>
        /// 编号
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
