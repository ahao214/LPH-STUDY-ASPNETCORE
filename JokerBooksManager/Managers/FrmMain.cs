using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;


namespace JokerBooksManager.Managers
{
    public partial class FrmMain : UIForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

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
    }
}
