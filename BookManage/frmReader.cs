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
    internal enum opStatus//添加枚举类型，表示3种窗口操作状态
    {
        inSelect=0,//查询操作状态
        inNew=1,//办理新借书证状态
        inChange=2//变更借书证状态
    };
    public partial class frmReader : Form
    {
        private DataTable dt = null;//存放查询结果，并给DataGridView drvReader提供数据
        private Reader reader = new Reader();//存放读者信息，与读者信息控件组内的各控件进行数据交换，并与BLL、Model层进行数据交换
        private ReaderAdmin readerBLL = new ReaderAdmin();
        private opStatus ops;

        public frmReader()
        {
            InitializeComponent();
            dt = readerBLL.GetAllReaderType();
            foreach (DataRow dr in dt.Rows)
            {
                cmbTypeForQry.Items.Add(dr["rdType"].ToString()+"--"+dr["rdTypeName"].ToString());
                cmbType.Items.Add(dr["rdType"].ToString() + "--" + dr["rdTypeName"].ToString());
            }

            SetStatus(opStatus.inSelect);
            
        }

        private void SetStatus(opStatus opst)
        {
            ops = opst;
            switch (ops)
            {
                case opStatus .inSelect:
                    toolStrip1.Enabled = true;//查询工具栏
                    groupBox1.Enabled = true;//查询结果
                    groupBox2.Enabled = false;//读者信息
                    break;
                case opStatus.inNew:
                    toolStrip1.Enabled = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    btnAddReader.Enabled = true;//确认办证
                    btnUpdateReader.Enabled = false;//确认变更
                    break;
                case opStatus.inChange:
                    toolStrip1.Enabled = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    btnAddReader.Enabled = false;
                    btnUpdateReader.Enabled = true;
                    break;
            }
        }

        private void btnNewDoc_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeDoc_Click(object sender, EventArgs e)
        {

        }

        private void btnLossDoc_Click(object sender, EventArgs e)
        {

        }

        private void btnUnlossDoc_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelDoc_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateReader_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelChange_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadPictureFile_Click(object sender, EventArgs e)
        {

        }
    }
}
