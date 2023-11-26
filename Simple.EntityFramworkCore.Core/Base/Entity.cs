using System;
using System.Collections.Generic;
using System.Text;

namespace Simple.EntityFramworkCore.Core.Base
{
    public class Entity
    {
        /// <summary>
        /// 主键
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedTime { get; set; }


    }
}
