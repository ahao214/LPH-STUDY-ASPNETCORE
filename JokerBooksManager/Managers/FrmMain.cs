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
using Sunny.UI;


namespace JokerBooksManager.Managers
{
    /// <summary>
    /// 主窗体界面
    /// </summary>
    public partial class FrmMain : UIForm
    {
        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        #endregion

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

        #region 窗体加载

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadInfo();              
        }

        #endregion

        #region 加载状态栏指定信息

        /// <summary>
        /// 加载状态栏指定信息
        /// </summary>
        private void LoadInfo()
        {
            TsslLoginName.Text = UserInfo.LoginName;
            TsslTime.Text = "时间：" + DateTime.Now.ToString();
        }

        #endregion
    }
}
