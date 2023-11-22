namespace JokerBooksManager.Managers
{
    partial class FrmPassModify
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.BtnOk = new Sunny.UI.UIButton();
            this.TxtOldPass = new Sunny.UI.UITextBox();
            this.BtnClose = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.TxtNewPass = new Sunny.UI.UITextBox();
            this.TxtRePass = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(103, 67);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "原始密码";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnOk
            // 
            this.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOk.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOk.Location = new System.Drawing.Point(97, 316);
            this.BtnOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(100, 35);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.Text = "确定";
            this.BtnOk.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // TxtOldPass
            // 
            this.TxtOldPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtOldPass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtOldPass.Location = new System.Drawing.Point(283, 67);
            this.TxtOldPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtOldPass.MinimumSize = new System.Drawing.Size(1, 16);
            this.TxtOldPass.Name = "TxtOldPass";
            this.TxtOldPass.Padding = new System.Windows.Forms.Padding(5);
            this.TxtOldPass.ShowText = false;
            this.TxtOldPass.Size = new System.Drawing.Size(150, 32);
            this.TxtOldPass.TabIndex = 2;
            this.TxtOldPass.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtOldPass.Watermark = "";
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnClose.Location = new System.Drawing.Point(274, 316);
            this.BtnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(100, 35);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "关闭";
            this.BtnClose.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(103, 228);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(160, 23);
            this.uiLabel2.TabIndex = 4;
            this.uiLabel2.Text = "再次输入密码";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(103, 149);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "新密码";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtNewPass
            // 
            this.TxtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNewPass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtNewPass.Location = new System.Drawing.Point(283, 149);
            this.TxtNewPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNewPass.MinimumSize = new System.Drawing.Size(1, 16);
            this.TxtNewPass.Name = "TxtNewPass";
            this.TxtNewPass.Padding = new System.Windows.Forms.Padding(5);
            this.TxtNewPass.ShowText = false;
            this.TxtNewPass.Size = new System.Drawing.Size(150, 32);
            this.TxtNewPass.TabIndex = 6;
            this.TxtNewPass.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtNewPass.Watermark = "";
            // 
            // TxtRePass
            // 
            this.TxtRePass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRePass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtRePass.Location = new System.Drawing.Point(283, 228);
            this.TxtRePass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRePass.MinimumSize = new System.Drawing.Size(1, 16);
            this.TxtRePass.Name = "TxtRePass";
            this.TxtRePass.Padding = new System.Windows.Forms.Padding(5);
            this.TxtRePass.ShowText = false;
            this.TxtRePass.Size = new System.Drawing.Size(150, 32);
            this.TxtRePass.TabIndex = 7;
            this.TxtRePass.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtRePass.Watermark = "";
            // 
            // FrmPassModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtRePass);
            this.Controls.Add(this.TxtNewPass);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TxtOldPass);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.uiLabel1);
            this.Name = "FrmPassModify";
            this.Text = "FrmPassModify";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton BtnOk;
        private Sunny.UI.UITextBox TxtOldPass;
        private Sunny.UI.UIButton BtnClose;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox TxtNewPass;
        private Sunny.UI.UITextBox TxtRePass;
    }
}