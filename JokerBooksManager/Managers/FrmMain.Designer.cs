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
            this.TsmiWindowList = new System.Windows.Forms.ToolStripMenuItem();
            this.Sstatus = new System.Windows.Forms.StatusStrip();
            this.TsslTxtInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslLoginName = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timers = new System.Windows.Forms.Timer(this.components);
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
            this.TsmiPassModify.Size = new System.Drawing.Size(270, 34);
            this.TsmiPassModify.Text = "密码修改(&P)";
            this.TsmiPassModify.Click += new System.EventHandler(this.TsmiPassModify_Click);
            // 
            // TmsiExitSystem
            // 
            this.TmsiExitSystem.Image = global::JokerBooksManager.Properties.Resources._3;
            this.TmsiExitSystem.Name = "TmsiExitSystem";
            this.TmsiExitSystem.Size = new System.Drawing.Size(270, 34);
            this.TmsiExitSystem.Text = "退出系统(&Q)";
            this.TmsiExitSystem.Click += new System.EventHandler(this.TmsiExitSystem_Click);
            // 
            // MsMenu
            // 
            this.MsMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MsMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiSysManage,
            this.TsmiWindowList});
            this.MsMenu.Location = new System.Drawing.Point(0, 35);
            this.MsMenu.MdiWindowListItem = this.TsmiWindowList;
            this.MsMenu.Name = "MsMenu";
            this.MsMenu.Size = new System.Drawing.Size(1189, 32);
            this.MsMenu.TabIndex = 1;
            this.MsMenu.Text = "menuStrip2";
            // 
            // TsmiWindowList
            // 
            this.TsmiWindowList.Image = global::JokerBooksManager.Properties.Resources._4;
            this.TsmiWindowList.Name = "TsmiWindowList";
            this.TsmiWindowList.Size = new System.Drawing.Size(122, 28);
            this.TsmiWindowList.Text = "窗口列表";
            // 
            // Sstatus
            // 
            this.Sstatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Sstatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsslTxtInfo,
            this.TsslLoginName,
            this.TsslTime});
            this.Sstatus.Location = new System.Drawing.Point(0, 657);
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
            // 
            // Timers
            // 
            this.Timers.Enabled = true;
            this.Timers.Interval = 1000;
            this.Timers.Tick += new System.EventHandler(this.Timers_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1189, 688);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
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
    }
}