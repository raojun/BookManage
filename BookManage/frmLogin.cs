using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookManage.BLL;
using BookManage.Model;

namespace BookManage
{
    public partial class frmLogin : Form
    {
        private int loginTimes = 0;//登录次数
        private ReaderAdmin readerBLL = new ReaderAdmin();
        public static Reader reader = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginTimes++;
            int rdID;
            rdID = Convert.ToInt32(txtUserID.Text.Trim());
           reader = ReaderAdmin.GetReader(rdID);

            if (reader == null)
            {
                txtUserID.Focus();
                lblReaderInfo.Text = "登录信息：查无此人..{" + loginTimes.ToString() + "}";
            }
            else
            {
                if (reader.rdPwd == txtUserPwd.Text)
                {
                    this.DialogResult = DialogResult.OK;//登录成功
                }
                else
                {
                    txtUserPwd.Text = "";
                    txtUserPwd.Focus();
                    lblReaderInfo.Text = "登录信息：..密码错误！{" + loginTimes.ToString() + "}";
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
