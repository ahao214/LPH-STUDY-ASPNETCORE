﻿using System;
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
        private decimal dBookPrice;
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
                Author author = bll.GetAuthorById(bookId);
                if (author is null)
                    return;
                //oldAuthorName = TxtAuthorName.Text = author.AuthorName;
                //TxtRemark.Text = author.Remark;

                Text = CommConst.CharUpdateBookType;
            }
            else
            {
                PbConvrImage.Image = null;
                TxtBookSamry.Clear();
                foreach (Control item in GbCrls.Controls)
                {
                    if (item is UITextBox)
                    {
                        UITextBox txtBox = item as UITextBox;
                        txtBox.Clear();
                    }
                }

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
            TxtBookNumber.Text = bookBll.GetBookNumber();

        }

        #endregion


        #region 添加或修改图书信息
        /// <summary>
        /// 添加或修改图书信息
        /// </summary>
        /// <param name="type"></param>
        private void AddOrUpdate(Author author)
        {
            bool bRes;
            if (bookId == 0) // 添加
            {
                bRes = bll.AddAuthor(author);
            }
            else // 修改
            {
                bRes = bll.UpdateAuthor(author);
            }
            if (bRes)
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
        /// <param name="authorName">图书名称</param>
        /// <returns>True:存在 False：不存在</returns>
        private bool CheckBookName(string authorName)
        {
            if (bookId == 0 || (bookId > 0 && oldAuthorName != authorName))
            {
                if (bll.IsExistAuthor(authorName))
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
            dBookPrice = Convert.ToDecimal(TxtBookPrice.Text.Trim());
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
            if (string.IsNullOrEmpty(dBookPrice.ToString()))
            {
                CommMsgBox.MsgBoxCaveat(CommConst.InputFail);
                return false;
            }
            if (iConverImg == null)
            {
                CommMsgBox.MsgBoxCaveat(CommConst.InputFail);
                return false;
            }

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
            // 封装 Author 信息            
            Author author = new Author
            {
                AuthorId = bookId
            };
            // 添加数据到数据库
            AddOrUpdate(author);
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
