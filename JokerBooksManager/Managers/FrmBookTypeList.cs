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
using Sunny.UI;


namespace JokerBooksManager.Managers
{
    public partial class FrmBookTypeList : UIForm
    {
        private readonly BookTypeBLL bll = new BookTypeBLL();

        public FrmBookTypeList()
        {
            InitializeComponent();
        }



        #region 新增图书类别
        private void BtnAddNew_Click(object sender, EventArgs e)
        {

        }

        #endregion



        #region 窗体加载

        private void FrmBookTypeList_Load(object sender, EventArgs e)
        {
            LoadBookType();
        }

        #endregion

        #region DataGrid加载数据
        private void  LoadBookType()
        {
            DgvBookType.DataSource = bll.GetBookTypes();

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
