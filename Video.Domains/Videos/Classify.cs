using System;
using System.Collections.Generic;
using System.Text;

namespace Video.Domains
{
    /// <summary>
    /// 分类表
    /// </summary>
    public class Classify
    {
        /// <summary>
        /// 编号
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string? Name { get; set; }


    }
}
