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
            this.ReaderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderIdCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ReaderTypeId,
            this.ReaderName,
            this.ReaderSex,
            this.ReaderNumber,
            this.ReaderIdCard,
            this.ReaderTel,
            this.ReaderRemark,
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
            this.DgvReaderInfoList.Size = new System.Drawing.Size(1662, 528);
            this.DgvReaderInfoList.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.DgvReaderInfoList.Style = Sunny.UI.UIStyle.Green;
            this.DgvReaderInfoList.TabIndex = 3;
            // 
            // ReaderId
            // 
            this.ReaderId.DataPropertyName = "ReaderId";
            this.ReaderId.HeaderText = "读者编号";
            this.ReaderId.MinimumWidth = 8;
            this.ReaderId.Name = "ReaderId";
            this.ReaderId.Width = 200;
            // 
            // ReaderTypeId
            // 
            this.ReaderTypeId.DataPropertyName = "ReaderTypeId";
            this.ReaderTypeId.HeaderText = "读者分类";
            this.ReaderTypeId.MinimumWidth = 8;
            this.ReaderTypeId.Name = "ReaderTypeId";
            this.ReaderTypeId.Width = 200;
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
            // Modify
            // 
            this.Modify.HeaderText = "修改";
            this.Modify.MinimumWidth = 8;
            this.Modify.Name = "Modify";
            this.Modify.Text = "修改";
            this.Modify.ToolTipText = "修改";
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
            // FrmReaderInfoList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1668, 862);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.DgvReaderInfoList);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderIdCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderRemark;
        private System.Windows.Forms.DataGridViewLinkColumn Modify;
        private System.Windows.Forms.DataGridViewLinkColumn DelData;
    }
}