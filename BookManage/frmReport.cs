using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookManage
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“BookLibraryDataSet.Reader”中。您可以根据需要移动或移除它。
            this.ReaderTableAdapter.Fill(this.BookLibraryDataSet.Reader);

            this.reportViewer1.RefreshReport();
        }
    }
}
