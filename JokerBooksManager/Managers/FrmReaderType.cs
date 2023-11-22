using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JokerBooksManagerModels.Model;
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
            frmReaderTypeAdd.Tag = new FormInfoModel
            {
                KeyId = iReaderType,
                ReloadData = null // 某个函数(加载Dgv数据的)
            };

            frmReaderTypeAdd.Show();
        }
        #endregion

        #region 关闭窗体
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
