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
    public partial class FrmReaderType : UIForm
    {
        public FrmReaderType()
        {
            InitializeComponent();
        }


        #region 打开新增或者修改窗体
        /// <summary>
        /// 打开新增或者修改窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            ShowForm(0);
        }
        #endregion

        #region 打开读者类别窗体
        /// <summary>
        /// 打开读者类别窗体
        /// </summary>
        /// <param name="iReaderType"></param>
        private void ShowForm(int iReaderType)
        {
            FrmReaderTypeAdd frmReaderTypeAdd = new FrmReaderTypeAdd
            {
                MdiParent = MdiParent
            };
            frmReaderTypeAdd.Show();
        } 
        #endregion
    }
}
