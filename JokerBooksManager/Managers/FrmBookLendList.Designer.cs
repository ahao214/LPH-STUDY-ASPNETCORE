namespace JokerBooksManager.Managers
{
    partial class FrmBookLendList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvBorrowBook = new Sunny.UI.UIDataGridView();
            this.BorrowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowBookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShouldDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modify = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DelData = new System.Windows.Forms.DataGridViewLinkColumn();
            this.BtnClose = new Sunny.UI.UIButton();
            this.BtnAddNew = new Sunny.UI.UIButton();
            this.LblPageCount = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.LblPage = new Sunny.UI.UILabel();
            this.BtnStartPage = new Sunny.UI.UIButton();
            this.BtnEndPage = new Sunny.UI.UIButton();
            this.BtnNextPage = new Sunny.UI.UIButton();
            this.BtnPrevPage = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBorrowBook)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvBorrowBook
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvBorrowBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvBorrowBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvBorrowBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBorrowBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvBorrowBook.ColumnHeadersHeight = 32;
            this.DgvBorrowBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvBorrowBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BorrowId,
            this.BookName,
            this.ReaderName,
            this.BorrowBookCount,
            this.BorrowDate,
            this.ShouldDate,
            this.ActualDate,
            this.Remark,
            this.Modify,
            this.DelData});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBorrowBook.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvBorrowBook.EnableHeadersVisualStyles = false;
            this.DgvBorrowBook.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DgvBorrowBook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(69)))));
            this.DgvBorrowBook.Location = new System.Drawing.Point(3, 38);
            this.DgvBorrowBook.Name = "DgvBorrowBook";
            this.DgvBorrowBook.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBorrowBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvBorrowBook.RowHeadersWidth = 62;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DgvBorrowBook.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DgvBorrowBook.RowTemplate.Height = 30;
            this.DgvBorrowBook.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvBorrowBook.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.DgvBorrowBook.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.DgvBorrowBook.SelectedIndex = -1;
            this.DgvBorrowBook.Size = new System.Drawing.Size(1441, 323);
            this.DgvBorrowBook.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvBorrowBook.Style = Sunny.UI.UIStyle.Green;
            this.DgvBorrowBook.TabIndex = 15;
            this.DgvBorrowBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBorrowBook_CellContentClick);
            // 
            // BorrowId
            // 
            this.BorrowId.DataPropertyName = "BorrowId";
            this.BorrowId.HeaderText = "自动编号";
            this.BorrowId.MinimumWidth = 8;
            this.BorrowId.Name = "BorrowId";
            this.BorrowId.ToolTipText = "自动编号";
            this.BorrowId.Width = 150;
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
            // ReaderName
            // 
            this.ReaderName.DataPropertyName = "ReaderName";
            this.ReaderName.HeaderText = "读者姓名";
            this.ReaderName.MinimumWidth = 8;
            this.ReaderName.Name = "ReaderName";
            this.ReaderName.ToolTipText = "图书编码";
            this.ReaderName.Width = 150;
            // 
            // BorrowBookCount
            // 
            this.BorrowBookCount.DataPropertyName = "BorrowBookCount";
            this.BorrowBookCount.HeaderText = "借出次数";
            this.BorrowBookCount.MinimumWidth = 8;
            this.BorrowBookCount.Name = "BorrowBookCount";
            this.BorrowBookCount.ToolTipText = "出版社";
            this.BorrowBookCount.Width = 150;
            // 
            // BorrowDate
            // 
            this.BorrowDate.DataPropertyName = "BorrowDate";
            this.BorrowDate.HeaderText = "借出时间";
            this.BorrowDate.MinimumWidth = 8;
            this.BorrowDate.Name = "BorrowDate";
            this.BorrowDate.ToolTipText = "出版时间";
            this.BorrowDate.Width = 150;
            // 
            // ShouldDate
            // 
            this.ShouldDate.DataPropertyName = "ShouldDate";
            this.ShouldDate.HeaderText = "应该归还时间";
            this.ShouldDate.MinimumWidth = 8;
            this.ShouldDate.Name = "ShouldDate";
            this.ShouldDate.ToolTipText = "图书类别";
            this.ShouldDate.Width = 150;
            // 
            // ActualDate
            // 
            this.ActualDate.DataPropertyName = "ActualDate";
            this.ActualDate.HeaderText = "实际归还时间";
            this.ActualDate.MinimumWidth = 8;
            this.ActualDate.Name = "ActualDate";
            this.ActualDate.ToolTipText = "作者";
            this.ActualDate.Width = 150;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.MinimumWidth = 8;
            this.Remark.Name = "Remark";
            this.Remark.ToolTipText = "图书价格";
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
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnClose.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnClose.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnClose.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnClose.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnClose.Location = new System.Drawing.Point(1284, 393);
            this.BtnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnClose.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnClose.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnClose.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnClose.Size = new System.Drawing.Size(100, 35);
            this.BtnClose.Style = Sunny.UI.UIStyle.Green;
            this.BtnClose.TabIndex = 17;
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
            this.BtnAddNew.Location = new System.Drawing.Point(1089, 393);
            this.BtnAddNew.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnAddNew.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnAddNew.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnAddNew.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnAddNew.Size = new System.Drawing.Size(134, 35);
            this.BtnAddNew.Style = Sunny.UI.UIStyle.Green;
            this.BtnAddNew.TabIndex = 16;
            this.BtnAddNew.Text = "新增图书";
            this.BtnAddNew.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // LblPageCount
            // 
            this.LblPageCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblPageCount.Location = new System.Drawing.Point(986, 393);
            this.LblPageCount.Name = "LblPageCount";
            this.LblPageCount.Size = new System.Drawing.Size(48, 32);
            this.LblPageCount.Style = Sunny.UI.UIStyle.Green;
            this.LblPageCount.TabIndex = 28;
            this.LblPageCount.Text = "1";
            this.LblPageCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(942, 393);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(48, 32);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Green;
            this.uiLabel2.TabIndex = 27;
            this.uiLabel2.Text = "/";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblPage
            // 
            this.LblPage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblPage.Location = new System.Drawing.Point(906, 393);
            this.LblPage.Name = "LblPage";
            this.LblPage.Size = new System.Drawing.Size(48, 32);
            this.LblPage.Style = Sunny.UI.UIStyle.Green;
            this.LblPage.TabIndex = 26;
            this.LblPage.Text = "1";
            this.LblPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnStartPage
            // 
            this.BtnStartPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStartPage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnStartPage.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnStartPage.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnStartPage.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnStartPage.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnStartPage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnStartPage.Location = new System.Drawing.Point(343, 393);
            this.BtnStartPage.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnStartPage.Name = "BtnStartPage";
            this.BtnStartPage.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnStartPage.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnStartPage.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnStartPage.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnStartPage.Size = new System.Drawing.Size(100, 35);
            this.BtnStartPage.Style = Sunny.UI.UIStyle.Green;
            this.BtnStartPage.TabIndex = 25;
            this.BtnStartPage.Text = "首页";
            this.BtnStartPage.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // BtnEndPage
            // 
            this.BtnEndPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEndPage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnEndPage.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnEndPage.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnEndPage.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnEndPage.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnEndPage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnEndPage.Location = new System.Drawing.Point(784, 393);
            this.BtnEndPage.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnEndPage.Name = "BtnEndPage";
            this.BtnEndPage.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnEndPage.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnEndPage.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnEndPage.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnEndPage.Size = new System.Drawing.Size(100, 35);
            this.BtnEndPage.Style = Sunny.UI.UIStyle.Green;
            this.BtnEndPage.TabIndex = 24;
            this.BtnEndPage.Text = "尾页";
            this.BtnEndPage.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // BtnNextPage
            // 
            this.BtnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNextPage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnNextPage.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnNextPage.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnNextPage.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnNextPage.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnNextPage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnNextPage.Location = new System.Drawing.Point(644, 393);
            this.BtnNextPage.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnNextPage.Name = "BtnNextPage";
            this.BtnNextPage.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnNextPage.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnNextPage.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnNextPage.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnNextPage.Size = new System.Drawing.Size(100, 35);
            this.BtnNextPage.Style = Sunny.UI.UIStyle.Green;
            this.BtnNextPage.TabIndex = 23;
            this.BtnNextPage.Text = "下一页";
            this.BtnNextPage.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // BtnPrevPage
            // 
            this.BtnPrevPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrevPage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnPrevPage.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnPrevPage.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnPrevPage.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnPrevPage.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnPrevPage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPrevPage.Location = new System.Drawing.Point(483, 393);
            this.BtnPrevPage.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnPrevPage.Name = "BtnPrevPage";
            this.BtnPrevPage.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnPrevPage.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnPrevPage.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnPrevPage.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnPrevPage.Size = new System.Drawing.Size(100, 35);
            this.BtnPrevPage.Style = Sunny.UI.UIStyle.Green;
            this.BtnPrevPage.TabIndex = 22;
            this.BtnPrevPage.Text = "上一页";
            this.BtnPrevPage.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // FrmBookLendList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1467, 690);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.LblPageCount);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.LblPage);
            this.Controls.Add(this.BtnStartPage);
            this.Controls.Add(this.BtnEndPage);
            this.Controls.Add(this.BtnNextPage);
            this.Controls.Add(this.BtnPrevPage);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAddNew);
            this.Controls.Add(this.DgvBorrowBook);
            this.MaximizeBox = false;
            this.Name = "FrmBookLendList";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.Style = Sunny.UI.UIStyle.Green;
            this.Text = "图书借阅记录";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBorrowBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView DgvBorrowBook;
        private Sunny.UI.UIButton BtnClose;
        private Sunny.UI.UIButton BtnAddNew;
        private Sunny.UI.UILabel LblPageCount;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel LblPage;
        private Sunny.UI.UIButton BtnStartPage;
        private Sunny.UI.UIButton BtnEndPage;
        private Sunny.UI.UIButton BtnNextPage;
        private Sunny.UI.UIButton BtnPrevPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowBookCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShouldDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewLinkColumn Modify;
        private System.Windows.Forms.DataGridViewLinkColumn DelData;
    }
}