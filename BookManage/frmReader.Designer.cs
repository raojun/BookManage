namespace BookManage
{
    partial class frmReader
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.btuQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btuToExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancelDoc = new System.Windows.Forms.Button();
            this.btnUnlossDoc = new System.Windows.Forms.Button();
            this.btnLossDoc = new System.Windows.Forms.Button();
            this.btnChangeDoc = new System.Windows.Forms.Button();
            this.btnNewDoc = new System.Windows.Forms.Button();
            this.lblBorrowInfo = new System.Windows.Forms.Label();
            this.dgvReader = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.btnUpdateReader = new System.Windows.Forms.Button();
            this.btnCancelChange = new System.Windows.Forms.Button();
            this.btnLoadPictureFile = new System.Windows.Forms.Button();
            this.picboxPhoto = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.toolStripLabel2,
            this.toolStripComboBox2,
            this.toolStripLabel3,
            this.toolStripComboBox3,
            this.btuQuery,
            this.toolStripLabel4,
            this.toolStripSeparator1,
            this.btuToExcel,
            this.toolStripLabel5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(952, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel1.Text = "读者类别：";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel2.Text = "单位：";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel3.Text = "姓名：";
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 25);
            // 
            // btuQuery
            // 
            this.btuQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btuQuery.Image = global::BookManage.Properties.Resources.search;
            this.btuQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btuQuery.Name = "btuQuery";
            this.btuQuery.Size = new System.Drawing.Size(23, 22);
            this.btuQuery.Text = "toolStripButton1";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel4.Text = "查找";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btuToExcel
            // 
            this.btuToExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btuToExcel.Image = global::BookManage.Properties.Resources.Excel;
            this.btuToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btuToExcel.Name = "btuToExcel";
            this.btuToExcel.Size = new System.Drawing.Size(23, 22);
            this.btuToExcel.Text = "toolStripButton1";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel5.Text = "Excel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnCancelDoc);
            this.groupBox1.Controls.Add(this.btnUnlossDoc);
            this.groupBox1.Controls.Add(this.btnLossDoc);
            this.groupBox1.Controls.Add(this.btnChangeDoc);
            this.groupBox1.Controls.Add(this.btnNewDoc);
            this.groupBox1.Controls.Add(this.lblBorrowInfo);
            this.groupBox1.Controls.Add(this.dgvReader);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 441);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询结果";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(514, 394);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "退 出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancelDoc
            // 
            this.btnCancelDoc.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancelDoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelDoc.Location = new System.Drawing.Point(412, 394);
            this.btnCancelDoc.Name = "btnCancelDoc";
            this.btnCancelDoc.Size = new System.Drawing.Size(75, 32);
            this.btnCancelDoc.TabIndex = 6;
            this.btnCancelDoc.Text = "注 销";
            this.btnCancelDoc.UseVisualStyleBackColor = true;
            this.btnCancelDoc.Click += new System.EventHandler(this.btnCancelDoc_Click);
            // 
            // btnUnlossDoc
            // 
            this.btnUnlossDoc.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUnlossDoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUnlossDoc.Location = new System.Drawing.Point(326, 394);
            this.btnUnlossDoc.Name = "btnUnlossDoc";
            this.btnUnlossDoc.Size = new System.Drawing.Size(75, 32);
            this.btnUnlossDoc.TabIndex = 5;
            this.btnUnlossDoc.Text = "解除挂失";
            this.btnUnlossDoc.UseVisualStyleBackColor = true;
            this.btnUnlossDoc.Click += new System.EventHandler(this.btnUnlossDoc_Click);
            // 
            // btnLossDoc
            // 
            this.btnLossDoc.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLossDoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLossDoc.Location = new System.Drawing.Point(239, 394);
            this.btnLossDoc.Name = "btnLossDoc";
            this.btnLossDoc.Size = new System.Drawing.Size(76, 32);
            this.btnLossDoc.TabIndex = 4;
            this.btnLossDoc.Text = "挂 失";
            this.btnLossDoc.UseVisualStyleBackColor = true;
            this.btnLossDoc.Click += new System.EventHandler(this.btnLossDoc_Click);
            // 
            // btnChangeDoc
            // 
            this.btnChangeDoc.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChangeDoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChangeDoc.Location = new System.Drawing.Point(137, 394);
            this.btnChangeDoc.Name = "btnChangeDoc";
            this.btnChangeDoc.Size = new System.Drawing.Size(91, 32);
            this.btnChangeDoc.TabIndex = 3;
            this.btnChangeDoc.Text = "变更借书证";
            this.btnChangeDoc.UseVisualStyleBackColor = true;
            this.btnChangeDoc.Click += new System.EventHandler(this.btnChangeDoc_Click);
            // 
            // btnNewDoc
            // 
            this.btnNewDoc.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNewDoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewDoc.Location = new System.Drawing.Point(34, 394);
            this.btnNewDoc.Name = "btnNewDoc";
            this.btnNewDoc.Size = new System.Drawing.Size(93, 32);
            this.btnNewDoc.TabIndex = 2;
            this.btnNewDoc.Text = "办理借书证";
            this.btnNewDoc.UseVisualStyleBackColor = true;
            this.btnNewDoc.Click += new System.EventHandler(this.btnNewDoc_Click);
            // 
            // lblBorrowInfo
            // 
            this.lblBorrowInfo.AutoSize = true;
            this.lblBorrowInfo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBorrowInfo.Location = new System.Drawing.Point(16, 364);
            this.lblBorrowInfo.Name = "lblBorrowInfo";
            this.lblBorrowInfo.Size = new System.Drawing.Size(75, 14);
            this.lblBorrowInfo.TabIndex = 1;
            this.lblBorrowInfo.Text = "借阅信息:";
            // 
            // dgvReader
            // 
            this.dgvReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReader.Location = new System.Drawing.Point(18, 29);
            this.dgvReader.Name = "dgvReader";
            this.dgvReader.ReadOnly = true;
            this.dgvReader.RowTemplate.Height = 23;
            this.dgvReader.Size = new System.Drawing.Size(571, 315);
            this.dgvReader.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picboxPhoto);
            this.groupBox2.Controls.Add(this.btnLoadPictureFile);
            this.groupBox2.Controls.Add(this.btnCancelChange);
            this.groupBox2.Controls.Add(this.btnUpdateReader);
            this.groupBox2.Controls.Add(this.btnAddReader);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(626, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 441);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读者信息";
            // 
            // btnAddReader
            // 
            this.btnAddReader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddReader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddReader.Location = new System.Drawing.Point(17, 394);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(75, 32);
            this.btnAddReader.TabIndex = 0;
            this.btnAddReader.Text = "确认办证";
            this.btnAddReader.UseVisualStyleBackColor = true;
            this.btnAddReader.Click += new System.EventHandler(this.btnAddReader_Click);
            // 
            // btnUpdateReader
            // 
            this.btnUpdateReader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdateReader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateReader.Location = new System.Drawing.Point(120, 394);
            this.btnUpdateReader.Name = "btnUpdateReader";
            this.btnUpdateReader.Size = new System.Drawing.Size(75, 32);
            this.btnUpdateReader.TabIndex = 1;
            this.btnUpdateReader.Text = "确认变更";
            this.btnUpdateReader.UseVisualStyleBackColor = true;
            this.btnUpdateReader.Click += new System.EventHandler(this.btnUpdateReader_Click);
            // 
            // btnCancelChange
            // 
            this.btnCancelChange.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancelChange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelChange.Location = new System.Drawing.Point(220, 394);
            this.btnCancelChange.Name = "btnCancelChange";
            this.btnCancelChange.Size = new System.Drawing.Size(75, 32);
            this.btnCancelChange.TabIndex = 2;
            this.btnCancelChange.Text = "撤 销";
            this.btnCancelChange.UseVisualStyleBackColor = true;
            this.btnCancelChange.Click += new System.EventHandler(this.btnCancelChange_Click);
            // 
            // btnLoadPictureFile
            // 
            this.btnLoadPictureFile.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoadPictureFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoadPictureFile.Location = new System.Drawing.Point(189, 347);
            this.btnLoadPictureFile.Name = "btnLoadPictureFile";
            this.btnLoadPictureFile.Size = new System.Drawing.Size(106, 31);
            this.btnLoadPictureFile.TabIndex = 3;
            this.btnLoadPictureFile.Text = "打开图片文件";
            this.btnLoadPictureFile.UseVisualStyleBackColor = true;
            this.btnLoadPictureFile.Click += new System.EventHandler(this.btnLoadPictureFile_Click);
            // 
            // picboxPhoto
            // 
            this.picboxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxPhoto.Location = new System.Drawing.Point(185, 22);
            this.picboxPhoto.Name = "picboxPhoto";
            this.picboxPhoto.Size = new System.Drawing.Size(110, 116);
            this.picboxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPhoto.TabIndex = 4;
            this.picboxPhoto.TabStop = false;
            // 
            // frmReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 490);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmReader";
            this.Text = "frmReader";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripButton btuQuery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btuToExcel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvReader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancelDoc;
        private System.Windows.Forms.Button btnUnlossDoc;
        private System.Windows.Forms.Button btnLossDoc;
        private System.Windows.Forms.Button btnChangeDoc;
        private System.Windows.Forms.Button btnNewDoc;
        private System.Windows.Forms.Label lblBorrowInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelChange;
        private System.Windows.Forms.Button btnUpdateReader;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.PictureBox picboxPhoto;
        private System.Windows.Forms.Button btnLoadPictureFile;


    }
}