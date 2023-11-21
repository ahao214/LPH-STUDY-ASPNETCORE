﻿using System;
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
using JokerBooksManager.Manager;
using System.Net;
using System.Web.UI.Design.WebControls;



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
            if (!IsCheckCode()) // 验证没有通过
            {
                return;
            }
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            Hide();
        }

        public bool IsCheckCode()
        {
            if (TxtLoginName.Text.Trim().Length == 0)
            {
                CommMsgBox.MsgBoxCaveat(CommConst.InputFail);
                return false;
            }
            if (TxtLoginPass.Text.Trim().Length == 0)
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

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
