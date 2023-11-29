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
    /// 作者信息列表窗体
    /// </summary>
    public partial class FrmAuthorList : UIForm
    {
        /// <summary>
        /// 业务逻辑层:作者变量
        /// </summary>
        private readonly PublishHouseBLL bll = new PublishHouseBLL();
        public FrmAuthorList()
        {
            InitializeComponent();
        }

        #region 窗体加载
        private void FrmAuthorList_Load(object sender, EventArgs e)
        {
            LoadPublishHouse();
        }
        #endregion

        #region DataGrid加载数据
        private void LoadPublishHouse()
        {
            DgvAuthor.DataSource = bll.GetPublishHouses();
        }
        #endregion


        #region 打开出版社窗体
        /// <summary>
        /// 打开出版社窗体
        /// </summary>
        /// <param name="iReaderType"></param>
        private void ShowForm(int iReaderType)
        {
            FrmPublishAdd frm = SingleForm<FrmPublishAdd>.CreateInstance();

            frm.MdiParent = MdiParent;
            frm.Tag = new FormInfoModel
            {
                KeyId = iReaderType,
                ReloadData = LoadPublishHouse // 某个函数(加载Dgv数据的)
            };

            frm.Show();
        }
        #endregion


        #region 执行删除
        /// <summary>
        /// 执行删除
        /// </summary>
        /// <param name="iBookTypeId">出版社ID</param>
        private void DelPublishHouse(int id)
        {
            if (DialogResult.No == CommMsgBox.YesNoConfirm(CommConst.IsDeleteData))
                return;

            bool res = bll.DeletePublishHouse(id);
            if (res)
            {
                CommMsgBox.MsgBox(CommConst.DeleteDataSuccess);
                LoadPublishHouse();
            }
            else
            {
                CommMsgBox.MsgBoxCaveat(CommConst.DeleteDataFail);
            }

        }
        #endregion

        #region 新增操作
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            ShowForm(0);
        }
        #endregion

        #region 关闭窗体
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region DataGrid列表操作
        private void DgvAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 获取行
            int row = e.RowIndex;
            // 获取列
            int col = e.ColumnIndex;
            PublishHouse type = DgvAuthor.Rows[row].DataBoundItem as PublishHouse;
            if (!(DgvAuthor.Rows[row].Cells[col] is DataGridViewLinkCell linkCell))
                return;
            // 拿到单元格的值
            string cellValue = linkCell.FormattedValue.ToString();

            switch (cellValue)
            {
                case CommConst.CharUpdate:
                    ShowForm(type.PublishId); break;
                case CommConst.CharDelete:
                    //删除
                    DelPublishHouse(type.PublishId);
                    break;
                default:
                    break;
            }
        }
        #endregion
    }

}
