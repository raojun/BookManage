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
        public frmBorrow()
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
    }
}
