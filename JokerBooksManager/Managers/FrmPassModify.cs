using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JokerBooksManager.Comm;
using JokerBooksManagerComm.Comm;
using JokerBooksManagerModels.Model;
using JokerBooksManagerBLL.BookBLL;
using Sunny.UI;

namespace JokerBooksManager.Managers
{
    /// <summary>
    /// 密码修改窗体
    /// </summary>
    public partial class FrmPassModify : UIForm
    {
        public FrmPassModify()
        {
            InitializeComponent();

            // 1 先判断原始密码是否正确
            // 2 进行数据库密码的更新(根据用户的ID)


        }

        #region 点击确定事件

        /// <summary>
        /// 点击确定事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOk_Click(object sender, EventArgs e)
        {
            string oldPass = CommDefine.GetMD5Hash(TxtOldPass.Text.Trim());
            string newPass = TxtNewPass.Text.Trim();
            string rePass = TxtRePass.Text.Trim();
            if (!CheckPass(oldPass))
                return;
            if (!CheckInput(newPass, rePass))
                return;
            UpdatePwd(newPass);
        }

        #endregion

        #region 检验原始密码是否正确

        /// <summary>
        /// 检验原始密码是否正确
        /// </summary>
        /// <param name="oldPass">密码</param>
        /// <returns>True：正确 False：错误</returns>
        private bool CheckPass(string oldPass)
        {
            if (!oldPass.Equals(UserInfo.LoginPass))
            {
                CommMsgBox.MsgBoxCaveat(CommConst.OldPassFalse);
                return false;
            }
            return true;
        }

        #endregion

        #region 检验两次密码输入是否一致

        /// <summary>
        /// 检验两次密码输入是否一致
        /// </summary>
        /// <param name="newPass">新密码</param>
        /// <param name="rePass">再次输入的新密码</param>
        /// <returns>True：正确 False：错误</returns>
        private bool CheckInput(string newPass, string rePass)
        {
            if (newPass.Length == 0 || string.IsNullOrEmpty(newPass))
            {
                CommMsgBox.MsgBoxCaveat(CommConst.InputFail);
                return false;
            }
            if (!newPass.Equals(rePass))
            {
                CommMsgBox.MsgBoxCaveat(CommConst.RePassFalse);
                return false;
            }
            return true;
        }

        #endregion

        #region 更新密码

        /// <summary>
        /// 更新密码
        /// </summary>
        /// <param name="newPwd">新密码</param>
        private void UpdatePwd(string newPwd)
        {
            ManagerBLL bll = new ManagerBLL();
            Manager manager = new Manager()
            {
                Id = UserInfo.Id,
                LoginPass = CommDefine.GetMD5Hash(newPwd)
            };
            int res = bll.UpdatePassById(manager);
            if (res > 0)
            {
                CommMsgBox.MsgBox(CommConst.UpdatePwdTrue);
            }
            else
            {
                CommMsgBox.MsgBox(CommConst.UpdatePwdFalse);
            }
            Close();
        }

        #endregion
    }
}
