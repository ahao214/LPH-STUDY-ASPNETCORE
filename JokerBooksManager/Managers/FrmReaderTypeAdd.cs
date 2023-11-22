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
    /// <summary>
    /// 新增或者修改读者类别窗体
    /// </summary>
    public partial class FrmReaderTypeAdd : UIForm
    {
        public FrmReaderTypeAdd()
        {
            InitializeComponent();
        }

        #region 新增读者类别
        /// <summary>
        /// 新增读者类别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOk_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 关闭窗口
        private void BtnClose_Click(object sender, EventArgs e)
        {
            
        } 
        #endregion
    }
}
