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
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnBookCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnUpLoadCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "图片文件（*.jpg;*bmp;*.png;*.gif）|*.jpg;*bmp;*.png;*.gif";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                Image imgPhoto = Image.FromFile(ofd1.FileName);
                pictureBox.Image = imgPhoto;
            }
        }
    }
}
