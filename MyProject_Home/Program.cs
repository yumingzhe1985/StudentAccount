using MyProject_Home.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject_Home
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
            Form frm = new frmLogin();
            if (ConfigHelper.Get("IsNotHaveUNPW") == "0")
            {
                frm = new frmMain();
            }
            Application.Run(frm);
        }
    }
}
