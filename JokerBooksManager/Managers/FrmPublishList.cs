using System;
using System.Windows.Forms;
using JokerBooksManager.Comm;
using JokerBooksManagerBLL.BookBLL;
using JokerBooksManagerComm.Comm;
using JokerBooksManagerModels.Model;
using Sunny.UI;


namespace JokerBooksManager.Managers
{
    /// <summary>
    /// 出版社列表
    /// </summary>
    public partial class FrmPublishList : UIForm
    {        
        private readonly PublishHouseBLL bll = new PublishHouseBLL();
     
        public FrmPublishList()
        {
            InitializeComponent();
        }

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
                ReloadData = LoadBookType // 某个函数(加载Dgv数据的)
            };

            frm.Show();
        }
        #endregion


        

        #region DataGrid加载数据
        private void LoadBookType()
        {
            DgvPublishHouse.DataSource = bll.GetPublishHouses();
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
                LoadBookType();
            }
            else
            {
                CommMsgBox.MsgBoxCaveat(CommConst.DeleteDataFail);
            }

        }
        #endregion

        #region 窗体加载
        private void FrmPublishList_Load(object sender, EventArgs e)
        {
            LoadBookType();
        }



        #endregion

        private void DgvPublishHouse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 获取行
            int row = e.RowIndex;
            // 获取列
            int col = e.ColumnIndex;
            PublishHouse type = DgvPublishHouse.Rows[row].DataBoundItem as PublishHouse;
            if (!(DgvPublishHouse.Rows[row].Cells[col] is DataGridViewLinkCell linkCell))
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

        #region 关闭窗体
        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 新增出版社
        private void BtnAddNew_Click_1(object sender, EventArgs e)
        {
            ShowForm(0);
        } 
        #endregion


    }
}
