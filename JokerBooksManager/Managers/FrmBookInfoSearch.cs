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
    /// 图书查询窗体
    /// </summary>
    public partial class FrmBookInfoSearch : UIForm
    {
        public FrmBookInfoSearch()
        {
            InitializeComponent();
        }




        #region 关闭窗体
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        } 
        #endregion
    }
}
