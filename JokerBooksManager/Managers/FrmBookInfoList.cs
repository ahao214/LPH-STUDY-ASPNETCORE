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
    /// 图书信息窗体
    /// </summary>
    public partial class FrmBookInfoList : UIForm
    {

        #region 构造函数
        public FrmBookInfoList()
        {
            InitializeComponent();
        } 
        #endregion

        #region 新增
        private void BtnAddNew_Click(object sender, EventArgs e)
        {

        }

        #endregion
        #region 关闭窗体
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region DataGrid列表操作
        private void DgvBookInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
    }
}
