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
using JokerBooksManagerComm.Comm;
using JokerBooksManagerModels.Model;
using Sunny.UI;


namespace JokerBooksManager.Managers
{
    public partial class FrmReaderInfoList : UIForm
    {
        private ReaderInfoBLL bll = new ReaderInfoBLL();

        public FrmReaderInfoList()
        {
            InitializeComponent();
            DgvReaderInfoList.AutoGenerateColumns = false;
        }

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
            FrmReaderInfoAdd frmReaderInfoAdd = SingleForm<FrmReaderInfoAdd>.CreateInstance();
            frmReaderInfoAdd.MdiParent = MdiParent;
            frmReaderInfoAdd.Show();
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

            frmReaderInfoAdd.Show();
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
