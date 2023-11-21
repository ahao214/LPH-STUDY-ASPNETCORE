using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerBooksManagerComm.Comm
{
    public enum BookCommandType
    {
        /// <summary>
        /// SQL文本命令
        /// </summary>
        Text = 1,
        /// <summary>
        /// 存储过程
        /// </summary>
        StoredProcedure = 2,
        /// <summary>
        /// 表或者视图
        /// </summary>
        TableDirect = 3

    }
}
