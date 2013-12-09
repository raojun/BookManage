using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookManage.Model;

namespace BookManage
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 根据用户权限，在frmMain类中初始化菜单。添加InitMenu()方法
        /// </summary>
        public void InitMenu()
        {
            Reader reader = frmLogin.reader;//获取登录用户的读者信息

            //图书管理ToolStripMenuItem.Visible = true;//是否可见
            //图书管理ToolStripMenuItem.Avaiable =false;//是否活动
            //图书管理ToolStripMenuItem.Enabled=reader.
        }
    }
}
