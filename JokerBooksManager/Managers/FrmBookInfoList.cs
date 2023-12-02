using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        }
        #endregion
    }
}
