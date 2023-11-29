using System;
using JokerBooksManager.Comm;
using JokerBooksManagerBLL.BookBLL;
using JokerBooksManagerComm.Comm;
using JokerBooksManagerModels.Model;
using Sunny.UI;



namespace JokerBooksManager.Managers
{
    public partial class FrmAuthorAdd : UIForm
    {
        public FrmAuthorAdd()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 窗体共用Model变量
        /// </summary>
        private FormInfoModel formInfoModel = new FormInfoModel();
        /// <summary>
        /// 作者ID
        /// </summary>
        private int authorId = 0;
        /// <summary>
        /// 存放原始的作者名字
        /// </summary>
        private string oldAuthorName = string.Empty;

        private AuthorBLL bll = new AuthorBLL();





        #region 添加或修改作者信息
        /// <summary>
        /// 添加或修改作者信息
        /// </summary>
        /// <param name="type"></param>
        private void AddOrUpdate(Author author)
        {
            bool bRes;
            if (authorId == 0) // 添加
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

        #region 验证作者名称是否存在
        /// <summary>
        /// 验证作者名称是否存在
        /// </summary>
        /// <param name="authorName">作者名称</param>
        /// <returns>True:存在 False：不存在</returns>
        private bool CheckAuthorName(string authorName)
        {
            if (authorId == 0 || (authorId > 0 && oldAuthorName != authorName))
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
        /// <param name="authorName">作者名称</param>
        /// <returns>True:通过 False：不通过</returns>
        private bool CheckInput(string authorName)
        {
            if (authorName.Length == 0 || string.IsNullOrEmpty(authorName))
            {
                CommMsgBox.MsgBoxCaveat(CommConst.InputFail);
                return false;
            }
            return true;
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
                    authorId = formInfoModel.KeyId;
                }
            }
            if (authorId > 0)
            {
                Author author = bll.GetAuthorById(authorId);
                if (author is null)
                    return;
                oldAuthorName = TxtAuthorName.Text = author.AuthorName;
                TxtRemark.Text = author.Remark;

                Text = CommConst.CharUpdateBookType;
            }
            else
            {
                TxtAuthorName.Clear();
                TxtRemark.Clear();
            }
        }

        #endregion








        #region 关闭窗体
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 确定事件(新增或修改作者)
        private void BtnOk_Click(object sender, EventArgs e)
        {
            string authorName = TxtAuthorName.Text.Trim();
            string remark = TxtRemark.Text.Trim();

            if (!CheckInput(authorName))
            {
                return;
            }
            if (CheckAuthorName(authorName))
            {
                return;
            }
            // 封装 Author 信息            
            Author author = new Author
            {
                AuthorId = authorId,
                AuthorName = authorName,
                Remark = remark
            };
            // 添加数据到数据库
            AddOrUpdate(author);
        }
        #endregion

        #region 窗体加载
        private void FrmAuthorAdd_Load(object sender, EventArgs e)
        {
            InitialAddOrUpdate();
        }
        #endregion
    }
}
