using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookManage.Model;
using BookManage.BLL;

namespace BookManage
{
    public partial class frmBook : Form
    {
        private Book book = new Book();
        private BookAdmin bookBLL = new BookAdmin();
        public frmBook()
        {
            InitializeComponent();
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            bookBLL.Insert(book);
            labAddInformation.Text = "添加状态：添加成功！";
        }

        private void btnBookCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnUpLoadCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "图片文件（*.jpg;*bmp;*.png;*.gif）|*.jpg;*bmp;*.png;*.gif";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                Image imgPhoto = Image.FromFile(ofd1.FileName);
                pictureBox.Image = imgPhoto;
            }
        }

        private void frmBook_Load(object sender, EventArgs e)
        {

        }
    }
}
