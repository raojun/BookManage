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
        private ReaderType readertype = new ReaderType();//存放读者信息，与读者信息控件组内的各控件进行数据交换，并与BLL、Model层进行数据交换
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
        private void SetReaderTypeToText()
        {
            txtrdType.Text = Convert.ToString(readertype.rdType);
            txtTypeName.Text = readertype.rdTypeName;
            txtCanLendQty.Text = Convert.ToString(readertype.CanLendQty);
            txtCanLendDay.Text = Convert.ToString(readertype.CanLendDay);
            txtCanContinueTimes.Text = Convert.ToString(readertype.CanContinueTimes);
            txtPunishRate.Text = Convert.ToString(readertype.PunishRate);
            txtDateValid.Text = Convert.ToString(readertype.DateValid);
        }

        private void SetTextToReaderType()
        {
            readertype.rdType = Convert.ToInt32(txtrdType.Text);
            readertype.rdTypeName = txtTypeName.Text;
            readertype.CanLendQty = Convert.ToInt32(txtCanLendQty.Text);
            readertype.CanLendDay = Convert.ToInt32(txtCanLendDay.Text);
            readertype.CanContinueTimes = Convert.ToInt32(txtCanContinueTimes.Text);
            readertype.PunishRate = Convert.ToSingle(txtPunishRate.Text);
            readertype.DateValid = Convert.ToInt32(txtDateValid.Text);
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
            SetTextToReaderType();
            readerTypeBLL.Insert(readertype);
            labImformation.Text=("状态：添加成功！");
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            SetTextToReaderType();
            readerTypeBLL.Update(readertype);
            labImformation.Text = ("状态：修改成功！");
        }

        private void tsbDelate_Click(object sender, EventArgs e)
        {
            SetTextToReaderType();
            readerTypeBLL.Delete(readertype);
            labImformation.Text = ("状态：已删除！");
        }

        private void tsbBack_Click(object sender, EventArgs e)
        {
            Form form = new frmMain();
            form.Show();
            this.Hide();
        }

        private void dgvReaderType_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReaderType.CurrentCell == null)
                return;
            readertype= ReaderTypeAdmin.GetReaderType(Convert.ToString( dgvReaderType["rdType", dgvReaderType.CurrentCell.RowIndex].Value));
            SetReaderTypeToText();
        }

        //-----------------------------------------------------------------------
    }
}
