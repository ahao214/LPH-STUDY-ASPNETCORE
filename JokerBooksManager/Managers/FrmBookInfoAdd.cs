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
    /// 添加图书信息窗体
    /// </summary>
    public partial class FrmBookInfoAdd : UIForm
    {
        #region 图书字段变量

        private string sBookName;
        private string sBookNumber;
        private int iPublishId;
        private string sPublishDate;
        private int iBookTypeId;
        private int iAuthorId;
        private string sBookPrice;
        private int iTotalCount;
        private Image iConverImg;
        private string sBookSummary;

        #endregion


        #region 窗体共用Model变量
        /// <summary>
        /// 窗体共用Model变量
        /// </summary>
        private FormInfoModel formInfoModel = new FormInfoModel();
        #endregion

        #region 图书信息ID

        /// <summary>
        /// 图书ID
        /// </summary>
        private int bookId = 0;

        #endregion

        #region 构造函数

        public FrmBookInfoAdd()
        {
            InitializeComponent();
        }

        #endregion

        #region 浏览添加图片

        /// <summary>
        /// 浏览添加图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFileBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "图片文件|*.jpg;*.png;*.gif"
            };
            try
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    PbConvrImage.Image = Image.FromFile(fileDialog.FileName);
                }
            }
            catch (Exception err)
            {
                throw err;
            }

        }



        #endregion

        /// <summary>
        /// 存放原始的图书名字
        /// </summary>
        private string oldAuthorName = string.Empty;

        private AuthorBLL bll = new AuthorBLL();
        private BookInfoBLL bookBll = new BookInfoBLL();

        #region 窗体加载
        private void FrmBookInfoAdd_Load(object sender, EventArgs e)
        {
            InitialAddOrUpdate();
            CboBindData();
        }
        #endregion

        #region 初始化添加还是修改

        private void InitialAddOrUpdate()
        {
            if (!(Tag is null))
            {
                formInfoModel = Tag as FormInfoModel;
                if (!(formInfoModel is null))
                {
                    bookId = formInfoModel.KeyId;
                }
            }
            if (bookId > 0)
            {
                BookInfo bookInfo = bookBll.GetBookInfoById(bookId);
                if (bookInfo is null)
                    return;
                TxtBookName.Text = bookInfo.BookName;
                TxtBookNumber.Text = bookInfo.BookNumber;
                DpPublishDate.Text = bookInfo.PublishDate.ToString();
                TxtBookPrice.Text = bookInfo.BookPrice.ToString();
                TxtTotalCount.Text = bookInfo.TotalCount.ToString();
                TxtBookSamry.Text = bookInfo.BookSamry;
                PbConvrImage.Image = CommDefine.ByteToImage(bookInfo.ConvrImage);


                Text = CommConst.BookInfoCaption;
            }
            else
            {
                PbConvrImage.Image = null;
                TxtBookName.Clear();
                TxtBookNumber.Clear();
                DpPublishDate.Clear();
                TxtBookPrice.Clear();
                TxtTotalCount.Clear();
                TxtBookSamry.Clear();
                //foreach (Control item in GbCrls.Controls)
                //{
                //    if (item is UITextBox)
                //    {
                //        UITextBox txtBox = item as UITextBox;
                //        txtBox.Clear();
                //    }
                //}

            }
        }

        #endregion

        #region 绑定下拉框数据

        private void CboBindData()
        {
            CommDefine.PublishDataBind(CboPublishId);
            CommDefine.AuthorDataBind(CboAuthorId);
            CommDefine.BookTypeDataBind(CboBookTypeId);
            // 图书编码
            TxtBookNumber.Text = CommDefine.NumberPlusOne(CommConst.PrefixBookNumber, bookBll.GetBookNumber());

        }

        #endregion


        #region 添加或修改图书信息
        /// <summary>
        /// 添加或修改图书信息
        /// </summary>
        /// <param name="type"></param>
        private void AddOrUpdate(BookInfo bookInfo)
        {
            bool res;
            if (bookId == 0) // 添加
            {
                res = bookBll.AddBookInfo(bookInfo);
            }
            else // 修改
            {
                res = bookBll.UpdateBookInfo(bookInfo);
                res = false;
            }
            if (res)
            {
                CommMsgBox.MsgBox(CommConst.SaveDataSuccess);
                // 刷新
                formInfoModel.ReloadData?.Invoke();
                Close();
            }
            else
            {
                CommMsgBox.MsgBox(CommConst.SaveDataFail);
                Close();
            }
        }

        #endregion

        #region 验证图书名称是否存在
        /// <summary>
        /// 验证图书名称是否存在
        /// </summary>
        /// <param name="bookName">图书名称</param>
        /// <returns>True:存在 False：不存在</returns>
        private bool CheckBookName(string bookName)
        {
            if (bookId == 0 || (bookId > 0 && oldAuthorName != bookName))
            {
                if (bll.IsExistAuthor(bookName))
                {
                    CommMsgBox.MsgBoxCaveat(CommConst.IsExistsInfo);
                    return true;
                }
            }

            return false;
        }


        #endregion

        #region 输入验证


        /// <summary>
        /// 输入验证
        /// </summary>        
        /// <returns>True:通过 False：不通过</returns>
        private bool CheckInput()
        {
            sBookName = TxtBookName.Text.Trim();
            sBookNumber = TxtBookNumber.Text.Trim();
            iPublishId = CboPublishId.SelectedValue.ChangeInt();
            sPublishDate = DpPublishDate.Text;
            iBookTypeId = CboBookTypeId.SelectedValue.ChangeInt();
            iAuthorId = CboAuthorId.SelectedValue.ChangeInt();
            iConverImg = PbConvrImage.Image;
            sBookPrice = TxtBookPrice.Text.Trim();
            iTotalCount = TxtTotalCount.Text.Trim().ChangeInt();
            sBookSummary = TxtBookSamry.Text.Trim();

            if (string.IsNullOrEmpty(sBookName))
            {
                CommMsgBox.MsgBoxCaveat(CommConst.InputFail);
                return false;
            }

            if (string.IsNullOrEmpty(sPublishDate))
            {
                CommMsgBox.MsgBoxCaveat(CommConst.InputFail);
                return false;
            }
            if (!CommDefine.IsDigital(iTotalCount.ToString()))
            {
                CommMsgBox.MsgBoxCaveat(CommConst.InputFail);
                return false;
            }
            if (!CommDefine.IsDecimal(sBookPrice))
            {
                CommMsgBox.MsgBoxCaveat(CommConst.InputFail);
                return false;
            }
            //if (iConverImg == null)
            //{
            //    CommMsgBox.MsgBoxCaveat(CommConst.InputFail);
            //    return false;
            //}

            return true;
        }

        #endregion



        #region 新增按钮事件
        private void BtnOk_Click(object sender, EventArgs e)
        {
            string bookName = TxtBookName.Text.Trim();

            if (!CheckInput())
            {
                return;
            }
            if (CheckBookName(bookName))
            {
                return;
            }
            // 封装 BookInfo 信息            
            BookInfo bookInfo = new BookInfo
            {
                BookName = bookName,
                BookNumber = sBookName,
                PublishId = CboPublishId.SelectedValue.ChangeInt(),
                PublishDate = sPublishDate.ToDateTime(),
                BookTypeId = CboBookTypeId.SelectedValue.ChangeInt(),
                AuthorId = CboAuthorId.SelectedValue.ChangeInt(),
                BookPrice = Convert.ToDecimal(sBookPrice),
                InputName = UserInfo.LoginName,
                TotalCount = iTotalCount,
                BookSamry = sBookSummary,
                //ConvrImage = CommDefine.ImageToByte(iConverImg)
            };
            // 添加数据到数据库
            AddOrUpdate(bookInfo);
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
