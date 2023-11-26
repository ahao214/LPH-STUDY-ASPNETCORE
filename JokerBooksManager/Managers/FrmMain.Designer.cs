namespace JokerBooksManager.Managers
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsmiSysManage = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiPassModify = new System.Windows.Forms.ToolStripMenuItem();
            this.TmsiExitSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.MsMenu = new System.Windows.Forms.MenuStrip();
            this.TsmiReaderManager = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiReaderTypeName = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiReaderInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiWindowList = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiBookTypeManager = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiBookTypeList = new System.Windows.Forms.ToolStripMenuItem();
            this.Sstatus = new System.Windows.Forms.StatusStrip();
            this.TsslTxtInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslLoginName = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timers = new System.Windows.Forms.Timer(this.components);
            this.TvBookType = new Sunny.UI.UITreeView();
            this.MsMenu.SuspendLayout();
            this.Sstatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 67);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1189, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TsmiSysManage
            // 
            this.TsmiSysManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiPassModify,
            this.TmsiExitSystem});
            this.TsmiSysManage.Image = global::JokerBooksManager.Properties.Resources._1;
            this.TsmiSysManage.Name = "TsmiSysManage";
            this.TsmiSysManage.Size = new System.Drawing.Size(144, 28);
            this.TsmiSysManage.Text = "系统管理(&S)";
            // 
            // TsmiPassModify
            // 
            this.TsmiPassModify.Image = global::JokerBooksManager.Properties.Resources._2;
            this.TsmiPassModify.Name = "TsmiPassModify";
            this.TsmiPassModify.Size = new System.Drawing.Size(209, 34);
            this.TsmiPassModify.Text = "密码修改(&P)";
            this.TsmiPassModify.Click += new System.EventHandler(this.TsmiPassModify_Click);
            // 
            // TmsiExitSystem
            // 
            this.TmsiExitSystem.Image = global::JokerBooksManager.Properties.Resources._3;
            this.TmsiExitSystem.Name = "TmsiExitSystem";
            this.TmsiExitSystem.Size = new System.Drawing.Size(209, 34);
            this.TmsiExitSystem.Text = "退出系统(&Q)";
            this.TmsiExitSystem.Click += new System.EventHandler(this.TmsiExitSystem_Click);
            // 
            // MsMenu
            // 
            this.MsMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MsMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiSysManage,
            this.TsmiReaderManager,
            this.TsmiWindowList,
            this.TsmiBookTypeManager});
            this.MsMenu.Location = new System.Drawing.Point(0, 35);
            this.MsMenu.MdiWindowListItem = this.TsmiWindowList;
            this.MsMenu.Name = "MsMenu";
            this.MsMenu.Size = new System.Drawing.Size(1189, 32);
            this.MsMenu.TabIndex = 1;
            this.MsMenu.Text = "menuStrip2";
            // 
            // TsmiReaderManager
            // 
            this.TsmiReaderManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiReaderTypeName,
            this.TsmiReaderInfo});
            this.TsmiReaderManager.Image = global::JokerBooksManager.Properties.Resources._5;
            this.TsmiReaderManager.Name = "TsmiReaderManager";
            this.TsmiReaderManager.Size = new System.Drawing.Size(146, 28);
            this.TsmiReaderManager.Text = "读者管理(&R)";
            // 
            // TsmiReaderTypeName
            // 
            this.TsmiReaderTypeName.Name = "TsmiReaderTypeName";
            this.TsmiReaderTypeName.Size = new System.Drawing.Size(204, 34);
            this.TsmiReaderTypeName.Text = "读者类别(&T)";
            this.TsmiReaderTypeName.Click += new System.EventHandler(this.TsmiReaderTypeName_Click);
            // 
            // TsmiReaderInfo
            // 
            this.TsmiReaderInfo.Name = "TsmiReaderInfo";
            this.TsmiReaderInfo.Size = new System.Drawing.Size(204, 34);
            this.TsmiReaderInfo.Text = "读者信息(&I)";
            this.TsmiReaderInfo.Click += new System.EventHandler(this.TsmiReaderInfo_Click);
            // 
            // TsmiWindowList
            // 
            this.TsmiWindowList.Image = global::JokerBooksManager.Properties.Resources._4;
            this.TsmiWindowList.Name = "TsmiWindowList";
            this.TsmiWindowList.Size = new System.Drawing.Size(122, 28);
            this.TsmiWindowList.Text = "窗口列表";
            // 
            // TsmiBookTypeManager
            // 
            this.TsmiBookTypeManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiBookTypeList});
            this.TsmiBookTypeManager.Image = global::JokerBooksManager.Properties.Resources._1;
            this.TsmiBookTypeManager.Name = "TsmiBookTypeManager";
            this.TsmiBookTypeManager.Size = new System.Drawing.Size(122, 28);
            this.TsmiBookTypeManager.Text = "图书类别";
            // 
            // TsmiBookTypeList
            // 
            this.TsmiBookTypeList.Image = global::JokerBooksManager.Properties.Resources._2;
            this.TsmiBookTypeList.Name = "TsmiBookTypeList";
            this.TsmiBookTypeList.Size = new System.Drawing.Size(218, 34);
            this.TsmiBookTypeList.Text = "图书类别列表";
            this.TsmiBookTypeList.Click += new System.EventHandler(this.TsmiBookTypeList_Click);
            // 
            // Sstatus
            // 
            this.Sstatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Sstatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsslTxtInfo,
            this.TsslLoginName,
            this.TsslTime});
            this.Sstatus.Location = new System.Drawing.Point(0, 989);
            this.Sstatus.Name = "Sstatus";
            this.Sstatus.Size = new System.Drawing.Size(1189, 31);
            this.Sstatus.TabIndex = 2;
            this.Sstatus.Text = "statusStrip1";
            // 
            // TsslTxtInfo
            // 
            this.TsslTxtInfo.AutoSize = false;
            this.TsslTxtInfo.Name = "TsslTxtInfo";
            this.TsslTxtInfo.Size = new System.Drawing.Size(82, 24);
            this.TsslTxtInfo.Text = "登录名：";
            this.TsslTxtInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TsslLoginName
            // 
            this.TsslLoginName.AutoSize = false;
            this.TsslLoginName.Name = "TsslLoginName";
            this.TsslLoginName.Size = new System.Drawing.Size(150, 24);
            // 
            // TsslTime
            // 
            this.TsslTime.AutoSize = false;
            this.TsslTime.Name = "TsslTime";
            this.TsslTime.Size = new System.Drawing.Size(200, 24);
            this.TsslTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Timers
            // 
            this.Timers.Enabled = true;
            this.Timers.Interval = 1000;
            this.Timers.Tick += new System.EventHandler(this.Timers_Tick);
            // 
            // TvBookType
            // 
            this.TvBookType.Dock = System.Windows.Forms.DockStyle.Left;
            this.TvBookType.FillColor = System.Drawing.Color.White;
            this.TvBookType.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.TvBookType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TvBookType.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(212)))));
            this.TvBookType.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.TvBookType.Location = new System.Drawing.Point(0, 91);
            this.TvBookType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TvBookType.MinimumSize = new System.Drawing.Size(1, 1);
            this.TvBookType.Name = "TvBookType";
            this.TvBookType.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.TvBookType.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.TvBookType.ShowText = false;
            this.TvBookType.Size = new System.Drawing.Size(294, 898);
            this.TvBookType.Style = Sunny.UI.UIStyle.Green;
            this.TvBookType.TabIndex = 3;
            this.TvBookType.Text = "uiTreeView1";
            this.TvBookType.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1189, 1020);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.TvBookType);
            this.Controls.Add(this.Sstatus);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.MsMenu);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.Style = Sunny.UI.UIStyle.Green;
            this.Text = "图书管理系统主页面";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.MsMenu.ResumeLayout(false);
            this.MsMenu.PerformLayout();
            this.Sstatus.ResumeLayout(false);
            this.Sstatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsmiSysManage;
        private System.Windows.Forms.ToolStripMenuItem TsmiPassModify;
        private System.Windows.Forms.ToolStripMenuItem TmsiExitSystem;
        private System.Windows.Forms.MenuStrip MsMenu;
        private System.Windows.Forms.ToolStripMenuItem TsmiWindowList;
        private System.Windows.Forms.StatusStrip Sstatus;
        private System.Windows.Forms.ToolStripStatusLabel TsslTxtInfo;
        private System.Windows.Forms.ToolStripStatusLabel TsslLoginName;
        private System.Windows.Forms.ToolStripStatusLabel TsslTime;
        private System.Windows.Forms.Timer Timers;
        private System.Windows.Forms.ToolStripMenuItem TsmiReaderManager;
        private System.Windows.Forms.ToolStripMenuItem TsmiReaderTypeName;
        private System.Windows.Forms.ToolStripMenuItem TsmiReaderInfo;
        private System.Windows.Forms.ToolStripMenuItem TsmiBookTypeManager;
        private System.Windows.Forms.ToolStripMenuItem TsmiBookTypeList;
        private Sunny.UI.UITreeView TvBookType;
    }
}