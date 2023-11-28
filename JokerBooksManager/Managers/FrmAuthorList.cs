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
    /// 作者信息列表窗体
    /// </summary>
    public partial class FrmAuthorList : UIForm
    {
        public FrmAuthorList()
        {
            InitializeComponent();
        }

        #region 窗体加载
        private void FrmAuthorList_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region 新增操作
        private void BtnAddNew_Click(object sender, EventArgs e)
        {

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
