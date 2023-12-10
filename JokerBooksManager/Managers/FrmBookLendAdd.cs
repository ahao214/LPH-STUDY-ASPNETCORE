using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JokerBooksManagerBLL.BookBLL;
using JokerBooksManagerModels.Model;
using Sunny.UI;

namespace JokerBooksManager.Managers
{
    /// <summary>
    /// 图书借阅窗体
    /// </summary>
    public partial class FrmBookLendAdd : UIForm
    {

        #region 业务逻辑层BLL
        
        private readonly ReaderInfoBLL readerInfoBLL = new ReaderInfoBLL();

        #endregion

        #region

        private ReaderInfo readerInfo = new ReaderInfo();

        #endregion

        public FrmBookLendAdd()
        {
            InitializeComponent();
        }

        #region 关闭当前窗体
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region 获取读者信息
        
        private void BtnSearchReader_Click(object sender, EventArgs e)
        {
            readerInfo = readerInfoBLL.GetReaderInfoByKeyWords(this.TxtKeys.Text.Trim());
        } 

        #endregion
    }
}
