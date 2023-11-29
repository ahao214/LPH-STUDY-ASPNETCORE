namespace JokerBooksManager.Managers
{
    partial class FrmAuthorList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnClose = new Sunny.UI.UIButton();
            this.BtnAddNew = new Sunny.UI.UIButton();
            this.DgvAuthor = new Sunny.UI.UIDataGridView();
            this.AuthorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modify = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DelData = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnClose.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnClose.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnClose.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnClose.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnClose.Location = new System.Drawing.Point(746, 454);
            this.BtnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnClose.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnClose.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnClose.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnClose.Size = new System.Drawing.Size(100, 35);
            this.BtnClose.Style = Sunny.UI.UIStyle.Green;
            this.BtnClose.TabIndex = 10;
            this.BtnClose.Text = "关闭";
            this.BtnClose.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnAddNew.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnAddNew.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnAddNew.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnAddNew.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnAddNew.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAddNew.Location = new System.Drawing.Point(529, 454);
            this.BtnAddNew.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnAddNew.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnAddNew.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnAddNew.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnAddNew.Size = new System.Drawing.Size(134, 35);
            this.BtnAddNew.Style = Sunny.UI.UIStyle.Green;
            this.BtnAddNew.TabIndex = 9;
            this.BtnAddNew.Text = "新增作者";
            this.BtnAddNew.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // DgvAuthor
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvAuthor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAuthor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvAuthor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAuthor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvAuthor.ColumnHeadersHeight = 32;
            this.DgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuthorId,
            this.AuthorName,
            this.Remark,
            this.Modify,
            this.DelData});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAuthor.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvAuthor.EnableHeadersVisualStyles = false;
            this.DgvAuthor.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DgvAuthor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(69)))));
            this.DgvAuthor.Location = new System.Drawing.Point(3, 38);
            this.DgvAuthor.Name = "DgvAuthor";
            this.DgvAuthor.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAuthor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvAuthor.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DgvAuthor.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvAuthor.RowTemplate.Height = 30;
            this.DgvAuthor.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvAuthor.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.DgvAuthor.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.DgvAuthor.SelectedIndex = -1;
            this.DgvAuthor.Size = new System.Drawing.Size(926, 365);
            this.DgvAuthor.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvAuthor.Style = Sunny.UI.UIStyle.Green;
            this.DgvAuthor.TabIndex = 11;
            this.DgvAuthor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAuthor_CellContentClick);
            // 
            // AuthorId
            // 
            this.AuthorId.DataPropertyName = "AuthorId";
            this.AuthorId.HeaderText = "作者ID";
            this.AuthorId.MinimumWidth = 8;
            this.AuthorId.Name = "AuthorId";
            this.AuthorId.ToolTipText = "作者ID";
            this.AuthorId.Width = 150;
            // 
            // AuthorName
            // 
            this.AuthorName.DataPropertyName = "AuthorName";
            this.AuthorName.HeaderText = "作者姓名";
            this.AuthorName.MinimumWidth = 8;
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.ToolTipText = "作者姓名";
            this.AuthorName.Width = 200;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.MinimumWidth = 8;
            this.Remark.Name = "Remark";
            this.Remark.ToolTipText = "备注";
            this.Remark.Width = 150;
            // 
            // Modify
            // 
            this.Modify.HeaderText = "修改";
            this.Modify.LinkColor = System.Drawing.Color.Lime;
            this.Modify.MinimumWidth = 8;
            this.Modify.Name = "Modify";
            this.Modify.Text = "修改";
            this.Modify.ToolTipText = "修改";
            this.Modify.UseColumnTextForLinkValue = true;
            this.Modify.Width = 150;
            // 
            // DelData
            // 
            this.DelData.HeaderText = "删除";
            this.DelData.LinkColor = System.Drawing.Color.Lime;
            this.DelData.MinimumWidth = 8;
            this.DelData.Name = "DelData";
            this.DelData.Text = "删除";
            this.DelData.ToolTipText = "删除";
            this.DelData.UseColumnTextForLinkValue = true;
            this.DelData.Width = 150;
            // 
            // FrmAuthorList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(956, 558);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAddNew);
            this.Controls.Add(this.DgvAuthor);
            this.Name = "FrmAuthorList";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.Style = Sunny.UI.UIStyle.Green;
            this.Text = "作者信息列表";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            this.Load += new System.EventHandler(this.FrmAuthorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAuthor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton BtnClose;
        private Sunny.UI.UIButton BtnAddNew;
        private Sunny.UI.UIDataGridView DgvAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewLinkColumn Modify;
        private System.Windows.Forms.DataGridViewLinkColumn DelData;
    }
}