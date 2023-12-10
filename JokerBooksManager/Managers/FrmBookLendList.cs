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
    /// 图书借书窗体
    /// </summary>
    public partial class FrmBookLendList : UIForm
    {
        /// <summary>
        /// 业务逻辑层
        /// </summary>
        private readonly AuthorBLL authorBll = new AuthorBLL();
        private readonly BookInfoBLL bookInfoBll = new BookInfoBLL();
        private readonly PublishHouseBLL publishBll = new PublishHouseBLL();
        private readonly BookTypeBLL bookTypeBll = new BookTypeBLL();
        private readonly BorrowBookBLL borrowBookBLL = new BorrowBookBLL(); 
        /// <summary>
        /// 业务逻辑层图书翻页变量
        /// </summary>
        private PageSet<BorrowBook> pageSet = null;
        /// <summary>
        /// 每页显示的条数
        /// </summary>
        private const int pageSize = 2;


        public FrmBookLendList()
        {
            InitializeComponent();
        }

        #region 关闭当前窗体
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                ReloadData = InitailPageSet   // 自定义函数
            };
            frmBookInfoAdd.Show();
        }


        #endregion

        #region 绑定图书信息到DataGrid

        private void LoadBookInfo(List<BorrowBook> _borrowBooks)
        {
            DgvBorrowBook.Rows.Clear();
            List<BorrowBook> lst = _borrowBooks;
            for (int i = 0; i < lst.Count; i++)
            {
                DgvBorrowBook.Rows.Add();
                DgvBorrowBook["BorrowId", i].Value = lst[i].BorrowId;
                DgvBorrowBook["BookId", i].Value = lst[i].BookId;
                //DgvBorrowBook["BookName", i].Value = lst[i].BookName;
                //DgvBorrowBook["BookNumber", i].Value = lst[i].BookNumber;
                //DgvBorrowBook["PublishName", i].Value = publishBll.GetPublishHouseById(lst[i].BookId).PublishName;
                //DgvBorrowBook["PublishDate", i].Value = lst[i].PublishDate;
                //DgvBorrowBook["BookTypeName", i].Value = bookTypeBll.GetBookTypeById(lst[i].BookTypeId).BookTypeName;
                //DgvBorrowBook["AuthorName", i].Value = authorBll.GetAuthorById(lst[i].AuthorId).AuthorName;
                
            }

        }
        #endregion

       

        #region 获取所有图书

        //private PageSet<> GetBooks()
        //{
        //    int bookTypeId = 0;
        //    BookType bookType = Tag as BookType;
        //    if (bookType != null)
        //    {
        //        bookTypeId = bookType.BookTypeId;
        //    }
        //    pageSet = bookInfoBll.GetAllBooks(bookTypeId, pageSize);
        //    return pageSet;
        //}

        #endregion


        #region 初始化页面记载的数据
        private void InitailPageSet()
        {
            //pageSet = GetBooks();
            //LoadBookInfo(pageSet.FirstPage());
            LblPageCount.Text = pageSet.PageCount.ToString();
        }
        #endregion

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
            //LoadBookInfo(pageSet.FirstPage());
        }
        #endregion

       

        #region 

        private void SetLablePage()
        {
            LblPage.Text = pageSet.nowPage.ToString();
        }

        #endregion

        #region 绑定图书信息到DataGrid

        private void DgvBorrowBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 获取行
            int row = e.RowIndex;
            // 获取列
            int col = e.ColumnIndex;
            int bookId = DgvBorrowBook["BookId", row].Value.ChangeInt();

            //BookInfo bookInfo = DgvBookInfo.Rows[row].DataBoundItem as BookInfo;
            if (!(DgvBorrowBook.Rows[row].Cells[col] is DataGridViewLinkCell linkCell))
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
    }
}
