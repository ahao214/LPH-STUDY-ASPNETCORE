using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Demo.Domain.Model
{
    /// <summary>
    /// 模型基础类
    /// </summary>
    public class ModelBase
    {

        /// <summary>
        /// 是否操作成功
        /// </summary>
        public bool Success { get; set; } = false;

    }
}
