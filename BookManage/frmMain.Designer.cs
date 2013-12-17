namespace BookManage
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.办理借书证 = new System.Windows.Forms.ToolStripMenuItem();
            this.借书证信息变更 = new System.Windows.Forms.ToolStripMenuItem();
            this.借书证挂失与解除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销借书证ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者类型管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.续借ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.密码修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.授权管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.权限管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textrdID = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.textrdName = new System.Windows.Forms.TextBox();
            this.textrdPwd = new System.Windows.Forms.TextBox();
            this.textrdSex = new System.Windows.Forms.TextBox();
            this.textBorrowQty = new System.Windows.Forms.TextBox();
            this.textrdStatus = new System.Windows.Forms.TextBox();
            this.textAdminRole = new System.Windows.Forms.TextBox();
            this.textrdType = new System.Windows.Forms.TextBox();
            this.textrdDept = new System.Windows.Forms.TextBox();
            this.textrdPhone = new System.Windows.Forms.TextBox();
            this.textrdEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书管理ToolStripMenuItem,
            this.读者管理ToolStripMenuItem,
            this.借阅管理ToolStripMenuItem,
            this.用户管理ToolStripMenuItem,
            this.授权管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 图书管理ToolStripMenuItem
            // 
            this.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            this.图书管理ToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.图书管理ToolStripMenuItem.Text = " 图书管理";
            this.图书管理ToolStripMenuItem.Click += new System.EventHandler(this.图书管理ToolStripMenuItem_Click);
            // 
            // 读者管理ToolStripMenuItem
            // 
            this.读者管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.办理借书证,
            this.借书证信息变更,
            this.借书证挂失与解除ToolStripMenuItem,
            this.注销借书证ToolStripMenuItem,
            this.读者类型管理});
            this.读者管理ToolStripMenuItem.Name = "读者管理ToolStripMenuItem";
            this.读者管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.读者管理ToolStripMenuItem.Text = "读者管理";
            // 
            // 办理借书证
            // 
            this.办理借书证.Name = "办理借书证";
            this.办理借书证.Size = new System.Drawing.Size(172, 22);
            this.办理借书证.Text = "办理借书证";
            this.办理借书证.Click += new System.EventHandler(this.办理借书证_Click);
            // 
            // 借书证信息变更
            // 
            this.借书证信息变更.Name = "借书证信息变更";
            this.借书证信息变更.Size = new System.Drawing.Size(172, 22);
            this.借书证信息变更.Text = "借书证信息变更";
            this.借书证信息变更.Click += new System.EventHandler(this.借书证信息变更_Click);
            // 
            // 借书证挂失与解除ToolStripMenuItem
            // 
            this.借书证挂失与解除ToolStripMenuItem.Name = "借书证挂失与解除ToolStripMenuItem";
            this.借书证挂失与解除ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.借书证挂失与解除ToolStripMenuItem.Text = "借书证挂失与解除";
            this.借书证挂失与解除ToolStripMenuItem.Click += new System.EventHandler(this.借书证挂失与解除ToolStripMenuItem_Click);
            // 
            // 注销借书证ToolStripMenuItem
            // 
            this.注销借书证ToolStripMenuItem.Name = "注销借书证ToolStripMenuItem";
            this.注销借书证ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.注销借书证ToolStripMenuItem.Text = "注销借书证";
            this.注销借书证ToolStripMenuItem.Click += new System.EventHandler(this.注销借书证ToolStripMenuItem_Click);
            // 
            // 读者类型管理
            // 
            this.读者类型管理.Name = "读者类型管理";
            this.读者类型管理.Size = new System.Drawing.Size(172, 22);
            this.读者类型管理.Text = "读者类型管理";
            this.读者类型管理.Click += new System.EventHandler(this.读者类型管理_Click);
            // 
            // 借阅管理ToolStripMenuItem
            // 
            this.借阅管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.借书ToolStripMenuItem,
            this.续借ToolStripMenuItem,
            this.还书ToolStripMenuItem});
            this.借阅管理ToolStripMenuItem.Name = "借阅管理ToolStripMenuItem";
            this.借阅管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.借阅管理ToolStripMenuItem.Text = "借阅管理";
            // 
            // 借书ToolStripMenuItem
            // 
            this.借书ToolStripMenuItem.Name = "借书ToolStripMenuItem";
            this.借书ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.借书ToolStripMenuItem.Text = "借书";
            this.借书ToolStripMenuItem.Click += new System.EventHandler(this.借书ToolStripMenuItem_Click);
            // 
            // 续借ToolStripMenuItem
            // 
            this.续借ToolStripMenuItem.Name = "续借ToolStripMenuItem";
            this.续借ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.续借ToolStripMenuItem.Text = "续借";
            this.续借ToolStripMenuItem.Click += new System.EventHandler(this.续借ToolStripMenuItem_Click);
            // 
            // 还书ToolStripMenuItem
            // 
            this.还书ToolStripMenuItem.Name = "还书ToolStripMenuItem";
            this.还书ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.还书ToolStripMenuItem.Text = "还书";
            this.还书ToolStripMenuItem.Click += new System.EventHandler(this.还书ToolStripMenuItem_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.密码修改ToolStripMenuItem});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 密码修改ToolStripMenuItem
            // 
            this.密码修改ToolStripMenuItem.Name = "密码修改ToolStripMenuItem";
            this.密码修改ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.密码修改ToolStripMenuItem.Text = "密码修改";
            this.密码修改ToolStripMenuItem.Click += new System.EventHandler(this.密码修改ToolStripMenuItem_Click);
            // 
            // 授权管理ToolStripMenuItem
            // 
            this.授权管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.权限管理ToolStripMenuItem});
            this.授权管理ToolStripMenuItem.Name = "授权管理ToolStripMenuItem";
            this.授权管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.授权管理ToolStripMenuItem.Text = "授权管理";
            // 
            // 权限管理ToolStripMenuItem
            // 
            this.权限管理ToolStripMenuItem.Name = "权限管理ToolStripMenuItem";
            this.权限管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.权限管理ToolStripMenuItem.Text = "权限管理";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 346);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(542, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssUser
            // 
            this.tssUser.Name = "tssUser";
            this.tssUser.Size = new System.Drawing.Size(131, 17);
            this.tssUser.Text = "toolStripStatusLabel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "性    别";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(99, 54);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 117);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "借书证号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓    名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "密    码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "已 借 书";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "证件状态";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "读者角色";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "读者类别";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "单    位";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "电话号码";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "电子邮件";
            // 
            // textrdID
            // 
            this.textrdID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textrdID.Enabled = false;
            this.textrdID.Location = new System.Drawing.Point(126, 196);
            this.textrdID.Name = "textrdID";
            this.textrdID.ReadOnly = true;
            this.textrdID.Size = new System.Drawing.Size(100, 21);
            this.textrdID.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Location = new System.Drawing.Point(312, 301);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(158, 21);
            this.dtpDate.TabIndex = 5;
            // 
            // textrdName
            // 
            this.textrdName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textrdName.Enabled = false;
            this.textrdName.Location = new System.Drawing.Point(126, 230);
            this.textrdName.Name = "textrdName";
            this.textrdName.ReadOnly = true;
            this.textrdName.Size = new System.Drawing.Size(100, 21);
            this.textrdName.TabIndex = 4;
            // 
            // textrdPwd
            // 
            this.textrdPwd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textrdPwd.Enabled = false;
            this.textrdPwd.Location = new System.Drawing.Point(126, 264);
            this.textrdPwd.Name = "textrdPwd";
            this.textrdPwd.ReadOnly = true;
            this.textrdPwd.Size = new System.Drawing.Size(100, 21);
            this.textrdPwd.TabIndex = 4;
            // 
            // textrdSex
            // 
            this.textrdSex.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textrdSex.Enabled = false;
            this.textrdSex.Location = new System.Drawing.Point(126, 296);
            this.textrdSex.Name = "textrdSex";
            this.textrdSex.ReadOnly = true;
            this.textrdSex.Size = new System.Drawing.Size(100, 21);
            this.textrdSex.TabIndex = 4;
            // 
            // textBorrowQty
            // 
            this.textBorrowQty.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBorrowQty.Enabled = false;
            this.textBorrowQty.Location = new System.Drawing.Point(312, 51);
            this.textBorrowQty.Name = "textBorrowQty";
            this.textBorrowQty.ReadOnly = true;
            this.textBorrowQty.Size = new System.Drawing.Size(158, 21);
            this.textBorrowQty.TabIndex = 4;
            // 
            // textrdStatus
            // 
            this.textrdStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textrdStatus.Enabled = false;
            this.textrdStatus.Location = new System.Drawing.Point(312, 85);
            this.textrdStatus.Name = "textrdStatus";
            this.textrdStatus.ReadOnly = true;
            this.textrdStatus.Size = new System.Drawing.Size(158, 21);
            this.textrdStatus.TabIndex = 4;
            // 
            // textAdminRole
            // 
            this.textAdminRole.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textAdminRole.Enabled = false;
            this.textAdminRole.Location = new System.Drawing.Point(312, 119);
            this.textAdminRole.Name = "textAdminRole";
            this.textAdminRole.ReadOnly = true;
            this.textAdminRole.Size = new System.Drawing.Size(158, 21);
            this.textAdminRole.TabIndex = 4;
            // 
            // textrdType
            // 
            this.textrdType.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textrdType.Enabled = false;
            this.textrdType.Location = new System.Drawing.Point(312, 155);
            this.textrdType.Name = "textrdType";
            this.textrdType.ReadOnly = true;
            this.textrdType.Size = new System.Drawing.Size(158, 21);
            this.textrdType.TabIndex = 4;
            // 
            // textrdDept
            // 
            this.textrdDept.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textrdDept.Enabled = false;
            this.textrdDept.Location = new System.Drawing.Point(312, 191);
            this.textrdDept.Name = "textrdDept";
            this.textrdDept.ReadOnly = true;
            this.textrdDept.Size = new System.Drawing.Size(158, 21);
            this.textrdDept.TabIndex = 4;
            // 
            // textrdPhone
            // 
            this.textrdPhone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textrdPhone.Enabled = false;
            this.textrdPhone.Location = new System.Drawing.Point(312, 227);
            this.textrdPhone.Name = "textrdPhone";
            this.textrdPhone.ReadOnly = true;
            this.textrdPhone.Size = new System.Drawing.Size(158, 21);
            this.textrdPhone.TabIndex = 4;
            // 
            // textrdEmail
            // 
            this.textrdEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textrdEmail.Enabled = false;
            this.textrdEmail.Location = new System.Drawing.Point(312, 264);
            this.textrdEmail.Name = "textrdEmail";
            this.textrdEmail.ReadOnly = true;
            this.textrdEmail.Size = new System.Drawing.Size(158, 21);
            this.textrdEmail.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(253, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "办证日期";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 368);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.textrdEmail);
            this.Controls.Add(this.textrdType);
            this.Controls.Add(this.textrdPhone);
            this.Controls.Add(this.textrdSex);
            this.Controls.Add(this.textAdminRole);
            this.Controls.Add(this.textrdDept);
            this.Controls.Add(this.textrdPwd);
            this.Controls.Add(this.textrdStatus);
            this.Controls.Add(this.textBorrowQty);
            this.Controls.Add(this.textrdName);
            this.Controls.Add(this.textrdID);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem 读者管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 办理借书证;
        private System.Windows.Forms.ToolStripMenuItem 借书证信息变更;
        private System.Windows.Forms.ToolStripMenuItem 借书证挂失与解除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销借书证ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者类型管理;
        private System.Windows.Forms.ToolStripMenuItem 借阅管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 续借ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 密码修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tssUser;
        private System.Windows.Forms.ToolStripMenuItem 授权管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 权限管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书管理ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textrdID;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox textrdName;
        private System.Windows.Forms.TextBox textrdPwd;
        private System.Windows.Forms.TextBox textrdSex;
        private System.Windows.Forms.TextBox textBorrowQty;
        private System.Windows.Forms.TextBox textrdStatus;
        private System.Windows.Forms.TextBox textAdminRole;
        private System.Windows.Forms.TextBox textrdType;
        private System.Windows.Forms.TextBox textrdDept;
        private System.Windows.Forms.TextBox textrdPhone;
        private System.Windows.Forms.TextBox textrdEmail;
        private System.Windows.Forms.Label label13;
    }
}