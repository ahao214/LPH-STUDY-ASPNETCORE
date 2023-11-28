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
    /// 主窗体界面
    /// </summary>
    public partial class FrmMain : UIForm
    {
        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region 密码修改事件

        /// <summary>
        /// 密码修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiPassModify_Click(object sender, EventArgs e)
        {
            FrmPassModify frmPassModify = SingleForm<FrmPassModify>.CreateInstance();
            frmPassModify.MdiParent = MdiParent;
            frmPassModify.Show();
        }

        #endregion

        #region 退出系统事件

        /// <summary>
        /// 退出系统事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmsiExitSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region 关闭窗体

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = CommMsgBox.YesNoConfirm(CommConst.QuitSystem);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }

        #endregion

        #region 窗体加载

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            FormFit();
            LoadInfo();
            LoadTvBookType();
        }

        #endregion

        #region 加载状态栏指定信息

        /// <summary>
        /// 加载状态栏指定信息
        /// </summary>
        private void LoadInfo()
        {
            TsslLoginName.Text = UserInfo.LoginName;
            TsslTime.Text = "时间：" + CommDefine.RepString(DateTime.Now.ToString());
        }

        #endregion

        #region 状态栏时间计时器

        /// <summary>
        /// 状态栏时间计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timers_Tick(object sender, EventArgs e)
        {
            TsslTime.Text = "时间：" + CommDefine.RepString(DateTime.Now.ToString());
        }

        #endregion


        #region 状态栏宽度自动伸缩

        /// <summary>
        /// 状态栏宽度自动伸缩
        /// </summary>
        private void FormFit()
        {
            WindowState = FormWindowState.Maximized;
            TsslLoginName.Width = Sstatus.Width - TsslTxtInfo.Width - TsslTime.Width * 2;
        }

        #endregion

        #region 窗体变换大小时发生
        /// <summary>
        /// 窗体变换大小时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
        }




        #endregion

        #region 读者类别窗体
        private void TsmiReaderTypeName_Click(object sender, EventArgs e)
        {
            FrmReaderType type = SingleForm<FrmReaderType>.CreateInstance();
            type.MdiParent = MdiParent;
            type.Show();
        }

        #endregion

        #region 读者信息
        private void TsmiReaderInfo_Click(object sender, EventArgs e)
        {
            FrmReaderInfoList infoList = SingleForm<FrmReaderInfoList>.CreateInstance();
            infoList.MdiParent = MdiParent;
            infoList.Show();
        }

        #endregion

        #region 图书类别列表
        private void TsmiBookTypeList_Click(object sender, EventArgs e)
        {
            FrmBookTypeList frmBookTypeList = SingleForm<FrmBookTypeList>.CreateInstance(); frmBookTypeList.MdiParent = MdiParent;
            frmBookTypeList.Show();
        }
        #endregion

        #region 加载树形菜单(图书分类)

        /// <summary>
        /// 加载树形菜单(图书分类)
        /// </summary>
        private void LoadTvBookType()
        {
            BookTypeBLL bll = new BookTypeBLL();
            List<BookType> lstBookTypes = bll.GetBookTypes();
            // 先添加根节点
            TreeNode rootNode = new TreeNode
            {
                Name = "RootBookType",
                Text = "图书分类"
            };
            TvBookType.Nodes .Add (rootNode);
            // 然后在根的节点处添加我们的分类
            foreach (BookType bt in lstBookTypes)
            {
                TreeNode tn = new TreeNode
                {
                    Name = "BookType" + bt.BookTypeId.ToString(),
                    Text = bt.BookTypeName
                };
                rootNode.Nodes.Add(tn);
            }
            TvBookType.ExpandAll();

        }

        #endregion


    }
}
