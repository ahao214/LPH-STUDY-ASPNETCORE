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




namespace JokerBooksManager
{
    public partial class FrmLogin : UIForm
    {
        private string checkCode = string.Empty;
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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!IsCheckCode())
            {
                return;
            }
        }

        public bool IsCheckCode()
        {
            if (!TxtVerifyCode.Text.Trim().Equals(checkCode))
            {
                MessageBox.Show("错误");
                return false;
            }
            return true;
        }

        /// <summary>
        /// 退出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
