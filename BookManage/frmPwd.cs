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
    public partial class frmPwd : Form
    {
        Reader reader=frmLogin.reader;
        private Reader readerPwd = new Reader();
        private ReaderAdmin readerBLL = new ReaderAdmin();

        public frmPwd()
        {
            InitializeComponent();
            if (reader.rdPhoto == null)
            {
                pictureBox.Image = null;
            }
            else
            {
                MemoryStream ms = new MemoryStream(reader.rdPhoto);
                Image imgPhoto = Bitmap.FromStream(ms, true);
                pictureBox.Image = imgPhoto;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtOldPwd.Text.Trim() == "")
            {
                MessageBox.Show("旧密码不能为空");
            }
            else
            {
                if (txtNewPwd.Text.Trim() == "")
                {
                    MessageBox.Show("请输入新密码！");
                }
                else
                {
                    if (txtNewPwd.Text.Trim() != txtConfirmPwd.Text.Trim())
                    {
                        MessageBox.Show("两次输入密码不一致，请重新输入！");
                    }
                    else
                    {
                        readerPwd.rdID = reader.rdID;
                        readerPwd.rdPwd = txtConfirmPwd.Text.Trim();
                        readerBLL.UpdatePwd(readerPwd);
                        MessageBox.Show("密码修改成功！");
                    }
                }
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Form form = new frmLogin();
            form.Show();
            this.Close();
        }
    }
}
