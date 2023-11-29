using System;
using JokerBooksManager.Comm;
using JokerBooksManagerBLL.BookBLL;
using JokerBooksManagerComm.Comm;
using JokerBooksManagerModels.Model;
using Sunny.UI;


namespace JokerBooksManager.Managers
{
    public partial class FrmPublishAdd : UIForm
    {
        public FrmPublishAdd()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 窗体共用Model变量
        /// </summary>
        private FormInfoModel formInfoModel = new FormInfoModel();
        /// <summary>
        /// 出版社ID
        /// </summary>
        private int publishId = 0;
        /// <summary>
        /// 存放原始的出版社
        /// </summary>
        private string oldPublishName = string.Empty;

        private PublishHouseBLL bll = new PublishHouseBLL();





        #region 添加或修改出版社信息
        /// <summary>
        /// 添加或修改出版社信息
        /// </summary>
        /// <param name="type"></param>
        private void AddOrUpdate(PublishHouse publish)
        {
            bool bRes;
            if (publishId == 0) // 添加
            {
                bRes = bll.AddPublishHouse(publish);
            }
            else // 修改
            {
                bRes = bll.UpdatePublishHouse(publish);
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

        #region 验证出版社名称是否存在
        /// <summary>
        /// 验证出版社名称是否存在
        /// </summary>
        /// <param name="publishName">出版社名称</param>
        /// <returns>True:存在 False：不存在</returns>
        private bool CheckPublishName(string publishName)
        {
            if (publishId == 0 || (publishId > 0 && oldPublishName != publishName))
            {
                if (bll.IsExistPublishHouse(publishName))
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
        /// <param name="publishName">出版社名称</param>
        /// <returns>True:通过 False：不通过</returns>
        private bool CheckInput(string publishName)
        {
            if (publishName.Length == 0 || string.IsNullOrEmpty(publishName))
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
                    publishId = formInfoModel.KeyId;
                }
            }
            if (publishId > 0)
            {
                PublishHouse publishHouse = bll.GetPublishHouseById(publishId);
                if (publishHouse is null)
                    return;
                oldPublishName = TxtPublishName.Text = publishHouse.PublishName;
                TxtRemark.Text = publishHouse.Remark;

                Text = CommConst.CharUpdateBookType;
            }
            else
            {
                TxtPublishName.Clear();
                TxtRemark.Clear();
            }
        }

        #endregion







        #region 窗体加载
        private void FrmPublishAdd_Load(object sender, EventArgs e)
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
            string publishName = TxtPublishName.Text.Trim();
            string remark = TxtRemark.Text.Trim();

            if (!CheckInput(publishName))
            {
                return;
            }
            if (CheckPublishName(publishName))
            {
                return;
            }
            // 封装 PublishHouse 信息            
            PublishHouse publishHouse = new PublishHouse
            {
                PublishId = publishId,
                PublishName = publishName,
                Remark = remark
            };
            // 添加数据到数据库
            AddOrUpdate(publishHouse);
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
