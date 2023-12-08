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
    /// 图书查询窗体
    /// </summary>
    public partial class FrmBookInfoSearch : UIForm
    {
        /// <summary>
        /// 业务逻辑层:作者变量
        /// </summary>
        private readonly AuthorBLL authorBll = new AuthorBLL();
        private readonly BookInfoBLL bookInfoBll = new BookInfoBLL();
        private readonly PublishHouseBLL publishBll = new PublishHouseBLL();
        private readonly BookTypeBLL bookTypeBll = new BookTypeBLL();
        public FrmBookInfoSearch()
        {
            InitializeComponent();
        }


        #region 页面加载
        private void FrmBookInfoSearch_Load(object sender, EventArgs e)
        {
            LoadSearchType();
        }
        #endregion

        #region 查询事件

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            LoadSearchBookInfo();
        }

        #endregion

        #region 查询图书

        private void LoadSearchBookInfo()
        {
            DgvBookInfo.Rows.Clear();
            List<BookInfo> lst = bookInfoBll.GetBookInfos(1);
            for (int i = 0; i < lst.Count; i++)
            {
                DgvBookInfo.Rows.Add();
                DgvBookInfo["BookId", i].Value = lst[i].BookId;
                DgvBookInfo["BookName", i].Value = lst[i].BookName;
                //DgvBookInfo["CoverImage", i].Value = lst[i].ConvrImage;
                DgvBookInfo["BookNumber", i].Value = lst[i].BookNumber;
                DgvBookInfo["PublishName", i].Value = publishBll.GetPublishHouseById(lst[i].BookId).PublishName;
                DgvBookInfo["PublishDate", i].Value = lst[i].PublishDate;
                DgvBookInfo["BookTypeName", i].Value = bookTypeBll.GetBookTypeById(lst[i].BookTypeId).BookTypeName;
                DgvBookInfo["AuthorName", i].Value = authorBll.GetAuthorById(lst[i].AuthorId).AuthorName;
                DgvBookInfo["BookPrice", i].Value = lst[i].BookPrice;
                DgvBookInfo["InputName", i].Value = lst[i].InputName;
                DgvBookInfo["BorrowCount", i].Value = lst[i].BorrowCount;
                DgvBookInfo["TotalCount", i].Value = lst[i].TotalCount;
                DgvBookInfo["BookSamry", i].Value = lst[i].BookSamry;
            }

        }

        #endregion

        #region 加载查询方式
        private void LoadSearchType()
        {

            CboSearchType.SelectedIndex = 0;
        }
        #endregion

        #region 关闭窗体
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion


    }
}
