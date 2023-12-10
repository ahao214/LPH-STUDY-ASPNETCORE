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
        /// 业务逻辑层
        /// </summary>
        private readonly AuthorBLL authorBll = new AuthorBLL();
        private readonly BookInfoBLL bookInfoBll = new BookInfoBLL();
        private readonly PublishHouseBLL publishBll = new PublishHouseBLL();
        private readonly BookTypeBLL bookTypeBll = new BookTypeBLL();
        /// <summary>
        /// 业务逻辑层图书翻页变量
        /// </summary>
        private PageSet<BookInfo> pageSet = null;
        /// <summary>
        /// 每页显示的条数
        /// </summary>
        private const int pageSize = 2;


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
                PageCount = LblPageCount.Text.ChangeInt(),
                //ReloadData = InitailPageSet   // 自定义函数
                RefreshData = InitailPageSet
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
            int bookId = DgvBookInfo["BookId", row].Value.ChangeInt();

            //BookInfo bookInfo = DgvBookInfo.Rows[row].DataBoundItem as BookInfo;
            if (!(DgvBookInfo.Rows[row].Cells[col] is DataGridViewLinkCell linkCell))
                return;
            // 拿到单元格的值
            string cellValue = linkCell.FormattedValue.ToString();

            switch (cellValue)
            {
                case CommConst.CharUpdate:
                    // 编辑图书信息
                    ShowForm(bookId); break;
                case CommConst.CharDelete:
                    // 删除图书信息
                    DelBookInfo(bookId);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region 窗体加载
        private void FrmBookInfoList_Load(object sender, EventArgs e)
        {
            InitailPageSet();
        }
        #endregion

        #region 绑定图书信息到DataGrid

        private void LoadBookInfo(List<BookInfo> _bookInfos)
        {
            DgvBookInfo.Rows.Clear();
            List<BookInfo> lst = _bookInfos;
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

        #region 获取所有图书

        private PageSet<BookInfo> GetBooks()
        {
            int bookTypeId = 0;
            BookType bookType = Tag as BookType;
            if (bookType != null)
            {
                bookTypeId = bookType.BookTypeId;
            }
            pageSet = bookInfoBll.GetAllBooks(bookTypeId, pageSize);
            return pageSet;
        }

        #endregion


        #region 初始化页面记载的数据
        private void InitailPageSet(int _pageCount)
        {
            pageSet = GetBooks();
            LoadBookInfo(pageSet.EndPage());
            LblPageCount.Text = _pageCount.ToString();
        }
        #endregion

        private void InitailPageSet()
        {
            pageSet = GetBooks();
            LoadBookInfo(pageSet.FirstPage());
            LblPageCount.Text = pageSet.PageCount.ToString();
        }

        #region 执行删除
        /// <summary>
        /// 执行删除
        /// </summary>
        /// <param name="id">作者ID</param>
        private void DelBookInfo(int id)
        {
            if (DialogResult.No == CommMsgBox.YesNoConfirm(CommConst.IsDeleteData))
                return;

            bool res = bookInfoBll.DeleteBookInfo(id);
            if (res)
            {
                CommMsgBox.MsgBox(CommConst.DeleteDataSuccess);
                InitailPageSet();
            }
            else
            {
                CommMsgBox.MsgBoxCaveat(CommConst.DeleteDataFail);
            }
            LoadBookInfo(pageSet.FirstPage());
        }
        #endregion

        #region 单击下一页事件
        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            LoadBookInfo(pageSet.NextPage());
            SetLablePage();
        }
        #endregion

        #region 单击首页事件
        private void BtnStartPage_Click(object sender, EventArgs e)
        {
            LoadBookInfo(pageSet.FirstPage());
            SetLablePage();
        }
        #endregion

        #region 上一页事件

        private void BtnPrevPage_Click(object sender, EventArgs e)
        {
            LoadBookInfo(pageSet.PrevPage());
            SetLablePage();
        }
        #endregion

        #region 尾页事件
        private void BtnEndPage_Click(object sender, EventArgs e)
        {
            LoadBookInfo(pageSet.EndPage());
            SetLablePage();
        }
        #endregion

        #region 

        private void SetLablePage()
        {
            LblPage.Text = pageSet.nowPage.ToString();
        }

        #endregion


    }
}
