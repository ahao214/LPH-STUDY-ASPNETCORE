﻿using System;
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
using Sunny.UI;


namespace JokerBooksManager.Managers
{
    public partial class FrmMain : UIForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 密码修改事件

        /// <summary>
        /// 密码修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiPassModify_Click(object sender, EventArgs e)
        {
            FrmPassModify frmPassModify = new FrmPassModify();
            frmPassModify.ShowDialog();
        }

        #endregion

        #region 退出系统事件

        /// <summary>
        /// 退出系统事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmsiExitSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region 关闭窗体

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = CommMsgBox.YesNoConfirm(CommConst.QuitSystem);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }

        #endregion
    }
}
