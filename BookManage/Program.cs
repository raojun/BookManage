using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookManage
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmReader());
            }
        }
    }
}
