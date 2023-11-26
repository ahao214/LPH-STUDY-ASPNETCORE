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
    /// 添加图书信息
    /// </summary>
    public partial class FrmBookTypeAdd : UIForm
    {
        public FrmBookTypeAdd()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体共用Model变量
        /// </summary>
        private FormInfoModel formInfoModel = new FormInfoModel();
        /// <summary>
        /// 图书类别ID
        /// </summary>
        private int bookTypeId = 0;
        /// <summary>
        /// 存放原始的图书类别
        /// </summary>
        private string oldBookTypeName = string.Empty;

        private BookTypeBLL bll = new BookTypeBLL();



       

        #region 添加或修改图书类别信息
        /// <summary>
        /// 添加或修改图书类别信息
        /// </summary>
        /// <param name="type"></param>
        private void AddOrUpdate(BookType type)
        {
            bool bRes;
            if (bookTypeId == 0) // 添加
            {
                //bRes = bll.AddReaderType(type);
            }
            else // 修改
            {
                //bRes = bll.UpdateReaderType(type);
            }
            //if (bRes)
            //{
            //    CommMsgBox.MsgBox(CommConst.SaveDataSuccess);
            //    // 刷新
            //    formInfoModel.ReloadData?.Invoke();
            //    Close();
            //}
            //else
            //{
            //    CommMsgBox.MsgBox(CommConst.SaveDataFail);
            //    Close();
            //}
        }

        #endregion

        #region 验证图书类别名称是否存在
        /// <summary>
        /// 验证图书类别名称是否存在
        /// </summary>
        /// <param name="typeName">图书类别名称</param>
        /// <returns>True:存在 False：不存在</returns>
        private bool CheckBookType(string typeName)
        {
            if (bookTypeId == 0 || (bookTypeId > 0 && oldBookTypeName != typeName))
            {
                if (bll.IsExistBookType(typeName))
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
        /// <param name="typeName">图书类别名称</param>
        /// <returns>True:通过 False：不通过</returns>
        private bool CheckInput(string typeName)
        {
            if (typeName.Length == 0 || string.IsNullOrEmpty(typeName))
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
                    bookTypeId = formInfoModel.KeyId;
                }
            }
            if (bookTypeId > 0)
            {
                //ReaderType type = bll.GetReaderTypeById(bookTypeId);
                //if (type is null)
                //    return;
                //oldBookTypeName = TxtBookTypeName.Text = type.ReaderTypeName;

                Text = CommConst.CharUpdateBookType;
            }
            else
            {
                TxtBookTypeName.Clear();
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

        #region 窗体加载
        private void FrmBookTypeAdd_Load(object sender, EventArgs e)
        {
            InitialAddOrUpdate();
        }

        #endregion

        #region 确定事件(新增或修改图书)
        /// <summary>
        /// 确定事件(新增或修改图书)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOk_Click(object sender, EventArgs e)
        {
            string bookType = TxtBookTypeName.Text.Trim();
            string remark = TxtRemark.Text.Trim();

            if (!CheckInput(bookType))
            {
                return;
            }
            if (CheckBookType(bookType))
            {
                return;
            }
            // 封装BookType信息            
            BookType type = new BookType
            {
                BookTypeId = bookTypeId,
                BookTypeName = bookType
            };
            // 添加数据到数据库
            AddOrUpdate(type);
        }
        #endregion
    }
}
