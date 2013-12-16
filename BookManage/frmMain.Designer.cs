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
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(497, 25);
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
            // 
            // 还书ToolStripMenuItem
            // 
            this.还书ToolStripMenuItem.Name = "还书ToolStripMenuItem";
            this.还书ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.还书ToolStripMenuItem.Text = "还书";
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 262);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(497, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssUser
            // 
            this.tssUser.Name = "tssUser";
            this.tssUser.Size = new System.Drawing.Size(131, 17);
            this.tssUser.Text = "toolStripStatusLabel1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 284);
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
    }
}