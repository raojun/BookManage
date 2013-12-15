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
    public partial class frmBorrow : Form
    {
        private DataTable dt = null;//存放查询结果，并给DataGridView drvReader提供数据
        private BorrowAdmin borrowBLL = new BorrowAdmin();
        private Borrow borrow = new Borrow();
        public frmBorrow()
        {
            InitializeComponent();
        }

        //显示dgvBook数据
        private void ShowData()
        {
            dgvBook.DataSource = dt;
            foreach (DataColumn dc in dt.Columns)
            {
                dgvBook.Columns[dc.ColumnName].HeaderText = Book.ColumnTitle(dc.ColumnName);
            }
        }

        //显示dgvReader数据
        private void ShowReaderData()
        {
            dgvReader.DataSource = dt;
            foreach (DataColumn dc in dt.Columns)
            {
                dgvReader.Columns[dc.ColumnName].HeaderText = Reader.ColumnTitle(dc.ColumnName);
            }
        }

        //显示dgvBorrow数据
        private void ShowBorrowData()
        {
            dgvBorrow.DataSource = dt;
            foreach (DataColumn dc in dt.Columns)
            {
                dgvBorrow.Columns[dc.ColumnName].HeaderText =Borrow.ColumnTitle(dc.ColumnName);
            }
        }

        /// <summary>
        /// 按图书序号查找
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectID_Click(object sender, EventArgs e)
        {
            int bkID;
            if (txtbkID.Text.Trim() == "")
            {
                bkID = 0;
            }
            else
            {
                int i = txtbkID.Text.IndexOf("--");
                if (i > 0)
                {
                    bkID = Convert.ToInt32(txtbkID.Text.Substring(0, i));
                }
                else
                {
                    bkID = Convert.ToInt32(txtbkID.Text);
                }
            }
            dt = borrowBLL.GetBookID(bkID);
            ShowData();
        }

        /// <summary>
        /// 按书名查找
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectName_Click(object sender, EventArgs e)
        {
            string bkName;
            if (txtbkName.Text.Trim() == "")
            {
                bkName = null;
            }
            else
            {
                bkName = txtbkName.Text;
            }
            dt = borrowBLL.GetBookName(bkName);
            ShowData();
        }

        private void dgvBook_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBook.CurrentCell == null)
                return;
           borrow = BorrowAdmin.GetBook((int)dgvBook["bkID", dgvBook.CurrentCell.RowIndex].Value);
        }

        //借书
        private void btnBorrowBook_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 根据借书证号查询读者信息和所借书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectbkID_Click(object sender, EventArgs e)
        {
            int rdID;
            if (txtrdID.Text.Trim() == "")
            {
                rdID = 0;
            }
            else
            {
                int i = txtrdID.Text.IndexOf("--");
                if (i > 0)
                {
                    rdID = Convert.ToInt32(txtrdID.Text.Substring(0, i));
                }
                else
                {
                    rdID = Convert.ToInt32(txtrdID.Text);
                }
            }
            dt = borrowBLL.GetReader(rdID);
            ShowReaderData();
            dt = borrowBLL.GetBorrowBook(rdID);
            ShowBorrowData();
        }

        //还书
        private void btnRetBook_Click(object sender, EventArgs e)
        {

        }

        //续借
        private void btnConBorrow_Click(object sender, EventArgs e)
        {

        }
    }
}
