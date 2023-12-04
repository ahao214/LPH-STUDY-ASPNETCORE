using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;
using JokerBooksManager.Comm;
using JokerBooksManagerBLL.BookBLL;
using JokerBooksManagerComm.Comm;
using JokerBooksManagerModels.Model;
using Sunny.UI;


namespace JokerBooksManager.Managers
{
    public partial class FrmReaderInfoAdd : UIForm
    {

        #region 业务逻辑层
        /// <summary>
        /// 读者类别业务逻辑
        /// </summary>
        private ReaderTypeBLL typeBll = new ReaderTypeBLL();

        /// <summary>
        /// 读者信息业务逻辑
        /// </summary>
        private ReaderInfoBLL infoBll = new ReaderInfoBLL();
        #endregion

        #region 窗体共用Mode变量

        /// <summary>
        /// 窗体共用Mode变量
        /// </summary>
        private FormInfoModel formInfoModel = new FormInfoModel();

        #endregion

        #region 读者信息ID

        private int readerId = 0;

        #endregion

        #region 构造函数
        public FrmReaderInfoAdd()
        {
            InitializeComponent();
        }
        #endregion

        #region 窗体加载

        private void FrmReaderInfoAdd_Load(object sender, EventArgs e)
        {
            DataBindReaderType();
            ReaderNumberInit();
            InitialAddOrUpdate();
        }

        #endregion


        #region  初始化读者编码

        private void ReaderNumberInit()
        {
            TxtReaderNumber.Text = CommDefine.NumberPlusOne(CommConst.PrefixReaderNumber,infoBll.GetReaderNumber());
        }

        #endregion

        #region 绑定读者类别

        /// <summary>
        /// 绑定读者类别
        /// </summary>
        private void DataBindReaderType()
        {
            CboReaderTypeId.DataSource = typeBll.GetReaderTypes();
            CboReaderTypeId.DisplayMember = "ReaderTypeName";
            CboReaderTypeId.ValueMember = "ReaderTypeId";

        }

        #endregion

        #region 初始化添加还是修改读者窗体

        private void InitialAddOrUpdate()
        {
            if (!(Tag is null))
            {
                formInfoModel = Tag as FormInfoModel;
                if (!(formInfoModel is null))
                {
                    readerId = formInfoModel.KeyId;
                }
            }
            // 判断窗体是添加还是修改
            if (readerId > 0)
            {
                // 修改
                ReaderInfo info = infoBll.GetReaderInfoById(readerId);

                if (info != null)
                {
                    TxtReaderName.Text = info.ReaderName;
                    CboReaderTypeId.SelectedValue = info.ReaderTypeId.ChangeInt();
                    if (info.ReaderSex.Equals("男"))
                        RbMale.Checked = true;
                    else
                        RbFemale.Checked = true;

                    TxtReaderNumber.Text = info.ReaderNumber;
                    TxtReaderIdCard.Text = info.ReaderIdCard;
                    TxtReaderTel.Text = info.ReaderTel;
                    TxtReaderRemark.Text = info.ReaderRemark;
                }
            }
            else
            {
                // 添加
                TxtReaderName.Clear();
                TxtReaderIdCard.Clear();
                TxtReaderTel.Clear();
                TxtReaderRemark.Clear();
            }
        }

        #endregion

        #region 添加读者信息

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (!CheckInput(out string sReaderName, out int iReaderTypeId, out string sSex, out string sReaderNumber, out string sReaderIdCard, out string sReaderTel, out string sReaderRemark))
            {
                return;
            }
            ReaderInfo info = new ReaderInfo
            {
                ReaderName = sReaderName,
                ReaderTypeId = iReaderTypeId,
                ReaderSex = sSex,
                ReaderNumber = sReaderNumber,
                ReaderIdCard = sReaderIdCard,
                ReaderTel = sReaderTel,
                ReaderRemark = sReaderRemark
            };

            AddOrUpdate(info);

        }

        #endregion 添加读者信息

        #region 添加或修改读者信息
        /// <summary>
        /// 添加或修改读者信息
        /// </summary>
        /// <param name="info"></param>
        private void AddOrUpdate(ReaderInfo info)
        {
            bool res;
            if (readerId == 0)
            {
                // 添加
                res = infoBll.AddReaderInfo(info);
            }
            else
            {
                // 修改
                info .ReaderId = readerId;
                res = infoBll.UpdateReaderInfo(info);
            }
            if (res)
            {
                CommMsgBox.MsgBox(CommConst.SaveDataSuccess);
                // 刷新Dgv
                formInfoModel.ReloadData?.Invoke();
            }
            else
            {
                CommMsgBox.MsgBoxCaveat(CommConst.SaveDataFail);

            }
            Close();
        }

        #endregion



        #region 验证输入控件值

        private bool CheckInput(out string sReaderName, out int iReaderTypeId, out string sSex, out string sReaderNumber, out string sReaderIdCard, out string sReaderTel, out string sReaderRemark)
        {
            sReaderName = TxtReaderName.Text;
            iReaderTypeId = CboReaderTypeId.SelectedValue.ChangeInt();
            if (RbFemale.Checked)
            {
                sSex = RbFemale.Text;
            }
            else
            {
                sSex = RbMale.Text;
            }

            sReaderNumber = TxtReaderNumber.Text;
            sReaderIdCard = TxtReaderIdCard.Text;
            sReaderTel = TxtReaderTel.Text;
            sReaderRemark = TxtReaderRemark.Text;
            if (sReaderRemark.Length == 0 || string.IsNullOrEmpty(sReaderRemark))
            {
                CommMsgBox.MsgBoxCaveat(CommConst.InputFail);
                return false;
            }
            if (iReaderTypeId == 0 || string.IsNullOrEmpty(iReaderTypeId.ToString()))
            {
                CommMsgBox.MsgBoxCaveat(CommConst.InputFail);
                return false;
            }
            if (sSex.Length == 0 || string.IsNullOrEmpty(sSex))
            {
                CommMsgBox.MsgBoxCaveat(CommConst.InputFail);
                return false;
            }
            if (sReaderNumber.Length == 0 || string.IsNullOrEmpty(sReaderNumber))
            {
                CommMsgBox.MsgBoxCaveat(CommConst.InputFail);
                return false;
            }
            if (sReaderIdCard.Length == 0 || string.IsNullOrEmpty(sReaderIdCard))
            {
                CommMsgBox.MsgBoxCaveat(CommConst.InputFail);
                return false;
            }
            if (sReaderTel.Length == 0 || string.IsNullOrEmpty(sReaderTel))
            {
                CommMsgBox.MsgBoxCaveat(CommConst.InputFail);
                return false;
            }
            return true;
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
