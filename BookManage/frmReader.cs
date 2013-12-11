using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using BookManage.Model;
using BookManage.BLL;

namespace BookManage
{
    internal enum opStatus//添加枚举类型，表示3种窗口操作状态
    {
        inSelect=0,//查询操作状态
        inNew=1,//办理新借书证状态
        inChange=2//变更借书证状态
    };
    public partial class frmReader : Form
    {
        private DataTable dt = null;//存放查询结果，并给DataGridView drvReader提供数据
        private Reader reader = new Reader();//存放读者信息，与读者信息控件组内的各控件进行数据交换，并与BLL、Model层进行数据交换
        private ReaderAdmin readerBLL = new ReaderAdmin();
        private opStatus ops;

        public frmReader()
        {
            InitializeComponent();
            dt = readerBLL.GetAllReaderType();
            foreach (DataRow dr in dt.Rows)
            {
                cmbTypeForQry.Items.Add(dr["rdType"].ToString()+"--"+dr["rdTypeName"].ToString());
                cmbType.Items.Add(dr["rdType"].ToString() + "--" + dr["rdTypeName"].ToString());
            }

            SetStatus(opStatus.inSelect);
            dt = readerBLL.GetReader(0, "", "");
            ShowData();
        }

        private void ShowData()
        {
            dgvReader.DataSource = dt;
            foreach (DataColumn dc in dt.Columns)
            {
                dgvReader.Columns[dc.ColumnName].HeaderText = Reader.ColumnTitle(dc.ColumnName);
            }
        }

        private void SetStatus(opStatus opst)
        {
            ops = opst;
            switch (ops)
            {
                case opStatus .inSelect:
                    toolStrip1.Enabled = true;//查询工具栏
                    groupBox1.Enabled = true;//查询结果
                    groupBox2.Enabled = false;//读者信息
                    break;
                case opStatus.inNew:
                    toolStrip1.Enabled = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    btnAddReader.Enabled = true;//确认办证
                    btnUpdateReader.Enabled = false;//确认变更
                    break;
                case opStatus.inChange:
                    toolStrip1.Enabled = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    btnAddReader.Enabled = false;
                    btnUpdateReader.Enabled = true;
                    break;
            }
        }

        //--------------------------------------------
        //读者信息组内控件与实体类对象之间的数据互换
        private void SetReaderToText()
        {
            txtID.Text = Convert.ToString(reader.rdID);
            txtName.Text = reader.rdName;
            txtPwd.Text = reader.rdPwd;
            cmbSex.Text = reader.rdSex;
            cmbType.Text = Convert.ToString(reader.rdType);
            cmbDept.Text = reader.rdDept;
            txtPhone.Text = reader.rdPhone;
            txtEmail.Text = reader.rdEmail;
            dtpDateReg.Value = reader.rdDateReg;
            if (reader.rdPhoto == null)
            {
                picboxPhoto.Image = null;
            }
            else
            {
                MemoryStream ms = new MemoryStream(reader.rdPhoto);
                Image imgPhoto = Bitmap.FromStream(ms, true);
                picboxPhoto.Image = imgPhoto;
            }
            txtStatus.Text = reader.rdStatus;
            txtBorrowQty.Text = Convert.ToString(reader.rdBorrowQty);
            txtAdminRoles.Text = Convert.ToString(reader.rdAdminRoles);
        }

        private void SetTextToReader()
        {
            reader.rdID = Convert.ToInt32(txtID.Text);
            reader.rdName = txtName.Text;
            reader.rdPwd = txtPwd.Text;
            reader.rdSex = cmbSex.Text;
            int i = cmbType.Text.IndexOf("--");
            if (i > 0)
            {
                reader.rdType = Convert.ToInt32(cmbType.Text.Substring(0, i));
            }
            else
            {
                reader.rdType = Convert.ToInt32(cmbType.Text);
            }
            reader.rdDept = cmbDept.Text;
            reader.rdPhone = txtPhone.Text;
            reader.rdEmail = txtEmail.Text;
            reader.rdDateReg = dtpDateReg.Value;
            if (picboxPhoto.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                picboxPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                reader.rdPhoto = ms.GetBuffer();
            }
            reader.rdStatus = txtStatus.Text;
            reader.rdBorrowQty = Convert.ToInt32(txtBorrowQty.Text);
            reader.rdAdminRoles = Convert.ToInt32(txtAdminRoles.Text);
        }

        //-----------------------------------------------------------------------

        private void btnNewDoc_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeDoc_Click(object sender, EventArgs e)
        {
            SetStatus(opStatus.inChange);
        }

        private void btnLossDoc_Click(object sender, EventArgs e)
        {

        }

        private void btnUnlossDoc_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelDoc_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateReader_Click(object sender, EventArgs e)
        {
            SetTextToReader();
            readerBLL.Update(reader);
        }

        private void btnCancelChange_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadPictureFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1=new OpenFileDialog();
            ofd1.Filter = "图片文件（*.jpg;*bmp;*.png;*.gif）|*.jpg;*bmp;*.png;*.gif";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                Image imgPhoto = Image.FromFile(ofd1.FileName);
                picboxPhoto.Image = imgPhoto;
            }
        }

        private void btuQuery_Click(object sender, EventArgs e)
        {
            int rdType;
            string rdDept, rdName;

            if (cmbTypeForQry.Text.Trim() == "")
            {
                rdType = 0;
            }
            else
            {
                int i = cmbTypeForQry.Text.IndexOf("--");
                if (i > 0)
                {
                    rdType = Convert.ToInt32(cmbTypeForQry.Text.Substring(0, i));
                }
                else
                {
                    rdType = Convert.ToInt32(cmbTypeForQry.Text);
                }
                rdDept = cmbDeptForQry.Text;
                rdName = txtNameForQry.Text;
                dt = readerBLL.GetReader(rdType, rdDept, rdName);
                ShowData();
            }
        }
    }
}
