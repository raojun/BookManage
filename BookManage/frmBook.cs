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
        private DataTable dt = null;//存放查询结果，并给DataGridView drvReader提供数据
        private Book book = new Book();
        private BookAdmin bookBLL = new BookAdmin();
        public frmBook()
        {
            InitializeComponent();
            
        }

        private void ShowData()
        {
            dgvBook.DataSource = dt;
            foreach (DataColumn dc in dt.Columns)
            {
                dgvBook.Columns[dc.ColumnName].HeaderText = Book.ColumnTitle(dc.ColumnName);
            }
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

        private void SetBookToText()
        {
            txtbkID.Text = Convert.ToString(book.bkID);
            txtbkCode.Text = book.bkCode;
            txtbkName.Text = book.bkName;
            txtbkAuthor.Text = book.bkAuthor;
            txtbkPress.Text=book.bkPress;;
            dtpbkdatePress.Text = Convert.ToString(book.bkdatePress);
            txtbkISBN.Text = book.bkISBN;
            cmbbkCatalog.Text=book.bkCatalog;
            cmbbkLanguage.Text = book.bkLanguage;
            txtbkPages.Text= Convert.ToString(book.bkPages);
            txtbkPrice.Text= Convert.ToString(book.bkPrice);
            dtpbkDateIn.Text = Convert.ToString(book.bkDateIn);
            txtbkNum.Text = Convert.ToString(book.bkNum);
            rtbbkBrief.Text =book.bkBrief ;
            if (book.bkCover == null)
            {
                ptbkCover.Image = null;
            }
            else
            {
                MemoryStream ms = new MemoryStream(book.bkCover);
                Image imgPhoto = Bitmap.FromStream(ms, true);
                ptbkCover.Image = imgPhoto;
            }
            cmbbkStatus.Text = book.bkStatus;
        }

        #endregion

        private void btnBookScan_Click(object sender, EventArgs e)
        {
            dt = bookBLL.GetBook();
            ShowData();
        }

        private void btnBookSelect_Click(object sender, EventArgs e)
        {
            int bkID,bkNum;
            string bkCode,bkName,bkAuthor,bkPress;

            if (textID.Text.Trim() == "")
            {
                bkID = 0;
            }
            else
            {
                int i = textID.Text.IndexOf("--");
                if (i > 0)
                {
                    bkID = Convert.ToInt32(textID.Text.Substring(0, i));
                }
                else
                {
                    bkID = Convert.ToInt32(textID.Text);
                }
            }
            bkCode = textCode.Text;
            bkName = Convert.ToString(textName.Text);
            bkAuthor = Convert.ToString(textAuthor.Text);
            bkPress = Convert.ToString(textPress.Text);
            bkNum = Convert.ToInt32(textID.Text);
            dt = bookBLL.GetBook(bkID, bkCode, bkName, bkAuthor, bkPress, bkNum);
            ShowData();
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            SetTextToBook();
            bookBLL.Insert(book);
            labAddInformation.Text = "添加状态：已添加！";
        }

        private void btnBookUpdate_Click(object sender, EventArgs e)
        {
            SetTextToBook();
            bookBLL.Update(book);
            labAddInformation.Text = "添加状态：已修改！";
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            SetTextToBook();
            bookBLL.Delete(book);
            labAddInformation.Text = "添加状态：已删除！";
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

        private void dgvBook_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBook.CurrentCell == null)
                return;
            book = BookAdmin.GetBook((int)dgvBook["bkID", dgvBook.CurrentCell.RowIndex].Value);
            SetBookToText();
        }
    }
}
