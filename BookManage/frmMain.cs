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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            InitMenu();
        }

        /// <summary>
        /// 根据用户权限，在frmMain类中初始化菜单。添加InitMenu()方法
        /// </summary>
        public void InitMenu()
        {
            Reader reader = frmLogin.reader;//获取登录用户的读者信息

            //图书管理ToolStripMenuItem.Visible = true;//是否可见
            //图书管理ToolStripMenuItem.Avaiable =false;//是否活动

            #region 分配权限
            图书管理ToolStripMenuItem.Enabled = (reader.IsBookAdmin()&&reader.IsLoginAdmin());//是否能用
            读者管理ToolStripMenuItem.Enabled = ((reader.IsReaderAdmin() | reader.IsSystemAdmin())&&reader.IsLoginAdmin());
            借阅管理ToolStripMenuItem.Enabled = (reader.IsBorrowAdmin()&&reader.IsLoginAdmin());
            用户管理ToolStripMenuItem.Enabled = (reader.IsLoginAdmin());
            //授权管理ToolStripMenuItem.Enabled = (reader.IsLoginAdmin());
            授权管理ToolStripMenuItem.Enabled = (reader.IsSystemAdmin() && reader.IsLoginAdmin());
            #endregion

            tssUser.Text = "登录用户：" + reader.rdName + "|" + reader.rdDept;

            #region 获取读者信息
            textrdID.Text = Convert.ToString(reader.rdID);
            textrdName.Text = reader.rdName;
            textrdPwd.Text = reader.rdPwd;
            textrdSex.Text = reader.rdSex;
            textBorrowQty.Text = Convert.ToString(reader.rdBorrowQty);
            textrdStatus.Text = reader.rdStatus;
            textAdminRole.Text = Convert.ToString(reader.rdAdminRoles);
            textrdType.Text = Convert.ToString(reader.rdType);
            textrdDept.Text = reader.rdDept;
            textrdPhone.Text = reader.rdPhone;
            textrdEmail.Text = reader.rdEmail;
            dtpDate.Text = Convert.ToString(reader.rdDateReg);
            if (reader.rdPhoto == null)
            {
                pictureBox.Image = null;
            }
            else
            {
                MemoryStream ms = new MemoryStream(reader.rdPhoto);
                Image imgPhoto = Bitmap.FromStream(ms, true);
                pictureBox.Image = imgPhoto;
            }
            #endregion
        }

        private void 读者类型管理_Click(object sender, EventArgs e)
        {
            Form form = new frmReaderType();
            form.Show();
            this.Hide();
        }

        private void 办理借书证_Click(object sender, EventArgs e)
        {
            Form form = new frmReader();
            form.Show();
            this.Hide();
        }

        private void 借书证信息变更_Click(object sender, EventArgs e)
        {
            Form form = new frmReader();
            form.Show();
            this.Hide();
        }

        private void 新书入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmBook();
            form.Show();
            this.Hide();
        }

        private void 借书证挂失与解除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmReader();
            form.Show();
            this.Hide();
        }

        private void 注销借书证ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmReader();
            form.Show();
            this.Hide();
        }

        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmBook();
            form.Show();
            this.Hide();
        }

        private void 借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmBorrow();
            form.Show();
            this.Hide();
        }

        private void 续借ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmBorrow();
            form.Show();
            this.Hide();
        }

        private void 还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmBorrow();
            form.Show();
            this.Hide();
        }

        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmPwd();
            form.Show();
            this.Hide();
        }
    }
}
