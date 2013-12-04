using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookManage.BLL;
using BookManage.Model;

namespace BookManage
{
    public partial class frmLogin : Form
    {
        private int loginTimes = 0;//登录次数
        private ReaderAdmin readerBLL = new ReaderAdmin();
        public static Reader reader = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
