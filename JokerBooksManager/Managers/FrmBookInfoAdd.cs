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
    /// 添加图书信息窗体
    /// </summary>
    public partial class FrmBookInfoAdd : UIForm
    {
        #region 构造函数

        public FrmBookInfoAdd()
        {
            InitializeComponent();
        }

        #endregion


        #region 浏览添加图片

        /// <summary>
        /// 浏览添加图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFileBrowse_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
