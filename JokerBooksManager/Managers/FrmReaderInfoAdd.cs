﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JokerBooksManagerBLL.BookBLL;
using JokerBooksManagerComm.Comm;
using JokerBooksManagerModels.Model;
using Sunny.UI;


namespace JokerBooksManager.Managers
{
    public partial class FrmReaderInfoAdd : UIForm
    {
        /// <summary>
        /// 读者类别业务逻辑
        /// </summary>
        private ReaderTypeBLL typeBll = new ReaderTypeBLL();

        /// <summary>
        /// 读者信息业务逻辑
        /// </summary>
        private ReaderInfoBLL infoBll = new ReaderInfoBLL();

        public FrmReaderInfoAdd()
        {
            InitializeComponent();
        }

        #region 窗体加载

        private void FrmReaderInfoAdd_Load(object sender, EventArgs e)
        {
            DataBindReaderType();
            ReaderNumberInit();
        }

        #endregion


        #region  初始化读者编码

        private void ReaderNumberInit()
        {
            TxtReaderNumber.Text = CommDefine.NumberPlusOne(infoBll.GetReaderNumber());
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

            string sql = BuilderSqlHelper.InsertSql<ReaderInfo>(info, "ReaderInfo", "ReaderId");
            
        }

        #endregion 添加读者信息




        #region 验证输入控件值

        private bool CheckInput(out string sReaderName, out int iReaderTypeId, out string sSex, out string sReaderNumber, out string sReaderIdCard, out string sReaderTel, out string sReaderRemark)
        {
            sReaderName = TxtReaderName.Text;
            iReaderTypeId = TxtReaderIdCard.Text.ChangeInt();
            sSex = RbFemale.Text;
            sReaderNumber = TxtReaderNumber.Text;
            sReaderIdCard = TxtReaderIdCard.Text;
            sReaderTel = TxtReaderTel.Text;
            sReaderRemark = TxtReaderRemark.Text;
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
