using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerBooksManagerComm.Comm
{
    /// <summary>
    /// 抽象常量类
    /// </summary>
    public abstract class CommConst
    {
        #region 验证码字符串

        /// <summary>
        /// 验证码字符串
        /// </summary>
        protected const string AllChar = "QWERTYUIOPASDFGHJKLZXCVBNM0123456789";

        #endregion

        #region 验证码的位数

        /// <summary>
        /// 验证码的位数
        /// </summary>
        protected const int CodeCounts = 5;

        #endregion

        #region 验证码位图的宽度和高度

        /// <summary>
        /// 宽度
        /// </summary>
        protected const int BitMapW = 84;
        /// <summary>
        /// 高度
        /// </summary>
        protected const int BitMapH = 28;

        #endregion
    }
}
