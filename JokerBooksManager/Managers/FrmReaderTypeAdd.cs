using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using JokerBooksManagerBLL.BookBLL;
using JokerBooksManagerModels.Model;
using JokerBooksManager.Comm;
using JokerBooksManagerComm.Comm;

namespace JokerBooksManager.Managers
{
    /// <summary>
    /// 新增或者修改读者类别窗体
    /// </summary>
    public partial class FrmReaderTypeAdd : UIForm
    {
        /// <summary>
        /// 窗体共用Model变量
        /// </summary>
        private FormInfoModel formInfoModel = new FormInfoModel();
        /// <summary>
        /// 读者类别ID
        /// </summary>
        private int readTypeId = 0;
        /// <summary>
        /// 存放原始的读者类别
        /// </summary>
        private string oldReadTypeName = string.Empty;

        private ReaderTypeBLL bll = new ReaderTypeBLL();

        public FrmReaderTypeAdd()
        {
            InitializeComponent();
        }

        #region 新增读者类别
        /// <summary>
        /// 新增读者类别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOk_Click(object sender, EventArgs e)
        {
            string typeName = TxtReaderTypeName.Text.Trim();
            if (!CheckInput(typeName))
            {
                return;
            }
            if (CheckReaderType(typeName))
            {
                return;
            }
            // 封装ReaderType信息
            ReaderType type = new ReaderType
            {
                ReaderTypeId = readTypeId,
                ReaderTypeName = typeName
            };
            // 添加数据到数据库
            AddOrUpdate(type);
        }
        #endregion

        #region 添加或修改读者类别信息
        /// <summary>
        /// 添加或修改读者类别信息
        /// </summary>
        /// <param name="type"></param>
        private void AddOrUpdate(ReaderType type)
        {
            bool bRes;
            if (readTypeId == 0) // 添加
            {
                bRes = bll.AddReaderType(type);
            }
            else // 修改
            {
                bRes = bll.UpdateReaderType(type);
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

        #region 验证读者类别名称是否存在
        /// <summary>
        /// 验证读者类别名称是否存在
        /// </summary>
        /// <param name="typeName">读者类别名称</param>
        /// <returns>True:存在 False：不存在</returns>
        private bool CheckReaderType(string typeName)
        {
            if (readTypeId == 0 || (readTypeId > 0 && oldReadTypeName != typeName))
            {
                if (bll.IsExistReaderType(typeName))
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
        /// <param name="typeName">读者类别名称</param>
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

        private void InitialAddOrUpdate()
        {
            if (!(Tag is null))
            {
                formInfoModel = Tag as FormInfoModel;
                if (!(formInfoModel is null))
                {
                    readTypeId = formInfoModel.KeyId;
                }
            }
            if (readTypeId > 0)
            {
                ReaderType type = bll.GetReaderTypeById(readTypeId);
                if (type is null)
                    return;
                oldReadTypeName = TxtReaderTypeName.Text = type.ReaderTypeName;

                Text = CommConst.CharUpdateReaderType;
            }
            else
            {
                TxtReaderTypeName.Clear();
            }
        }

        #region 关闭窗口
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 窗体加载
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReaderTypeAdd_Load(object sender, EventArgs e)
        {
            InitialAddOrUpdate();
        }
        #endregion
    }
}
