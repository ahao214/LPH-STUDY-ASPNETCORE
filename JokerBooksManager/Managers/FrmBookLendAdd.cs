﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace JokerBooksManager.Managers
{
    /// <summary>
    /// 图书借阅窗体
    /// </summary>
    public partial class FrmBookLendAdd : UIForm
    {
        public FrmBookLendAdd()
        {
            InitializeComponent();
        }

        #region 关闭当前窗体
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        #endregion



    }
}