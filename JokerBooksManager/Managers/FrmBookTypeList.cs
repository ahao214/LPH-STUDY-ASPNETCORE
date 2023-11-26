using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JokerBooksManager.Comm;
using JokerBooksManagerBLL.BookBLL;
using JokerBooksManagerComm.Comm;
using JokerBooksManagerModels.Model;
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
            ShowForm(0);
        }

        #endregion

        #region 打开图书类别窗体
        /// <summary>
        /// 打开图书类别窗体
        /// </summary>
        /// <param name="iReaderType"></param>
        private void ShowForm(int iReaderType)
        {
            FrmBookTypeAdd frm = SingleForm<FrmBookTypeAdd>.CreateInstance();

            frm.MdiParent = MdiParent;
            frm.Tag = new FormInfoModel
            {
                KeyId = iReaderType,
                ReloadData = LoadBookType // 某个函数(加载Dgv数据的)
            };

            frm.Show();
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

        private void DgvBookType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 获取行
            int row = e.RowIndex;
            // 获取列
            int col = e.ColumnIndex;
            BookType type = DgvBookType.Rows[row].DataBoundItem as BookType;
            if (!(DgvBookType.Rows[row].Cells[col] is DataGridViewLinkCell linkCell))
                return;
            // 拿到单元格的值
            string cellValue = linkCell.FormattedValue.ToString();
     
            switch (cellValue)
            {
                case CommConst.CharUpdate:
                    ShowForm(type.BookTypeId); break;
                case CommConst.CharDelete:
                    //删除
                    DelBookType(type.BookTypeId);
                    break;
                default:
                    break;
            }
        }


        #region 执行删除
        /// <summary>
        /// 执行删除
        /// </summary>
        /// <param name="iReaderTypeId"></param>
        private void DelBookType(int iReaderTypeId)
        {
            if (DialogResult.No == CommMsgBox.YesNoConfirm(CommConst.IsDeleteData))
                return;

            bool res = bll.DeleteReaderType(iReaderTypeId);
            if (res)
            {
                CommMsgBox.MsgBox(CommConst.DeleteDataSuccess);
            }
            else
            {
                CommMsgBox.MsgBoxCaveat(CommConst.DeleteDataFail);
            }

        }
        #endregion
    }
}
