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

        #region 验证码字体

        /// <summary>
        /// 验证码字体
        /// </summary>
        protected const string FtName = "微软雅黑";

        #endregion

        #region 验证码字体大小

        /// <summary>
        /// 验证码字体大小
        /// </summary>
        protected const int FtSize = 12;

        #endregion

        #region 对话框标题内容

        /// <summary>
        /// 对话框标题内容
        /// </summary>
        protected const string Caption = "信息提示";

        #endregion

        #region 验证码输入有误

        /// <summary>
        /// 验证码输入有误
        /// </summary>
        public const string VerifyErr = "验证码输入有误";

        #endregion

        #region 输入有误

        /// <summary>
        /// 输入有误
        /// </summary>
        public const string InputFail = "输入有误";

        #endregion

        #region 连接对象不能为空

        public const string ConnNotNull = "连接对象不能为空";

        #endregion
    }
}
