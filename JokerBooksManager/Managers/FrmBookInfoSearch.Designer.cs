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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnClose = new Sunny.UI.UIButton();
            this.BtnSearch = new Sunny.UI.UIButton();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.CboSearchType = new Sunny.UI.UIComboBox();
            this.TxtKeys = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.BtnClose.Location = new System.Drawing.Point(1128, 34);
            this.BtnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnClose.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnClose.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnClose.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnClose.Size = new System.Drawing.Size(114, 35);
            this.BtnClose.Style = Sunny.UI.UIStyle.Green;
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "关闭";
            this.BtnClose.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnSearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnSearch.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnSearch.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnSearch.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnSearch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSearch.Location = new System.Drawing.Point(968, 33);
            this.BtnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnSearch.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnSearch.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnSearch.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnSearch.Size = new System.Drawing.Size(137, 35);
            this.BtnSearch.Style = Sunny.UI.UIStyle.Green;
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "查询图书";
            this.BtnSearch.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DgvBookInfo
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvBookInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.DgvBookInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvBookInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBookInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
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
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBookInfo.DefaultCellStyle = dataGridViewCellStyle18;
            this.DgvBookInfo.EnableHeadersVisualStyles = false;
            this.DgvBookInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DgvBookInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(69)))));
            this.DgvBookInfo.Location = new System.Drawing.Point(3, 169);
            this.DgvBookInfo.Name = "DgvBookInfo";
            this.DgvBookInfo.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBookInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.DgvBookInfo.RowHeadersWidth = 62;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DgvBookInfo.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.DgvBookInfo.RowTemplate.Height = 30;
            this.DgvBookInfo.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvBookInfo.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.DgvBookInfo.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.DgvBookInfo.SelectedIndex = -1;
            this.DgvBookInfo.Size = new System.Drawing.Size(1263, 499);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Controls.Add(this.uiLabel2);
            this.groupBox1.Controls.Add(this.BtnClose);
            this.groupBox1.Controls.Add(this.TxtKeys);
            this.groupBox1.Controls.Add(this.CboSearchType);
            this.groupBox1.Controls.Add(this.uiLabel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1263, 106);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询操作";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(374, 37);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(96, 32);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Green;
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "查询方";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CboSearchType
            // 
            this.CboSearchType.DataSource = null;
            this.CboSearchType.FillColor = System.Drawing.Color.White;
            this.CboSearchType.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.CboSearchType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CboSearchType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(212)))));
            this.CboSearchType.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.CboSearchType.Items.AddRange(new object[] {
            "按照图书编码",
            "按照出版社",
            "按照图书类别",
            "按照作者"});
            this.CboSearchType.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.CboSearchType.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.CboSearchType.Location = new System.Drawing.Point(498, 37);
            this.CboSearchType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CboSearchType.MinimumSize = new System.Drawing.Size(63, 0);
            this.CboSearchType.Name = "CboSearchType";
            this.CboSearchType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.CboSearchType.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.CboSearchType.Size = new System.Drawing.Size(150, 32);
            this.CboSearchType.Style = Sunny.UI.UIStyle.Green;
            this.CboSearchType.TabIndex = 2;
            this.CboSearchType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.CboSearchType.Watermark = "";
            // 
            // TxtKeys
            // 
            this.TxtKeys.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.TxtKeys.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.TxtKeys.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.TxtKeys.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.TxtKeys.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.TxtKeys.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.TxtKeys.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtKeys.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.TxtKeys.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtKeys.Location = new System.Drawing.Point(782, 36);
            this.TxtKeys.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtKeys.MinimumSize = new System.Drawing.Size(1, 16);
            this.TxtKeys.Name = "TxtKeys";
            this.TxtKeys.Padding = new System.Windows.Forms.Padding(5);
            this.TxtKeys.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.TxtKeys.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.TxtKeys.ShowText = false;
            this.TxtKeys.Size = new System.Drawing.Size(150, 32);
            this.TxtKeys.Style = Sunny.UI.UIStyle.Green;
            this.TxtKeys.TabIndex = 4;
            this.TxtKeys.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtKeys.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(676, 36);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(99, 32);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Green;
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "关键字";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmBookInfoSearch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1334, 747);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvBookInfo);
            this.MaximizeBox = false;
            this.Name = "FrmBookInfoSearch";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.Style = Sunny.UI.UIStyle.Green;
            this.Text = "图书信息查询";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            this.Load += new System.EventHandler(this.FrmBookInfoSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton BtnClose;
        private Sunny.UI.UIButton BtnSearch;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox TxtKeys;
        private Sunny.UI.UIComboBox CboSearchType;
        private Sunny.UI.UILabel uiLabel1;
    }
}