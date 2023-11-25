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
    /// 读者信息列表窗体
    /// </summary>
    public partial class FrmReaderInfoList : UIForm
    {
        private ReaderInfoBLL bll = new ReaderInfoBLL();

        public FrmReaderInfoList()
        {
            InitializeComponent();
            DgvReaderInfoList.AutoGenerateColumns = false;
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReaderInfoList_Load(object sender, EventArgs e)
        {
            LoadReaderInfo();
        }


        #region 绑定数据到Dgv

        /// <summary>
        /// 绑定数据到Dgv
        /// </summary>
        private void LoadReaderInfo()
        {
            DgvReaderInfoList.DataSource = bll.GetReaderInfos();
        }

        #endregion

        #region 添加读者信息

        /// <summary>
        /// 添加读者信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            ShowForm(0);
        }

        #endregion

        #region 打开添加或修改读者信息的窗体
        /// <summary>
        /// 打开添加或修改读者信息的窗体
        /// </summary>
        /// <param name="iReaderId">读者ID</param>
        private void ShowForm(int iReaderId)
        {
            FrmReaderInfoAdd frmReaderInfoAdd = SingleForm<FrmReaderInfoAdd>.CreateInstance();
            frmReaderInfoAdd.MdiParent = MdiParent;
            frmReaderInfoAdd.Tag = new FormInfoModel
            {
                KeyId = iReaderId,
                ReloadData = LoadReaderInfo
            };
            if (iReaderId > 0)
            {
                frmReaderInfoAdd.Text = "修改读者信息";
            }
            frmReaderInfoAdd.Show();
        }

        #endregion


        #region 关闭窗体
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region 单击单元格内容事件

        /// <summary>
        /// 单击单元格内容事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvReaderInfoList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;
            ReaderInfo readerInfo = DgvReaderInfoList.Rows[iRow].DataBoundItem as ReaderInfo;
            if (!(DgvReaderInfoList.Rows[iRow].Cells[iCol] is DataGridViewLinkCell linkCell))
                return;
            string cellValue = linkCell.FormattedValue.ToString();
            switch (cellValue)
            {
                case "修改":
                    ShowForm(readerInfo.ReaderId);
                    break;
                case "删除":
                    DeleteData(readerInfo);
                    break;
            }


        }
        #endregion

        #region
        /// <summary>
        /// 删除读者信息
        /// </summary>
        /// <param name="readerInfo"></param>
        private void DeleteData(ReaderInfo readerInfo)
        {
            bool res = bll.DeleteReaderInfo(readerInfo);
            if (res)
            {
                CommMsgBox.MsgBoxCaveat(CommConst.DeleteDataSuccess);
            }
            else
            {
                CommMsgBox.MsgBoxCaveat(CommConst.DeleteDataFail);
            }
            LoadReaderInfo();
        }

        #endregion
    }
}
