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
    public partial class FrmReaderType : UIForm
    {
        private readonly ReaderTypeBLL bll = new ReaderTypeBLL();
        public FrmReaderType()
        {
            InitializeComponent();
        }


        #region 打开新增或者修改窗体
        /// <summary>
        /// 打开新增或者修改窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            ShowForm(0);
        }
        #endregion

        #region 打开读者类别窗体
        /// <summary>
        /// 打开读者类别窗体
        /// </summary>
        /// <param name="iReaderType"></param>
        private void ShowForm(int iReaderType)
        {
            FrmReaderTypeAdd frmReaderTypeAdd = SingleForm<FrmReaderTypeAdd>.CreateInstance();
            frmReaderTypeAdd.MdiParent = MdiParent;            
            frmReaderTypeAdd.Tag = new FormInfoModel
            {
                KeyId = iReaderType,
                ReloadData = LoadReaderType // 某个函数(加载Dgv数据的)
            };

            frmReaderTypeAdd.Show();
        }
        #endregion


        #region 绑定读者信息

        private void LoadReaderType()
        {
            DgvReaderType.DataSource = bll.GetReaderTypes();
        }

        #endregion 


        #region 关闭窗体
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 窗体加载
        private void FrmReaderType_Load(object sender, EventArgs e)
        {
            LoadReaderType();  //绑定读者类别信息
        }
        #endregion

        #region 单击单元格内容事件
        /// <summary>
        /// 单击单元格内容事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvReaderType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 获取行
            int row = e.RowIndex;
            // 获取列
            int col = e.ColumnIndex;
            ReaderType type = DgvReaderType.Rows[row].DataBoundItem as ReaderType;
            if (!(DgvReaderType.Rows[row].Cells[col] is DataGridViewLinkCell linkCell))
                return;
            // 拿到单元格的值
            string cellValue = linkCell.FormattedValue.ToString();
            // int readTypeId = DgvReaderType["ReadTypeId", row].Value.ChangeInt();
            switch (cellValue)
            {
                case CommConst.CharUpdate:
                    ShowForm(type.ReadTypeId); break;
                case CommConst.CharDelete:
                    //删除
                    DelReaderType(type.ReadTypeId);
                    break;
                default:
                    break;
            }


        }
        #endregion

        private void DelReaderType(int iReaderTypeId)
        {
            if (DialogResult.No == CommMsgBox.YesNoConfirm(CommConst.IsDeleteData))
                return;
        }
    }
}
