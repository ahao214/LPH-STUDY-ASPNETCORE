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


        #region 登录失败

        public const string LoginFail = "登录失败";

        #endregion

        #region 两次密码输入不一致

        public const string RePassFalse = "两次密码输入不一致";

        #endregion

        #region 原始密码不正确

        public const string OldPassFalse = "原始密码不正确";

        #endregion

        #region 密码更新成功

        public const string UpdatePwdTrue = "密码更新成功";

        #endregion

        #region 密码更新失败

        public const string UpdatePwdFalse = "密码更新失败";

        #endregion

        #region 您确定要退出系统吗

        public const string QuitSystem = "您确定要退出系统吗?";

        #endregion

        #region 改名称已经存在

        public const string IsExistsInfo = "名称已经存在";

        #endregion

        #region 新增成功

        public const string SaveDataSuccess = "新增成功";

        #endregion

        #region 新增失败

        public const string SaveDataFail = "新增失败";

        #endregion

        #region 更新成功

        public const string UpdateDataSuccess = "更新成功";

        #endregion


        #region 更新失败

        public const string UpdateDataFail = "更新失败";

        #endregion

        #region 删除成功

        public const string DeleteDataSuccess = "删除成功";

        #endregion


        #region 删除失败

        public const string DeleteDataFail = "删除失败";

        #endregion

        #region 修改

        public const string CharUpdate = "修改";

        #endregion

        #region 修改读者类别

        public const string CharUpdateReaderType = "修改读者类别";

        #endregion

        #region 修改图书类别

        public const string CharUpdateBookType = "修改图书类别";

        #endregion



        #region 删除字符

        public const string CharDelete = "删除";

        #endregion

        #region 你确定要删除数据吗

        public const string IsDeleteData = "你确定要删除数据吗？";

        #endregion

        #region 读者编码前缀字符

        public const string PrefixReaderNumber = "RU";

        #endregion


        #region 读者编码长度

        public const int ReaderNumberLen = 11;

        #endregion
    }
}
