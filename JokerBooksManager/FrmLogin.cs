using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JokerBooksManagerComm.Comm;
using Sunny.UI;
using JokerBooksManager.Comm;
using System.Net;
using System.Web.UI.Design.WebControls;
using JokerBooksManager.Managers;
using JokerBooksManagerBLL.BookBLL;
using JokerBooksManagerModels.Model;



namespace JokerBooksManager
{
    public partial class FrmLogin : UIForm
    {
        #region 验证码初始值

        /// <summary>
        /// 验证码初始值
        /// </summary>
        private string checkCode = string.Empty;

        #endregion

        public FrmLogin()
        {
            InitializeComponent();
        }

        #region 窗体加载

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            InitialVerityCode();
        }

        /// <summary>
        /// 初始化验证码
        /// </summary>
        private void InitialVerityCode()
        {
            VerifyCode verifyCode = new VerifyCode
            {
                CodeCount = 5,
                FontSize = 8
            };
            PbVerfiyCode.Image = verifyCode.CreateVerifyCode();
            checkCode = verifyCode.CheckCode;
        }


        #endregion

        /// <summary>
        /// 登录事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!IsCheckCode(out string loginName, out string loginPass)) // 验证没有通过
            {
                return;
            }
            CheckLogin(loginName, loginPass);
        }

        #region 检验用户名和密码

        /// <summary>
        /// 检验用户名和密码
        /// </summary>
        /// <param name="loginName"></param>
        /// <param name="loginPass"></param>
        private void CheckLogin(string loginName, string loginPass)
        {
            ManagerBLL managerBLL = new ManagerBLL();
            Manager manager = managerBLL.GetManagerByNameAndPass(loginName, CommDefine.GetMD5Hash(loginPass));
            if (manager is null)
            {
                CommMsgBox.MsgBoxCaveat(CommConst.LoginFail);
                return;
            }

            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            Hide();
        }

        #endregion

        #region 验证码认证

        private bool IsCheckCode(out string loginName, out string loginPass)
        {
            loginName = TxtLoginName.Text.Trim();
            loginPass = TxtLoginPass.Text.Trim();
            if (loginName.Length == 0)
            {
                CommMsgBox.MsgBoxCaveat(CommConst.InputFail);
                return false;
            }
            if (loginPass.Length == 0)
            {
                CommMsgBox.MsgBoxCaveat(CommConst.InputFail);
                return false;
            }

            if (!TxtVerifyCode.Text.Trim().Equals(checkCode))
            {
                CommMsgBox.MsgBoxCaveat(CommConst.VerifyErr);
                return false;
            }
            return true;
        }

        #endregion

        #region 退出系统

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region 重新加载验证码

        /// <summary>
        /// 重新加载验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbVerfiyCode_Click(object sender, EventArgs e)
        {
            InitialVerityCode();
        }

        #endregion
    }
}
