using MyProject_Home.DB.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject_Home
{
    public partial class frmMain : Form
    {
        DialogResult res;
        public string UserName = string.Empty;
        public string PassWord = string.Empty;
        CustomerDAL dal = new CustomerDAL();

        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string userName, string password)
        {
            this.UserName = userName;
            this.PassWord = password;
        }


        private void btnCancellation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要注销么？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                res = DialogResult.Yes;
                this.DialogResult = res;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("确定要关闭当前系统吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (res != DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    res = DialogResult.None;
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.lblCurrentUserName.Text += string.Format(" [{0}]",UserName);

            DataSet ds = dal.GetAllCustomer(UserName, PassWord);
            this.dgvCustomer.DataSource = ds.Tables[0];
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

        }

        private void btnFristPage_Click(object sender, EventArgs e)
        {

        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {

        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {

        }

        private void linklblAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OperateData od = new MyProject_Home.OperateData();
            od.Show();
        }

        private void linklblEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //dgvCustomer.SelectedRows.
        }
    }
}
