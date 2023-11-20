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

        private void InitialVerityCode()
        {
            VerifyCode verifyCode = new VerifyCode
            {
                CodeCount = 5
            };
            verifyCode.CreateVerifyCode();
        }


        #endregion

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
