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
    /// <summary>
    /// 图书信息窗体
    /// </summary>
    public partial class FrmBookInfoList : UIForm
    {
        /// <summary>
        /// 业务逻辑层:作者变量
        /// </summary>
        private readonly AuthorBLL bll = new AuthorBLL();

        #region 构造函数
        public FrmBookInfoList()
        {
            InitializeComponent();
        } 
        #endregion

        #region 新增
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            ShowForm(0);
        }

        #endregion

        #region 打开新增或者修改窗体

        private void ShowForm(int id)
        {
            FrmBookInfoAdd frmBookInfoAdd = SingleForm<FrmBookInfoAdd>.CreateInstance();
            frmBookInfoAdd.MdiParent = MdiParent;
            frmBookInfoAdd.Tag = new FormInfoModel
            {
                KeyId = id,
                ReloadData = LoadBookInfo   // 自定义函数
            };
            frmBookInfoAdd.Show();
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
            // 获取行
            int row = e.RowIndex;
            // 获取列
            int col = e.ColumnIndex;
            Author author = DgvBookInfo.Rows[row].DataBoundItem as Author;
            if (!(DgvBookInfo.Rows[row].Cells[col] is DataGridViewLinkCell linkCell))
                return;
            // 拿到单元格的值
            string cellValue = linkCell.FormattedValue.ToString();

            switch (cellValue)
            {
                case CommConst.CharUpdate:
                    ShowForm(author.AuthorId); break;
                case CommConst.CharDelete:
                    //删除
                    DelAuthor(author.AuthorId);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region 窗体加载
        private void FrmBookInfoList_Load(object sender, EventArgs e)
        {
            LoadBookInfo();
        }
        #endregion

        #region 绑定图书信息到DataGrid

        private void LoadBookInfo()
        {
            DgvBookInfo.DataSource = bll.GetAuthors();
        }
        #endregion

        #region 执行删除
        /// <summary>
        /// 执行删除
        /// </summary>
        /// <param name="id">作者ID</param>
        private void DelAuthor(int id)
        {
            if (DialogResult.No == CommMsgBox.YesNoConfirm(CommConst.IsDeleteData))
                return;

            bool res = bll.DeleteAuthor(id);
            if (res)
            {
                CommMsgBox.MsgBox(CommConst.DeleteDataSuccess);
                LoadBookInfo();
            }
            else
            {
                CommMsgBox.MsgBoxCaveat(CommConst.DeleteDataFail);
            }

        }
        #endregion
    }
}
