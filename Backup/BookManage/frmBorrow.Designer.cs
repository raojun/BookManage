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
            this.label4 = new System.Windows.Forms.Label();
            this.dgvReader = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRetBook = new System.Windows.Forms.Button();
            this.btnConBorrow = new System.Windows.Forms.Button();
            this.btnSelectbkID = new System.Windows.Forms.Button();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.txtrdID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnSelectName = new System.Windows.Forms.Button();
            this.btnSelectID = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbkName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbkID = new System.Windows.Forms.TextBox();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgvReader);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnRetBook);
            this.groupBox1.Controls.Add(this.btnConBorrow);
            this.groupBox1.Controls.Add(this.btnSelectbkID);
            this.groupBox1.Controls.Add(this.dgvBorrow);
            this.groupBox1.Controls.Add(this.txtrdID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "读者信息";
            // 
            // dgvReader
            // 
            this.dgvReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReader.Location = new System.Drawing.Point(14, 84);
            this.dgvReader.Name = "dgvReader";
            this.dgvReader.RowTemplate.Height = 23;
            this.dgvReader.Size = new System.Drawing.Size(845, 79);
            this.dgvReader.TabIndex = 5;
            this.dgvReader.SelectionChanged += new System.EventHandler(this.dgvReader_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "已借图书";
            // 
            // btnRetBook
            // 
            this.btnRetBook.Location = new System.Drawing.Point(791, 46);
            this.btnRetBook.Name = "btnRetBook";
            this.btnRetBook.Size = new System.Drawing.Size(75, 23);
            this.btnRetBook.TabIndex = 3;
            this.btnRetBook.Text = "还书";
            this.btnRetBook.UseVisualStyleBackColor = true;
            this.btnRetBook.Click += new System.EventHandler(this.btnRetBook_Click);
            // 
            // btnConBorrow
            // 
            this.btnConBorrow.Location = new System.Drawing.Point(791, 16);
            this.btnConBorrow.Name = "btnConBorrow";
            this.btnConBorrow.Size = new System.Drawing.Size(75, 23);
            this.btnConBorrow.TabIndex = 3;
            this.btnConBorrow.Text = "续借";
            this.btnConBorrow.UseVisualStyleBackColor = true;
            this.btnConBorrow.Click += new System.EventHandler(this.btnConBorrow_Click);
            // 
            // btnSelectbkID
            // 
            this.btnSelectbkID.Location = new System.Drawing.Point(175, 19);
            this.btnSelectbkID.Name = "btnSelectbkID";
            this.btnSelectbkID.Size = new System.Drawing.Size(26, 23);
            this.btnSelectbkID.TabIndex = 2;
            this.btnSelectbkID.UseVisualStyleBackColor = true;
            this.btnSelectbkID.Click += new System.EventHandler(this.btnSelectbkID_Click);
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Location = new System.Drawing.Point(14, 197);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.RowTemplate.Height = 23;
            this.dgvBorrow.Size = new System.Drawing.Size(845, 108);
            this.dgvBorrow.TabIndex = 1;
            // 
            // txtrdID
            // 
            this.txtrdID.Location = new System.Drawing.Point(77, 20);
            this.txtrdID.Name = "txtrdID";
            this.txtrdID.Size = new System.Drawing.Size(100, 21);
            this.txtrdID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "读者编号";
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
            this.groupBox2.Location = new System.Drawing.Point(13, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 46);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图书信息";
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Location = new System.Drawing.Point(791, 15);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(75, 23);
            this.btnBorrowBook.TabIndex = 3;
            this.btnBorrowBook.Text = "借书";
            this.btnBorrowBook.UseVisualStyleBackColor = true;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // btnSelectName
            // 
            this.btnSelectName.Location = new System.Drawing.Point(377, 12);
            this.btnSelectName.Name = "btnSelectName";
            this.btnSelectName.Size = new System.Drawing.Size(26, 23);
            this.btnSelectName.TabIndex = 2;
            this.btnSelectName.UseVisualStyleBackColor = true;
            this.btnSelectName.Click += new System.EventHandler(this.btnSelectName_Click);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "图书名称";
            // 
            // txtbkName
            // 
            this.txtbkName.Location = new System.Drawing.Point(283, 13);
            this.txtbkName.Name = "txtbkName";
            this.txtbkName.Size = new System.Drawing.Size(100, 21);
            this.txtbkName.TabIndex = 1;
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
            // txtbkID
            // 
            this.txtbkID.Location = new System.Drawing.Point(77, 18);
            this.txtbkID.Name = "txtbkID";
            this.txtbkID.Size = new System.Drawing.Size(100, 21);
            this.txtbkID.TabIndex = 1;
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(13, 392);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowTemplate.Height = 23;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(872, 134);
            this.dgvBook.TabIndex = 3;
            this.dgvBook.SelectionChanged += new System.EventHandler(this.dgvBook_SelectionChanged);
            // 
            // frmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 538);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBorrow";
            this.Text = "frmBorrow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnSelectbkID;
        private System.Windows.Forms.Button btnRetBook;
        private System.Windows.Forms.Button btnConBorrow;
        private System.Windows.Forms.Button btnSelectName;
        private System.Windows.Forms.Button btnSelectID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbkName;
        private System.Windows.Forms.TextBox txtbkID;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvReader;
    }
}