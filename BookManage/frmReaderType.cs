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
        private opStatus ops;
        public frmReaderType()
        {
            InitializeComponent();
        }

        private void ShowData()
        {
            dgvReaderType.DataSource = dt;
            foreach (DataColumn dc in dt.Columns)
            {
                dgvReaderType.Columns[dc.ColumnName].HeaderText = ReaderType.ColumnTitle(dc.ColumnName);
            }
        }
    }
}
