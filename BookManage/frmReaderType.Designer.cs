namespace BookManage
{
    partial class frmReaderType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReaderType));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbFirstRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNextRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLastRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFinalRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelate = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.txtCanContinueTimes = new System.Windows.Forms.TextBox();
            this.txtCanLendQty = new System.Windows.Forms.TextBox();
            this.txtPunishRate = new System.Windows.Forms.TextBox();
            this.txtCanLendDay = new System.Windows.Forms.TextBox();
            this.txtDateValid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvReaderType = new System.Windows.Forms.DataGridView();
            this.txtrdType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labImformation = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaderType)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFirstRecord,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.tsbNextRecord,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.tsbLastRecord,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.tsbFinalRecord,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.tsbAdd,
            this.toolStripLabel5,
            this.toolStripSeparator5,
            this.tsbUpdate,
            this.toolStripLabel6,
            this.toolStripSeparator6,
            this.tsbDelate,
            this.toolStripLabel7,
            this.toolStripSeparator7,
            this.tsbBack,
            this.toolStripLabel8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(697, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbFirstRecord
            // 
            this.tsbFirstRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFirstRecord.Image = ((System.Drawing.Image)(resources.GetObject("tsbFirstRecord.Image")));
            this.tsbFirstRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFirstRecord.Name = "tsbFirstRecord";
            this.tsbFirstRecord.Size = new System.Drawing.Size(23, 22);
            this.tsbFirstRecord.Text = "toolStripButton1";
            this.tsbFirstRecord.Click += new System.EventHandler(this.tsbFirstRecord_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel1.Text = "首记录";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbNextRecord
            // 
            this.tsbNextRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNextRecord.Image = ((System.Drawing.Image)(resources.GetObject("tsbNextRecord.Image")));
            this.tsbNextRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNextRecord.Name = "tsbNextRecord";
            this.tsbNextRecord.Size = new System.Drawing.Size(23, 22);
            this.tsbNextRecord.Text = "toolStripButton2";
            this.tsbNextRecord.Click += new System.EventHandler(this.tsbNextRecord_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel2.Text = "下记录";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbLastRecord
            // 
            this.tsbLastRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLastRecord.Image = ((System.Drawing.Image)(resources.GetObject("tsbLastRecord.Image")));
            this.tsbLastRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLastRecord.Name = "tsbLastRecord";
            this.tsbLastRecord.Size = new System.Drawing.Size(23, 22);
            this.tsbLastRecord.Text = "toolStripButton3";
            this.tsbLastRecord.Click += new System.EventHandler(this.tsbLastRecord_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel3.Text = "上记录";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbFinalRecord
            // 
            this.tsbFinalRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFinalRecord.Image = ((System.Drawing.Image)(resources.GetObject("tsbFinalRecord.Image")));
            this.tsbFinalRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFinalRecord.Name = "tsbFinalRecord";
            this.tsbFinalRecord.Size = new System.Drawing.Size(23, 22);
            this.tsbFinalRecord.Text = "toolStripButton4";
            this.tsbFinalRecord.Click += new System.EventHandler(this.tsbFinalRecord_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel4.Text = "尾记录";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "toolStripButton5";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel5.Text = "添加";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(23, 22);
            this.tsbUpdate.Text = "toolStripButton6";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel6.Text = "修改";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbDelate
            // 
            this.tsbDelate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelate.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelate.Image")));
            this.tsbDelate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelate.Name = "tsbDelate";
            this.tsbDelate.Size = new System.Drawing.Size(23, 22);
            this.tsbDelate.Text = "toolStripButton7";
            this.tsbDelate.Click += new System.EventHandler(this.tsbDelate_Click);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel7.Text = "删除";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbBack
            // 
            this.tsbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBack.Image = ((System.Drawing.Image)(resources.GetObject("tsbBack.Image")));
            this.tsbBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBack.Name = "tsbBack";
            this.tsbBack.Size = new System.Drawing.Size(23, 22);
            this.tsbBack.Text = "toolStripButton8";
            this.tsbBack.Click += new System.EventHandler(this.tsbBack_Click);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel8.Text = "返回";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "类型名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "可续借次数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "可借书数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "罚款率";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(102, 69);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(125, 21);
            this.txtTypeName.TabIndex = 5;
            // 
            // txtCanContinueTimes
            // 
            this.txtCanContinueTimes.Location = new System.Drawing.Point(102, 102);
            this.txtCanContinueTimes.Name = "txtCanContinueTimes";
            this.txtCanContinueTimes.Size = new System.Drawing.Size(125, 21);
            this.txtCanContinueTimes.TabIndex = 6;
            // 
            // txtCanLendQty
            // 
            this.txtCanLendQty.Location = new System.Drawing.Point(320, 47);
            this.txtCanLendQty.Name = "txtCanLendQty";
            this.txtCanLendQty.Size = new System.Drawing.Size(125, 21);
            this.txtCanLendQty.TabIndex = 7;
            // 
            // txtPunishRate
            // 
            this.txtPunishRate.Location = new System.Drawing.Point(320, 93);
            this.txtPunishRate.Name = "txtPunishRate";
            this.txtPunishRate.Size = new System.Drawing.Size(125, 21);
            this.txtPunishRate.TabIndex = 8;
            // 
            // txtCanLendDay
            // 
            this.txtCanLendDay.Location = new System.Drawing.Point(543, 46);
            this.txtCanLendDay.Name = "txtCanLendDay";
            this.txtCanLendDay.Size = new System.Drawing.Size(125, 21);
            this.txtCanLendDay.TabIndex = 9;
            // 
            // txtDateValid
            // 
            this.txtDateValid.Location = new System.Drawing.Point(543, 92);
            this.txtDateValid.Name = "txtDateValid";
            this.txtDateValid.Size = new System.Drawing.Size(108, 21);
            this.txtDateValid.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "可借书天数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "证件有效日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(652, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "年";
            // 
            // dgvReaderType
            // 
            this.dgvReaderType.AllowUserToAddRows = false;
            this.dgvReaderType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaderType.Location = new System.Drawing.Point(13, 134);
            this.dgvReaderType.Name = "dgvReaderType";
            this.dgvReaderType.RowTemplate.Height = 23;
            this.dgvReaderType.Size = new System.Drawing.Size(671, 280);
            this.dgvReaderType.TabIndex = 14;
            this.dgvReaderType.SelectionChanged += new System.EventHandler(this.dgvReaderType_SelectionChanged);
            // 
            // txtrdType
            // 
            this.txtrdType.Location = new System.Drawing.Point(102, 38);
            this.txtrdType.Name = "txtrdType";
            this.txtrdType.Size = new System.Drawing.Size(125, 21);
            this.txtrdType.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "读者类别";
            // 
            // labImformation
            // 
            this.labImformation.AutoSize = true;
            this.labImformation.ForeColor = System.Drawing.Color.Red;
            this.labImformation.Location = new System.Drawing.Point(13, 430);
            this.labImformation.Name = "labImformation";
            this.labImformation.Size = new System.Drawing.Size(41, 12);
            this.labImformation.TabIndex = 17;
            this.labImformation.Text = "状态：";
            // 
            // frmReaderType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 459);
            this.Controls.Add(this.labImformation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtrdType);
            this.Controls.Add(this.dgvReaderType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDateValid);
            this.Controls.Add(this.txtCanLendDay);
            this.Controls.Add(this.txtPunishRate);
            this.Controls.Add(this.txtCanLendQty);
            this.Controls.Add(this.txtCanContinueTimes);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmReaderType";
            this.Text = "读者类型管理";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaderType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripButton tsbFirstRecord;
        private System.Windows.Forms.ToolStripButton tsbNextRecord;
        private System.Windows.Forms.ToolStripButton tsbLastRecord;
        private System.Windows.Forms.ToolStripButton tsbFinalRecord;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbDelate;
        private System.Windows.Forms.ToolStripButton tsbBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.TextBox txtCanContinueTimes;
        private System.Windows.Forms.TextBox txtCanLendQty;
        private System.Windows.Forms.TextBox txtPunishRate;
        private System.Windows.Forms.TextBox txtCanLendDay;
        private System.Windows.Forms.TextBox txtDateValid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvReaderType;
        private System.Windows.Forms.TextBox txtrdType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labImformation;
    }
}