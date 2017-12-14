using MyProject_Home.Common;
using MyProject_Home.Common.Encryption;
using MyProject_Home.DB.DAL;
using MyProject_Home.Entity.XmlEntity;
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
    public partial class frmLogin : Form
    {
        public static string LoginStatus = string.Empty;//记住登录状态
        public static string RememberPwd = string.Empty;//记住密码
        public static readonly string OriginalPwd = ConfigHelper.GetConfigString("DefaultPassword", "");
        public static readonly string OriginalAdminPwd = ConfigHelper.GetConfigString("AdminDefaultPassword", "");
        private static List<XmlLoginUserEntity> UserList = null;
        LoginUserDAL dal = new LoginUserDAL();
        //先获取记录登录的xml文件中的节点列表
        XmlHelper xml = new XmlHelper(CommonHelper.GetLoginUserXmlPath());

        /// <summary>
        /// 密码是否改变
        /// </summary>
        private bool PwdChanged { get; set; }

        public frmLogin()
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(OriginalPwd))
            {
                string defaultPwd = Md5.Encrypt(OriginalPwd);
            }
            if (!string.IsNullOrEmpty(OriginalAdminPwd))
            {
                string defaultAdminPwd = Md5.Encrypt(OriginalAdminPwd);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cboxUserName.Text))
            {
                MessageBox.Show("请输入用户名");
                this.cboxUserName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                MessageBox.Show("请输入密码");
                this.txtPassword.Focus();
                return;
            }
            if (dal.LoginCheck(this.cboxUserName.Text, Md5.Encrypt(this.txtPassword.Text)))
            {
                XmlLoginUserEntity entity = new XmlLoginUserEntity()
                {
                    UserName = this.cboxUserName.Text,
                    Password = new Encryption().Encrypto(this.txtPassword.Text),
                    CreateTime = DateTime.Now,
                    AutoLogin = this.cboxAutoLogin.Checked ? "1" : "0",
                    RememberPwd = this.cboxRememberPwd.Checked ? "1" : "0"
                };
                if (xml.AddOrEditLoginedUserInfo(entity))
                {
                    frmMain main = new frmMain(entity.UserName, Md5.Encrypt(this.txtPassword.Text));
                    
                    //隐藏当前窗体
                    this.WindowState = FormWindowState.Minimized;
                    //this.ShowInTaskbar = false;

                    if (main.ShowDialog() == DialogResult.Yes)
                    {
                        this.ShowInTaskbar = true;
                    }
                    else if (main.DialogResult == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                    return;
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                //先判断是否有默认登录，如果有，直接验证登录
                UserList = xml.GetLoginedUserInfo();
                var autoLogin = UserList.Where(s => s.AutoLogin == "1").FirstOrDefault();
                if (autoLogin != null)
                {
                    this.cboxUserName.Text = autoLogin.UserName;
                    string pwd = new Encryption().Decrypto(autoLogin.Password);
                    this.txtPassword.Text = pwd;
                    //如果有自动登录的记录，则直接验证用户名密码
                    if (!dal.LoginCheck(autoLogin.UserName, Md5.Encrypt(pwd)))
                    {
                        //MessageBox.Show("用户名或密码不正确");
                        this.cboxAutoLogin.Checked = true;
                        if (autoLogin.RememberPwd == "1")
                        {
                            this.cboxRememberPwd.Checked = true;
                        }
                        else
                        {
                            this.cboxRememberPwd.Checked = false;
                            this.txtPassword.Text = "";
                        }
                        return;
                    }

                    frmMain main = new frmMain(autoLogin.UserName, Md5.Encrypt(pwd));
                    main.UserName = autoLogin.UserName;
                    //隐藏当前窗体
                    this.WindowState = FormWindowState.Minimized;
                    //this.ShowInTaskbar = false;

                    if (main.ShowDialog() == DialogResult.Yes)
                    {
                        this.ShowInTaskbar = true;
                        this.cboxRememberPwd.Checked = "1".Equals(autoLogin.RememberPwd) ? true : false;
                        this.cboxAutoLogin.Checked = "1".Equals(autoLogin.AutoLogin) ? true : false;
                    }
                    else if (main.DialogResult == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                    return;
                }
                var list = UserList.OrderByDescending(s => s.CreateTime).ToList();
                if (list != null && list.Count > 0)
                {
                    var entity = list[0];
                    this.txtPassword.Text = new Encryption().Decrypto(entity.Password);
                    this.cboxRememberPwd.Checked = "1".Equals(entity.RememberPwd) ? true : false;
                    this.cboxAutoLogin.Checked = "1".Equals(entity.AutoLogin) ? true : false;

                    this.cboxUserName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    string[] arr = list.Select(s => s.UserName).ToArray();
                    this.cboxUserName.AutoCompleteCustomSource.AddRange(arr);
                    this.cboxUserName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    this.cboxUserName.DataSource = arr;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboxUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxUserName_KeyUp(sender, null);
        }
        
        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("暂未开通");
        }

        private void llblSeekBackPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("暂未开通");
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.PwdChanged = true;
        }

        private void cboxUserName_KeyUp(object sender, KeyEventArgs e)
        {
            string strUserName = this.cboxUserName.Text;
            if (!this.PwdChanged)
            {
                var userInfo = UserList.Where(s => s.UserName == strUserName).FirstOrDefault(); ;
                if (userInfo != null)
                {
                    this.txtPassword.Text = new Encryption().Decrypto(userInfo.Password);
                }
            }
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            PwdChanged = false;
        }
    }
}
