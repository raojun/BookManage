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
    public partial class frmReaderType : Form
    {
        private DataTable dt = null;//存放查询结果，并给DataGridView drvReader提供数据
        private ReaderType readerType = new ReaderType();//存放读者信息，与读者信息控件组内的各控件进行数据交换，并与BLL、Model层进行数据交换
        private ReaderTypeAdmin readerTypeBLL = new ReaderTypeAdmin();

        public frmReaderType()
        {
            InitializeComponent();
            dt = readerTypeBLL.GetReaderType();
            ShowData();
        }

        private void ShowData()
        {
            dgvReaderType.DataSource = dt;
            foreach (DataColumn dc in dt.Columns)
            {
                dgvReaderType.Columns[dc.ColumnName].HeaderText = ReaderType.ColumnTitle(dc.ColumnName);
            }
        }
        //读者信息组内控件与实体类对象之间的数据互换
        private void SetReaderToText()
        {
            
            txtTypeName.Text = readerType.rdTypeName;
            txtCanLendQty.Text = Convert.ToString(readerType.CanLendQty);
            txtCanLendDay.Text = Convert.ToString(readerType.CanLendDay);
            txtCanContinueTimes.Text = Convert.ToString(readerType.CanContinueTimes);
            txtPunishRate.Text = Convert.ToString(readerType.PunishRate);
            txtDateValid.Text = Convert.ToString(readerType.DateValid);
        }

        private void SetTextToReader()
        {
            readerType.rdTypeName = txtTypeName.Text;
            readerType.CanLendQty = Convert.ToInt32(txtCanLendQty);
            readerType.CanLendDay = Convert.ToInt32(txtCanLendDay);
            readerType.CanContinueTimes = Convert.ToInt32(txtCanContinueTimes);
            readerType.PunishRate = Convert.ToInt32(txtPunishRate);
            readerType.DateValid = Convert.ToInt32(txtDateValid);
        }

        private void tsbFirstRecord_Click(object sender, EventArgs e)
        {

        }

        private void tsbNextRecord_Click(object sender, EventArgs e)
        {

        }

        private void tsbLastRecord_Click(object sender, EventArgs e)
        {

        }

        private void tsbFinalRecord_Click(object sender, EventArgs e)
        {

        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {

        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {

        }

        private void tsbDelate_Click(object sender, EventArgs e)
        {

        }

        private void tsbBack_Click(object sender, EventArgs e)
        {

        }

        private void dgvReaderType_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReaderType.CurrentCell == null)
                return;
            readerType= ReaderTypeAdmin.GetReaderType((int)dgvReaderType["rdType", dgvReaderType.CurrentCell.RowIndex].Value);
            SetReaderToText();
        }

        //-----------------------------------------------------------------------
    }
}
