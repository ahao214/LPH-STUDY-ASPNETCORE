namespace JokerBooksManager.Managers
{
    partial class FrmBookInfoSearch
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
            this.DgvBookInfo = new Sunny.UI.UIDataGridView();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConvrImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.BookNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookSamry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modify = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DelData = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookInfo)).BeginInit();
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
            this.BtnClose.Location = new System.Drawing.Point(207, 440);
            this.BtnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnClose.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnClose.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnClose.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnClose.Size = new System.Drawing.Size(100, 35);
            this.BtnClose.Style = Sunny.UI.UIStyle.Green;
            this.BtnClose.TabIndex = 16;
            this.BtnClose.Text = "关闭";
            this.BtnClose.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.BtnAddNew.Location = new System.Drawing.Point(12, 440);
            this.BtnAddNew.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnAddNew.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnAddNew.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnAddNew.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnAddNew.Size = new System.Drawing.Size(134, 35);
            this.BtnAddNew.Style = Sunny.UI.UIStyle.Green;
            this.BtnAddNew.TabIndex = 15;
            this.BtnAddNew.Text = "新增图书";
            this.BtnAddNew.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // DgvBookInfo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvBookInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvBookInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvBookInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBookInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvBookInfo.ColumnHeadersHeight = 32;
            this.DgvBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvBookInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.BookName,
            this.ConvrImage,
            this.BookNumber,
            this.PublishName,
            this.PublishDate,
            this.BookTypeName,
            this.AuthorName,
            this.BookPrice,
            this.InputName,
            this.BorrowCount,
            this.TotalCount,
            this.BookSamry,
            this.Modify,
            this.DelData});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBookInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvBookInfo.EnableHeadersVisualStyles = false;
            this.DgvBookInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DgvBookInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(69)))));
            this.DgvBookInfo.Location = new System.Drawing.Point(12, 57);
            this.DgvBookInfo.Name = "DgvBookInfo";
            this.DgvBookInfo.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBookInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvBookInfo.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DgvBookInfo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvBookInfo.RowTemplate.Height = 30;
            this.DgvBookInfo.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvBookInfo.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.DgvBookInfo.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.DgvBookInfo.SelectedIndex = -1;
            this.DgvBookInfo.Size = new System.Drawing.Size(1656, 323);
            this.DgvBookInfo.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvBookInfo.Style = Sunny.UI.UIStyle.Green;
            this.DgvBookInfo.TabIndex = 17;
            // 
            // BookId
            // 
            this.BookId.DataPropertyName = "BookId";
            this.BookId.HeaderText = "自动编号";
            this.BookId.MinimumWidth = 8;
            this.BookId.Name = "BookId";
            this.BookId.ToolTipText = "自动编号";
            this.BookId.Width = 150;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "图书名称";
            this.BookName.MinimumWidth = 8;
            this.BookName.Name = "BookName";
            this.BookName.ToolTipText = "图书名称";
            this.BookName.Width = 200;
            // 
            // ConvrImage
            // 
            this.ConvrImage.DataPropertyName = "ConvrImage";
            this.ConvrImage.HeaderText = "图书封面";
            this.ConvrImage.MinimumWidth = 8;
            this.ConvrImage.Name = "ConvrImage";
            this.ConvrImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ConvrImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ConvrImage.Width = 150;
            // 
            // BookNumber
            // 
            this.BookNumber.DataPropertyName = "BookNumber";
            this.BookNumber.HeaderText = "图书编码";
            this.BookNumber.MinimumWidth = 8;
            this.BookNumber.Name = "BookNumber";
            this.BookNumber.ToolTipText = "图书编码";
            this.BookNumber.Width = 150;
            // 
            // PublishName
            // 
            this.PublishName.DataPropertyName = "PublishName";
            this.PublishName.HeaderText = "出版社";
            this.PublishName.MinimumWidth = 8;
            this.PublishName.Name = "PublishName";
            this.PublishName.ToolTipText = "出版社";
            this.PublishName.Width = 150;
            // 
            // PublishDate
            // 
            this.PublishDate.DataPropertyName = "PublishDate";
            this.PublishDate.HeaderText = "出版时间";
            this.PublishDate.MinimumWidth = 8;
            this.PublishDate.Name = "PublishDate";
            this.PublishDate.ToolTipText = "出版时间";
            this.PublishDate.Width = 150;
            // 
            // BookTypeName
            // 
            this.BookTypeName.DataPropertyName = "BookTypeName";
            this.BookTypeName.HeaderText = "图书类别";
            this.BookTypeName.MinimumWidth = 8;
            this.BookTypeName.Name = "BookTypeName";
            this.BookTypeName.ToolTipText = "图书类别";
            this.BookTypeName.Width = 150;
            // 
            // AuthorName
            // 
            this.AuthorName.DataPropertyName = "AuthorName";
            this.AuthorName.HeaderText = "作者";
            this.AuthorName.MinimumWidth = 8;
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.ToolTipText = "作者";
            this.AuthorName.Width = 150;
            // 
            // BookPrice
            // 
            this.BookPrice.DataPropertyName = "BookPrice";
            this.BookPrice.HeaderText = "图书价格";
            this.BookPrice.MinimumWidth = 8;
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.ToolTipText = "图书价格";
            this.BookPrice.Width = 150;
            // 
            // InputName
            // 
            this.InputName.DataPropertyName = "InputName";
            this.InputName.HeaderText = "录入员";
            this.InputName.MinimumWidth = 8;
            this.InputName.Name = "InputName";
            this.InputName.ToolTipText = "录入员";
            this.InputName.Width = 150;
            // 
            // BorrowCount
            // 
            this.BorrowCount.DataPropertyName = "BorrowCount";
            this.BorrowCount.HeaderText = "借阅次数";
            this.BorrowCount.MinimumWidth = 8;
            this.BorrowCount.Name = "BorrowCount";
            this.BorrowCount.ToolTipText = "借阅次数";
            this.BorrowCount.Width = 150;
            // 
            // TotalCount
            // 
            this.TotalCount.DataPropertyName = "TotalCount";
            this.TotalCount.HeaderText = "总册数";
            this.TotalCount.MinimumWidth = 8;
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.ToolTipText = "总册数";
            this.TotalCount.Width = 150;
            // 
            // BookSamry
            // 
            this.BookSamry.DataPropertyName = "BookSamry";
            this.BookSamry.HeaderText = "简介";
            this.BookSamry.MinimumWidth = 8;
            this.BookSamry.Name = "BookSamry";
            this.BookSamry.ToolTipText = "简介";
            this.BookSamry.Width = 150;
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
            // FrmBookInfoSearch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1717, 682);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAddNew);
            this.Controls.Add(this.DgvBookInfo);
            this.Name = "FrmBookInfoSearch";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.Style = Sunny.UI.UIStyle.Green;
            this.Text = "图书信息查询";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton BtnClose;
        private Sunny.UI.UIButton BtnAddNew;
        private Sunny.UI.UIDataGridView DgvBookInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewImageColumn ConvrImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookSamry;
        private System.Windows.Forms.DataGridViewLinkColumn Modify;
        private System.Windows.Forms.DataGridViewLinkColumn DelData;
    }
}