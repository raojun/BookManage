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
            this.cmbTypeForQry = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmbDeptForQry = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.txtNameForQry = new System.Windows.Forms.ToolStripTextBox();
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
            this.dtpDateReg = new System.Windows.Forms.DateTimePicker();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdminRoles = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtBorrowQty = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
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
            this.picboxPhoto = new System.Windows.Forms.PictureBox();
            this.btnLoadPictureFile = new System.Windows.Forms.Button();
            this.btnCancelChange = new System.Windows.Forms.Button();
            this.btnUpdateReader = new System.Windows.Forms.Button();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cmbTypeForQry,
            this.toolStripLabel2,
            this.cmbDeptForQry,
            this.toolStripLabel3,
            this.txtNameForQry,
            this.btuQuery,
            this.toolStripLabel4,
            this.toolStripSeparator1,
            this.btuToExcel,
            this.toolStripLabel5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(952, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 30);
            this.toolStripLabel1.Text = "读者类别：";
            // 
            // cmbTypeForQry
            // 
            this.cmbTypeForQry.Name = "cmbTypeForQry";
            this.cmbTypeForQry.Size = new System.Drawing.Size(121, 33);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(44, 30);
            this.toolStripLabel2.Text = "单位：";
            // 
            // cmbDeptForQry
            // 
            this.cmbDeptForQry.Name = "cmbDeptForQry";
            this.cmbDeptForQry.Size = new System.Drawing.Size(121, 33);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(44, 30);
            this.toolStripLabel3.Text = "姓名：";
            // 
            // txtNameForQry
            // 
            this.txtNameForQry.Name = "txtNameForQry";
            this.txtNameForQry.Size = new System.Drawing.Size(100, 33);
            // 
            // btuQuery
            // 
            this.btuQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btuQuery.Image = global::BookManage.Properties.Resources.search;
            this.btuQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btuQuery.Name = "btuQuery";
            this.btuQuery.Size = new System.Drawing.Size(23, 30);
            this.btuQuery.Text = "toolStripButton1";
            this.btuQuery.Click += new System.EventHandler(this.btuQuery_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(32, 30);
            this.toolStripLabel4.Text = "查找";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // btuToExcel
            // 
            this.btuToExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btuToExcel.Image = global::BookManage.Properties.Resources.Excel;
            this.btuToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btuToExcel.Name = "btuToExcel";
            this.btuToExcel.Size = new System.Drawing.Size(23, 30);
            this.btuToExcel.Text = "toolStripButton1";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(37, 30);
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
            this.groupBox2.Controls.Add(this.dtpDateReg);
            this.groupBox2.Controls.Add(this.cmbDept);
            this.groupBox2.Controls.Add(this.cmbType);
            this.groupBox2.Controls.Add(this.cmbSex);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtAdminRoles);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Controls.Add(this.txtPwd);
            this.groupBox2.Controls.Add(this.txtBorrowQty);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
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
            // dtpDateReg
            // 
            this.dtpDateReg.Location = new System.Drawing.Point(76, 355);
            this.dtpDateReg.Name = "dtpDateReg";
            this.dtpDateReg.Size = new System.Drawing.Size(219, 23);
            this.dtpDateReg.TabIndex = 9;
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(76, 264);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(219, 22);
            this.cmbDept.TabIndex = 8;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(76, 232);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(219, 22);
            this.cmbType.TabIndex = 8;
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbSex.Location = new System.Drawing.Point(76, 112);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(100, 22);
            this.cmbSex.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(76, 326);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // txtAdminRoles
            // 
            this.txtAdminRoles.Location = new System.Drawing.Point(76, 201);
            this.txtAdminRoles.Name = "txtAdminRoles";
            this.txtAdminRoles.Size = new System.Drawing.Size(219, 23);
            this.txtAdminRoles.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(76, 294);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(219, 23);
            this.txtPhone.TabIndex = 7;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(76, 171);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 23);
            this.txtStatus.TabIndex = 7;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(76, 81);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(100, 23);
            this.txtPwd.TabIndex = 7;
            // 
            // txtBorrowQty
            // 
            this.txtBorrowQty.Location = new System.Drawing.Point(76, 140);
            this.txtBorrowQty.Name = "txtBorrowQty";
            this.txtBorrowQty.Size = new System.Drawing.Size(100, 23);
            this.txtBorrowQty.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(76, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(76, 24);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(17, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 6;
            this.label12.Text = "办证日期";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(17, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "电子邮件";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(17, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "电话号码";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(17, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "单    位";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(17, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "读者类别";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(17, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "读者角色";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(17, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "证件状态";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(17, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "已 借 书";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(17, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "性    别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "密    码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "姓    名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "借书证号";
            // 
            // picboxPhoto
            // 
            this.picboxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxPhoto.Location = new System.Drawing.Point(185, 22);
            this.picboxPhoto.Name = "picboxPhoto";
            this.picboxPhoto.Size = new System.Drawing.Size(110, 130);
            this.picboxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPhoto.TabIndex = 4;
            this.picboxPhoto.TabStop = false;
            // 
            // btnLoadPictureFile
            // 
            this.btnLoadPictureFile.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoadPictureFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoadPictureFile.Location = new System.Drawing.Point(187, 160);
            this.btnLoadPictureFile.Name = "btnLoadPictureFile";
            this.btnLoadPictureFile.Size = new System.Drawing.Size(106, 31);
            this.btnLoadPictureFile.TabIndex = 3;
            this.btnLoadPictureFile.Text = "打开图片文件";
            this.btnLoadPictureFile.UseVisualStyleBackColor = true;
            this.btnLoadPictureFile.Click += new System.EventHandler(this.btnLoadPictureFile_Click);
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
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmbTypeForQry;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmbDeptForQry;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdminRoles;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtBorrowQty;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.ToolStripTextBox txtNameForQry;
        private System.Windows.Forms.DateTimePicker dtpDateReg;


    }
}