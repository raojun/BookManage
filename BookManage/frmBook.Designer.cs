namespace BookManage
{
    partial class frmBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBook));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpLoadCover = new System.Windows.Forms.Button();
            this.ptbkCover = new System.Windows.Forms.PictureBox();
            this.rtbbkBrief = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpbkDateIn = new System.Windows.Forms.DateTimePicker();
            this.dtpbkdatePress = new System.Windows.Forms.DateTimePicker();
            this.cmbbkLanguage = new System.Windows.Forms.ComboBox();
            this.cmbbkCatalog = new System.Windows.Forms.ComboBox();
            this.txtbkNum = new System.Windows.Forms.TextBox();
            this.txtbkPrice = new System.Windows.Forms.TextBox();
            this.txtbkPages = new System.Windows.Forms.TextBox();
            this.txtbkISBN = new System.Windows.Forms.TextBox();
            this.txtbkPress = new System.Windows.Forms.TextBox();
            this.txtbkAuthor = new System.Windows.Forms.TextBox();
            this.txtbkName = new System.Windows.Forms.TextBox();
            this.txtbkCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.btnBookCancel = new System.Windows.Forms.Button();
            this.labAddInformation = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbkID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbbkStatus = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbkCover)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbbkStatus);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtbkID);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.btnUpLoadCover);
            this.groupBox1.Controls.Add(this.ptbkCover);
            this.groupBox1.Controls.Add(this.rtbbkBrief);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dtpbkDateIn);
            this.groupBox1.Controls.Add(this.dtpbkdatePress);
            this.groupBox1.Controls.Add(this.cmbbkLanguage);
            this.groupBox1.Controls.Add(this.cmbbkCatalog);
            this.groupBox1.Controls.Add(this.txtbkNum);
            this.groupBox1.Controls.Add(this.txtbkPrice);
            this.groupBox1.Controls.Add(this.txtbkPages);
            this.groupBox1.Controls.Add(this.txtbkISBN);
            this.groupBox1.Controls.Add(this.txtbkPress);
            this.groupBox1.Controls.Add(this.txtbkAuthor);
            this.groupBox1.Controls.Add(this.txtbkName);
            this.groupBox1.Controls.Add(this.txtbkCode);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnUpLoadCover
            // 
            this.btnUpLoadCover.Location = new System.Drawing.Point(684, 387);
            this.btnUpLoadCover.Name = "btnUpLoadCover";
            this.btnUpLoadCover.Size = new System.Drawing.Size(75, 23);
            this.btnUpLoadCover.TabIndex = 7;
            this.btnUpLoadCover.Text = "上传封面";
            this.btnUpLoadCover.UseVisualStyleBackColor = true;
            this.btnUpLoadCover.Click += new System.EventHandler(this.btnUpLoadCover_Click);
            // 
            // ptbkCover
            // 
            this.ptbkCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbkCover.Image = ((System.Drawing.Image)(resources.GetObject("ptbkCover.Image")));
            this.ptbkCover.Location = new System.Drawing.Point(511, 47);
            this.ptbkCover.Name = "ptbkCover";
            this.ptbkCover.Size = new System.Drawing.Size(248, 325);
            this.ptbkCover.TabIndex = 6;
            this.ptbkCover.TabStop = false;
            // 
            // rtbbkBrief
            // 
            this.rtbbkBrief.Location = new System.Drawing.Point(267, 47);
            this.rtbbkBrief.Name = "rtbbkBrief";
            this.rtbbkBrief.Size = new System.Drawing.Size(232, 325);
            this.rtbbkBrief.TabIndex = 5;
            this.rtbbkBrief.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(509, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 4;
            this.label14.Text = "图书封面";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(270, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 4;
            this.label13.Text = "内容简介";
            // 
            // dtpbkDateIn
            // 
            this.dtpbkDateIn.Location = new System.Drawing.Point(82, 320);
            this.dtpbkDateIn.Name = "dtpbkDateIn";
            this.dtpbkDateIn.Size = new System.Drawing.Size(163, 21);
            this.dtpbkDateIn.TabIndex = 3;
            // 
            // dtpbkdatePress
            // 
            this.dtpbkdatePress.Location = new System.Drawing.Point(83, 140);
            this.dtpbkdatePress.Name = "dtpbkdatePress";
            this.dtpbkdatePress.Size = new System.Drawing.Size(162, 21);
            this.dtpbkdatePress.TabIndex = 3;
            // 
            // cmbbkLanguage
            // 
            this.cmbbkLanguage.FormattingEnabled = true;
            this.cmbbkLanguage.Location = new System.Drawing.Point(83, 230);
            this.cmbbkLanguage.Name = "cmbbkLanguage";
            this.cmbbkLanguage.Size = new System.Drawing.Size(162, 20);
            this.cmbbkLanguage.TabIndex = 2;
            // 
            // cmbbkCatalog
            // 
            this.cmbbkCatalog.FormattingEnabled = true;
            this.cmbbkCatalog.Location = new System.Drawing.Point(83, 201);
            this.cmbbkCatalog.Name = "cmbbkCatalog";
            this.cmbbkCatalog.Size = new System.Drawing.Size(162, 20);
            this.cmbbkCatalog.TabIndex = 2;
            // 
            // txtbkNum
            // 
            this.txtbkNum.Location = new System.Drawing.Point(82, 351);
            this.txtbkNum.Name = "txtbkNum";
            this.txtbkNum.Size = new System.Drawing.Size(163, 21);
            this.txtbkNum.TabIndex = 1;
            // 
            // txtbkPrice
            // 
            this.txtbkPrice.Location = new System.Drawing.Point(82, 290);
            this.txtbkPrice.Name = "txtbkPrice";
            this.txtbkPrice.Size = new System.Drawing.Size(163, 21);
            this.txtbkPrice.TabIndex = 1;
            // 
            // txtbkPages
            // 
            this.txtbkPages.Location = new System.Drawing.Point(82, 260);
            this.txtbkPages.Name = "txtbkPages";
            this.txtbkPages.Size = new System.Drawing.Size(163, 21);
            this.txtbkPages.TabIndex = 1;
            // 
            // txtbkISBN
            // 
            this.txtbkISBN.Location = new System.Drawing.Point(82, 170);
            this.txtbkISBN.Name = "txtbkISBN";
            this.txtbkISBN.Size = new System.Drawing.Size(163, 21);
            this.txtbkISBN.TabIndex = 1;
            // 
            // txtbkPress
            // 
            this.txtbkPress.Location = new System.Drawing.Point(82, 109);
            this.txtbkPress.Name = "txtbkPress";
            this.txtbkPress.Size = new System.Drawing.Size(163, 21);
            this.txtbkPress.TabIndex = 1;
            // 
            // txtbkAuthor
            // 
            this.txtbkAuthor.Location = new System.Drawing.Point(82, 79);
            this.txtbkAuthor.Name = "txtbkAuthor";
            this.txtbkAuthor.Size = new System.Drawing.Size(163, 21);
            this.txtbkAuthor.TabIndex = 1;
            // 
            // txtbkName
            // 
            this.txtbkName.Location = new System.Drawing.Point(82, 50);
            this.txtbkName.Name = "txtbkName";
            this.txtbkName.Size = new System.Drawing.Size(163, 21);
            this.txtbkName.TabIndex = 1;
            // 
            // txtbkCode
            // 
            this.txtbkCode.Location = new System.Drawing.Point(83, 22);
            this.txtbkCode.Name = "txtbkCode";
            this.txtbkCode.Size = new System.Drawing.Size(162, 21);
            this.txtbkCode.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "图书本数";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "入管日期";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "图书价格";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "图数页数";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "所属语种";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "分类名称";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "标准ISBN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "出版日期";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "出版社名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "图书作者";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "图书名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书编号";
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(518, 441);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBookAdd.TabIndex = 1;
            this.btnBookAdd.Text = "添加";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // btnBookCancel
            // 
            this.btnBookCancel.Location = new System.Drawing.Point(616, 441);
            this.btnBookCancel.Name = "btnBookCancel";
            this.btnBookCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBookCancel.TabIndex = 1;
            this.btnBookCancel.Text = "取消";
            this.btnBookCancel.UseVisualStyleBackColor = true;
            this.btnBookCancel.Click += new System.EventHandler(this.btnBookCancel_Click);
            // 
            // labAddInformation
            // 
            this.labAddInformation.AutoSize = true;
            this.labAddInformation.ForeColor = System.Drawing.Color.Red;
            this.labAddInformation.Location = new System.Drawing.Point(13, 448);
            this.labAddInformation.Name = "labAddInformation";
            this.labAddInformation.Size = new System.Drawing.Size(65, 12);
            this.labAddInformation.TabIndex = 2;
            this.labAddInformation.Text = "添加状态：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(267, 388);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 8;
            this.label15.Text = "图书起始序号";
            // 
            // txtbkID
            // 
            this.txtbkID.Location = new System.Drawing.Point(347, 384);
            this.txtbkID.Name = "txtbkID";
            this.txtbkID.Size = new System.Drawing.Size(152, 21);
            this.txtbkID.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 381);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 10;
            this.label16.Text = "图书状态";
            // 
            // cmbbkStatus
            // 
            this.cmbbkStatus.FormattingEnabled = true;
            this.cmbbkStatus.Items.AddRange(new object[] {
            "在馆",
            "借出",
            "遗失",
            "变卖",
            "销毁"});
            this.cmbbkStatus.Location = new System.Drawing.Point(83, 383);
            this.cmbbkStatus.Name = "cmbbkStatus";
            this.cmbbkStatus.Size = new System.Drawing.Size(162, 20);
            this.cmbbkStatus.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 441);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = " 退出";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 473);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labAddInformation);
            this.Controls.Add(this.btnBookCancel);
            this.Controls.Add(this.btnBookAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBook";
            this.Text = "新书入库";
            this.Load += new System.EventHandler(this.frmBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbkCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.Button btnBookCancel;
        private System.Windows.Forms.DateTimePicker dtpbkDateIn;
        private System.Windows.Forms.ComboBox cmbbkLanguage;
        private System.Windows.Forms.ComboBox cmbbkCatalog;
        private System.Windows.Forms.TextBox txtbkNum;
        private System.Windows.Forms.TextBox txtbkPrice;
        private System.Windows.Forms.TextBox txtbkPages;
        private System.Windows.Forms.TextBox txtbkISBN;
        private System.Windows.Forms.TextBox txtbkPress;
        private System.Windows.Forms.TextBox txtbkAuthor;
        private System.Windows.Forms.TextBox txtbkName;
        private System.Windows.Forms.TextBox txtbkCode;
        private System.Windows.Forms.PictureBox ptbkCover;
        private System.Windows.Forms.RichTextBox rtbbkBrief;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnUpLoadCover;
        private System.Windows.Forms.Label labAddInformation;
        private System.Windows.Forms.DateTimePicker dtpbkdatePress;
        private System.Windows.Forms.TextBox txtbkID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbbkStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnBack;
    }
}