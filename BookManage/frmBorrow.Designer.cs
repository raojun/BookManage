namespace BookManage
{
    partial class frmBorrow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtrdID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrdName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCanLendQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtrdDept = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCanLendDay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtrdType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtrdBorrowQty = new System.Windows.Forms.TextBox();
            this.txtbkID = new System.Windows.Forms.TextBox();
            this.btnSelectID = new System.Windows.Forms.Button();
            this.txtbkName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSelectName = new System.Windows.Forms.Button();
            this.btnConBorrow = new System.Windows.Forms.Button();
            this.btnRetBook = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRetBook);
            this.groupBox1.Controls.Add(this.btnConBorrow);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtrdBorrowQty);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtrdType);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCanLendDay);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtrdDept);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCanLendQty);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtrdName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtrdID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "读者信息";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtrdID
            // 
            this.txtrdID.Location = new System.Drawing.Point(75, 33);
            this.txtrdID.Name = "txtrdID";
            this.txtrdID.Size = new System.Drawing.Size(100, 21);
            this.txtrdID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "读者编号";
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Location = new System.Drawing.Point(13, 120);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.RowTemplate.Height = 23;
            this.dgvBorrow.Size = new System.Drawing.Size(872, 134);
            this.dgvBorrow.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBorrowBook);
            this.groupBox2.Controls.Add(this.btnSelectName);
            this.groupBox2.Controls.Add(this.btnSelectID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtbkName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtbkID);
            this.groupBox2.Location = new System.Drawing.Point(13, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 46);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图书信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "图书序号";
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(13, 319);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowTemplate.Height = 23;
            this.dgvBook.Size = new System.Drawing.Size(872, 134);
            this.dgvBook.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "已借图书";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "读者姓名";
            // 
            // txtrdName
            // 
            this.txtrdName.Location = new System.Drawing.Point(292, 18);
            this.txtrdName.Name = "txtrdName";
            this.txtrdName.Size = new System.Drawing.Size(100, 21);
            this.txtrdName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "可借书数量";
            // 
            // txtCanLendQty
            // 
            this.txtCanLendQty.Location = new System.Drawing.Point(292, 48);
            this.txtCanLendQty.Name = "txtCanLendQty";
            this.txtCanLendQty.Size = new System.Drawing.Size(100, 21);
            this.txtCanLendQty.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "读者单位";
            // 
            // txtrdDept
            // 
            this.txtrdDept.Location = new System.Drawing.Point(501, 18);
            this.txtrdDept.Name = "txtrdDept";
            this.txtrdDept.Size = new System.Drawing.Size(100, 21);
            this.txtrdDept.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "读者可借书天数";
            // 
            // txtCanLendDay
            // 
            this.txtCanLendDay.Location = new System.Drawing.Point(501, 49);
            this.txtCanLendDay.Name = "txtCanLendDay";
            this.txtCanLendDay.Size = new System.Drawing.Size(100, 21);
            this.txtCanLendDay.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(616, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "读者类型";
            // 
            // txtrdType
            // 
            this.txtrdType.Location = new System.Drawing.Point(672, 17);
            this.txtrdType.Name = "txtrdType";
            this.txtrdType.Size = new System.Drawing.Size(100, 21);
            this.txtrdType.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(616, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "已借书量";
            // 
            // txtrdBorrowQty
            // 
            this.txtrdBorrowQty.Location = new System.Drawing.Point(672, 48);
            this.txtrdBorrowQty.Name = "txtrdBorrowQty";
            this.txtrdBorrowQty.Size = new System.Drawing.Size(100, 21);
            this.txtrdBorrowQty.TabIndex = 1;
            // 
            // txtbkID
            // 
            this.txtbkID.Location = new System.Drawing.Point(77, 18);
            this.txtbkID.Name = "txtbkID";
            this.txtbkID.Size = new System.Drawing.Size(100, 21);
            this.txtbkID.TabIndex = 1;
            // 
            // btnSelectID
            // 
            this.btnSelectID.Location = new System.Drawing.Point(175, 17);
            this.btnSelectID.Name = "btnSelectID";
            this.btnSelectID.Size = new System.Drawing.Size(26, 23);
            this.btnSelectID.TabIndex = 2;
            this.btnSelectID.UseVisualStyleBackColor = true;
            this.btnSelectID.Click += new System.EventHandler(this.btnSelectID_Click);
            // 
            // txtbkName
            // 
            this.txtbkName.Location = new System.Drawing.Point(279, 19);
            this.txtbkName.Name = "txtbkName";
            this.txtbkName.Size = new System.Drawing.Size(100, 21);
            this.txtbkName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "图书名称";
            // 
            // btnSelectName
            // 
            this.btnSelectName.Location = new System.Drawing.Point(377, 18);
            this.btnSelectName.Name = "btnSelectName";
            this.btnSelectName.Size = new System.Drawing.Size(26, 23);
            this.btnSelectName.TabIndex = 2;
            this.btnSelectName.UseVisualStyleBackColor = true;
            this.btnSelectName.Click += new System.EventHandler(this.btnSelectName_Click);
            // 
            // btnConBorrow
            // 
            this.btnConBorrow.Location = new System.Drawing.Point(791, 16);
            this.btnConBorrow.Name = "btnConBorrow";
            this.btnConBorrow.Size = new System.Drawing.Size(75, 23);
            this.btnConBorrow.TabIndex = 3;
            this.btnConBorrow.Text = "续借";
            this.btnConBorrow.UseVisualStyleBackColor = true;
            // 
            // btnRetBook
            // 
            this.btnRetBook.Location = new System.Drawing.Point(791, 46);
            this.btnRetBook.Name = "btnRetBook";
            this.btnRetBook.Size = new System.Drawing.Size(75, 23);
            this.btnRetBook.TabIndex = 3;
            this.btnRetBook.Text = "还书";
            this.btnRetBook.UseVisualStyleBackColor = true;
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Location = new System.Drawing.Point(791, 15);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(75, 23);
            this.btnBorrowBook.TabIndex = 3;
            this.btnBorrowBook.Text = "借书";
            this.btnBorrowBook.UseVisualStyleBackColor = true;
            // 
            // frmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvBorrow);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBorrow";
            this.Text = "frmBorrow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrdID;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtrdBorrowQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtrdType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCanLendDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtrdDept;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCanLendQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtrdName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRetBook;
        private System.Windows.Forms.Button btnConBorrow;
        private System.Windows.Forms.Button btnSelectName;
        private System.Windows.Forms.Button btnSelectID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbkName;
        private System.Windows.Forms.TextBox txtbkID;
        private System.Windows.Forms.Button btnBorrowBook;
    }
}