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
    public partial class frmBook : Form
    {
        private Book book = new Book();
        private BookAdmin bookBLL = new BookAdmin();
        public frmBook()
        {
            InitializeComponent();
        }

        #region 类型转换
        private void SetTextToBook()
        {
            book.bkID = Convert.ToInt32(txtbkID.Text);
            book.bkCode = txtbkCode.Text;
            book.bkName = txtbkName.Text;
            book.bkAuthor = txtbkAuthor.Text;
            book.bkPress = txtbkPress.Text;
            book.bkdatePress = Convert.ToDateTime(dtpbkdatePress.Text);
            book.bkISBN = txtbkISBN.Text;
            book.bkCatalog = cmbbkCatalog.Text;
            book.bkLanguage = cmbbkLanguage.Text;
            book.bkPages = Convert.ToInt32(txtbkPages.Text);
            book.bkPrice = Convert.ToSingle(txtbkPrice.Text);
            book.bkDateIn = Convert.ToDateTime(dtpbkDateIn.Text);
            book.bkNum = Convert.ToInt32(txtbkNum.Text);
            book.bkBrief = rtbbkBrief.Text;
            if (ptbkCover.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                ptbkCover.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                book.bkCover = ms.GetBuffer();
            }
            book.bkStatus = cmbbkStatus.Text;
        }

        #endregion

        private void btnBookScan_Click(object sender, EventArgs e)
        {

        }

        private void btnBookSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            SetTextToBook();
            bookBLL.Insert(book);
            labAddInformation.Text = "添加状态：添加成功！";
        }

        private void btnBookUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnOutExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form form = new frmMain();
            form.Show();
            this.Hide();
        }

        private void btnBookCancel_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in groupBox2.Controls)//清除所有textbox的内容
            {
                if (ctrl is TextBox)
                    ctrl.Text = " ";
            }
            //清楚combobox的内容
            cmbbkCatalog.Text = "";
            cmbbkLanguage.Text = "";
            cmbbkStatus.Text = "";
            rtbbkBrief.Text = "";
        }

        private void btnUpLoadCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "图片文件（*.jpg;*bmp;*.png;*.gif）|*.jpg;*bmp;*.png;*.gif";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                Image imgPhoto = Image.FromFile(ofd1.FileName);
                ptbkCover.Image = imgPhoto;
            }
        }

    }
}
