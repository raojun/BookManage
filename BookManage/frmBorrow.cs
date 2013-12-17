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
        //private Borrow borrow = new Borrow();
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
            dt= borrowBLL.GetBorrow(rdID);
            ShowBorrowData();
        }

        //借书
        private void btnBorrowBook_Click(object sender, EventArgs e)
        {   
            Borrow borrow = new Borrow();
            DataRow dr=null;
            DataRow ds = null;
            borrow.rdID = Convert.ToInt32(txtrdID.Text);
            for(int i=0;i<dgvBook.SelectedRows.Count;i++)
            {
                dr = (dgvBook.SelectedRows[i].DataBoundItem as DataRowView).Row;
            }
            borrow.bkID = Convert.ToInt32(dr.ItemArray[0]);
            borrow.IdContinueTimes = 0;
            borrow.IdDateOut = DateTime.Now;
            borrow.IdDateRetPlan = DateTime.Now.AddDays(60);
            borrow.IdDateRetAct = DateTime.Now;
            borrow.IdOverDay = 0;
            borrow.IdOverMoney = 0;
            borrow.IdPunishMoney = 0;
            borrow.IsHasReturn = false;
            for (int j = 0; j < dgvReader.SelectedRows.Count; j++)
            {
                ds = (dgvReader.SelectedRows[j].DataBoundItem as DataRowView).Row;
            }
            borrow.OperatorLend = Convert.ToString(ds.ItemArray[1]);
            borrow.OperatorRet = Convert.ToString(ds.ItemArray[1]);
            borrowBLL.Insert(borrow);
            txtbkName.Text = Convert.ToString(borrow.rdID);
            borrowBLL.UpdateBook(borrow);
            MessageBox.Show("借书成功！！！");
        }

        //续借
        private void btnConBorrow_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            ReaderType readerType=new ReaderType();
            DataRow dr = null;
            for (int i = 0; i < dgvBorrow.SelectedRows.Count; i++)// 指定行操作
            {
                dr = (dgvBorrow.SelectedRows[i].DataBoundItem as DataRowView).Row;
            }
            //根据续借次数判断是否可续借
            if (Convert.ToInt32(dr.ItemArray[3]) > readerType.CanContinueTimes)
            {
                MessageBox.Show("对不起，您的续借次数已超出最大可续借次数！");
            }
            else
            {
                borrow.bkID = Convert.ToInt32(dr.ItemArray[0]);
                borrow.IdContinueTimes = Convert.ToInt32(dr.ItemArray[3]);
                borrow.IdDateOut = DateTime.Now;
                borrowBLL.UpdateContinue(borrow);
                MessageBox.Show("续借成功！");
            }
        }

        //还书
        private void btnRetBook_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            DataRow dr = null;
            for (int i = 0; i < dgvBorrow.SelectedRows.Count; i++)// 指定行操作
            {
                dr = (dgvBorrow.SelectedRows[i].DataBoundItem as DataRowView).Row;
            }
            borrow.bkID = Convert.ToInt32(dr.ItemArray[0]);
            borrow.IdDateRetAct = DateTime.Now;
            borrowBLL.UpdateBack(borrow);
            borrowBLL.UpdateBk(borrow);
            MessageBox.Show("还书成功！");
        }

        private void dgvReader_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        //指定行操作
        private void dgvBook_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvBook.CurrentCell == null)
            //    return;
            //borrow = BorrowAdmin.GetBookInformation((int)dgvBook["bkID", dgvBook.CurrentCell.RowIndex].Value);
        }

        private void dgvBorrow_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
