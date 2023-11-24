namespace JokerBooksManager.Managers
{
    partial class FrmReaderInfoList
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
            this.DgvReaderInfoList = new Sunny.UI.UIDataGridView();
            this.BtnClose = new Sunny.UI.UIButton();
            this.BtnAddNew = new Sunny.UI.UIButton();
            this.ReaderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderIdCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.读者类别Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modify = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DelData = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReaderInfoList)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvReaderInfoList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvReaderInfoList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvReaderInfoList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvReaderInfoList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvReaderInfoList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvReaderInfoList.ColumnHeadersHeight = 32;
            this.DgvReaderInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvReaderInfoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReaderId,
            this.ReaderTypeName,
            this.ReaderName,
            this.ReaderSex,
            this.ReaderNumber,
            this.ReaderIdCard,
            this.ReaderTel,
            this.ReaderRemark,
            this.读者类别Id,
            this.Modify,
            this.DelData});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvReaderInfoList.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvReaderInfoList.EnableHeadersVisualStyles = false;
            this.DgvReaderInfoList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DgvReaderInfoList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(69)))));
            this.DgvReaderInfoList.Location = new System.Drawing.Point(3, 38);
            this.DgvReaderInfoList.Name = "DgvReaderInfoList";
            this.DgvReaderInfoList.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvReaderInfoList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvReaderInfoList.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DgvReaderInfoList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvReaderInfoList.RowTemplate.Height = 30;
            this.DgvReaderInfoList.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvReaderInfoList.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.DgvReaderInfoList.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.DgvReaderInfoList.SelectedIndex = -1;
            this.DgvReaderInfoList.Size = new System.Drawing.Size(1902, 733);
            this.DgvReaderInfoList.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvReaderInfoList.Style = Sunny.UI.UIStyle.Green;
            this.DgvReaderInfoList.TabIndex = 3;
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
            this.BtnClose.Location = new System.Drawing.Point(1550, 812);
            this.BtnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnClose.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnClose.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnClose.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnClose.Size = new System.Drawing.Size(100, 35);
            this.BtnClose.Style = Sunny.UI.UIStyle.Green;
            this.BtnClose.TabIndex = 5;
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
            this.BtnAddNew.Location = new System.Drawing.Point(893, 812);
            this.BtnAddNew.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.BtnAddNew.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.BtnAddNew.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnAddNew.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.BtnAddNew.Size = new System.Drawing.Size(100, 35);
            this.BtnAddNew.Style = Sunny.UI.UIStyle.Green;
            this.BtnAddNew.TabIndex = 4;
            this.BtnAddNew.Text = "新增读者";
            this.BtnAddNew.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // ReaderId
            // 
            this.ReaderId.DataPropertyName = "ReaderId";
            this.ReaderId.HeaderText = "读者编号";
            this.ReaderId.MinimumWidth = 8;
            this.ReaderId.Name = "ReaderId";
            this.ReaderId.Width = 150;
            // 
            // ReaderTypeName
            // 
            this.ReaderTypeName.DataPropertyName = "ReaderTypeId";
            this.ReaderTypeName.HeaderText = "读者类别";
            this.ReaderTypeName.MinimumWidth = 8;
            this.ReaderTypeName.Name = "ReaderTypeName";
            this.ReaderTypeName.Width = 150;
            // 
            // ReaderName
            // 
            this.ReaderName.DataPropertyName = "ReaderName";
            this.ReaderName.HeaderText = "读者姓名";
            this.ReaderName.MinimumWidth = 8;
            this.ReaderName.Name = "ReaderName";
            this.ReaderName.Width = 150;
            // 
            // ReaderSex
            // 
            this.ReaderSex.DataPropertyName = "ReaderSex";
            this.ReaderSex.HeaderText = "读者性别";
            this.ReaderSex.MinimumWidth = 8;
            this.ReaderSex.Name = "ReaderSex";
            this.ReaderSex.Width = 150;
            // 
            // ReaderNumber
            // 
            this.ReaderNumber.DataPropertyName = "ReaderNumber";
            this.ReaderNumber.HeaderText = "读者编码";
            this.ReaderNumber.MinimumWidth = 8;
            this.ReaderNumber.Name = "ReaderNumber";
            this.ReaderNumber.Width = 150;
            // 
            // ReaderIdCard
            // 
            this.ReaderIdCard.DataPropertyName = "ReaderIdCard";
            this.ReaderIdCard.HeaderText = "读者身份证";
            this.ReaderIdCard.MinimumWidth = 8;
            this.ReaderIdCard.Name = "ReaderIdCard";
            this.ReaderIdCard.Width = 150;
            // 
            // ReaderTel
            // 
            this.ReaderTel.DataPropertyName = "ReaderTel";
            this.ReaderTel.HeaderText = "电话";
            this.ReaderTel.MinimumWidth = 8;
            this.ReaderTel.Name = "ReaderTel";
            this.ReaderTel.Width = 150;
            // 
            // ReaderRemark
            // 
            this.ReaderRemark.DataPropertyName = "ReaderRemark";
            this.ReaderRemark.HeaderText = "备注信息";
            this.ReaderRemark.MinimumWidth = 8;
            this.ReaderRemark.Name = "ReaderRemark";
            this.ReaderRemark.Width = 150;
            // 
            // 读者类别Id
            // 
            this.读者类别Id.DataPropertyName = "ReaderTypeId";
            this.读者类别Id.HeaderText = "读者类别Id";
            this.读者类别Id.MinimumWidth = 8;
            this.读者类别Id.Name = "读者类别Id";
            this.读者类别Id.ToolTipText = "读者类别Id";
            this.读者类别Id.Visible = false;
            this.读者类别Id.Width = 50;
            // 
            // Modify
            // 
            this.Modify.HeaderText = "修改";
            this.Modify.MinimumWidth = 8;
            this.Modify.Name = "Modify";
            this.Modify.Text = "修改";
            this.Modify.ToolTipText = "修改";
            this.Modify.UseColumnTextForLinkValue = true;
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
            // 
            // FrmReaderInfoList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 1020);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAddNew);
            this.Controls.Add(this.DgvReaderInfoList);
            this.MaximizeBox = false;
            this.Name = "FrmReaderInfoList";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.Style = Sunny.UI.UIStyle.Green;
            this.Text = "读者信息列表";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            this.Load += new System.EventHandler(this.FrmReaderInfoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvReaderInfoList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView DgvReaderInfoList;
        private Sunny.UI.UIButton BtnClose;
        private Sunny.UI.UIButton BtnAddNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderIdCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn 读者类别Id;
        private System.Windows.Forms.DataGridViewLinkColumn Modify;
        private System.Windows.Forms.DataGridViewLinkColumn DelData;
    }
}