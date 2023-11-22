using JokerBooksManagerComm.Comm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JokerBooksManagerComm.Comm;





namespace JokerBooksManager.Comm
{

    public class CommMsgBox : CommConst
    {
        #region 执行成功后的信息提示对话框

        /// <summary>
        /// 执行成功后的信息提示对话框
        /// </summary>
        /// <param name="sMsg">信息内容</param>
        /// <returns></returns>
        public static DialogResult MsgBox(string sMsg)
        {
            return MessageBox.Show(sMsg, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion


        #region 执行有警告后的信息提示对话框

        /// <summary>
        /// 执行有警告后的信息提示对话框
        /// </summary>
        /// <param name="sMsg">信息内容</param>
        /// <returns></returns>
        public static DialogResult MsgBoxCaveat(string sMsg)
        {
            return MessageBox.Show(sMsg, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion


        #region 执行有严重错误后的信息提示对话框

        /// <summary>
        /// 执行有严重错误后的信息提示对话框
        /// </summary>
        /// <param name="sMsg">信息内容</param>
        /// <returns>返回DialogResult</returns>
        public static DialogResult MsgBoxError(string sMsg)
        {
            return MessageBox.Show(sMsg, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region 执行确认信息对话框

        /// <summary>
        /// 执行确认信息对话框
        /// </summary>
        /// <param name="sMsg">信息内容</param>
        /// <returns>返回DialogResult</returns>
        public static DialogResult YesNoConfirm(string sMsg)
        {
            return MessageBox.Show(sMsg, Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        #endregion

        #region 执行确认信息对话框

        /// <summary>
        /// 执行确认信息对话框
        /// </summary>
        /// <param name="sMsg">信息内容</param>
        /// <returns>返回DialogResult</returns>
        public static DialogResult OKCancelConfirm(string sMsg)
        {
            return MessageBox.Show(sMsg, Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        #endregion
    }
}
