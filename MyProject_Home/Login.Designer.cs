namespace MyProject_Home
{
    partial class frmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxUserName = new System.Windows.Forms.ComboBox();
            this.cboxRememberPwd = new System.Windows.Forms.CheckBox();
            this.cboxAutoLogin = new System.Windows.Forms.CheckBox();
            this.llblRegister = new System.Windows.Forms.LinkLabel();
            this.llblSeekBackPwd = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(67, 131);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(306, 33);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登 录 系 统";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(112, 71);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(202, 21);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // cboxUserName
            // 
            this.cboxUserName.FormattingEnabled = true;
            this.cboxUserName.Location = new System.Drawing.Point(112, 45);
            this.cboxUserName.Name = "cboxUserName";
            this.cboxUserName.Size = new System.Drawing.Size(202, 20);
            this.cboxUserName.TabIndex = 3;
            this.cboxUserName.SelectedIndexChanged += new System.EventHandler(this.cboxUserName_SelectedIndexChanged);
            this.cboxUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboxUserName_KeyUp);
            // 
            // cboxRememberPwd
            // 
            this.cboxRememberPwd.AutoSize = true;
            this.cboxRememberPwd.Location = new System.Drawing.Point(112, 98);
            this.cboxRememberPwd.Name = "cboxRememberPwd";
            this.cboxRememberPwd.Size = new System.Drawing.Size(72, 16);
            this.cboxRememberPwd.TabIndex = 4;
            this.cboxRememberPwd.Text = "记住密码";
            this.cboxRememberPwd.UseVisualStyleBackColor = true;
            // 
            // cboxAutoLogin
            // 
            this.cboxAutoLogin.AutoSize = true;
            this.cboxAutoLogin.Location = new System.Drawing.Point(196, 98);
            this.cboxAutoLogin.Name = "cboxAutoLogin";
            this.cboxAutoLogin.Size = new System.Drawing.Size(72, 16);
            this.cboxAutoLogin.TabIndex = 4;
            this.cboxAutoLogin.Text = "自动登录";
            this.cboxAutoLogin.UseVisualStyleBackColor = true;
            // 
            // llblRegister
            // 
            this.llblRegister.AutoSize = true;
            this.llblRegister.Location = new System.Drawing.Point(320, 48);
            this.llblRegister.Name = "llblRegister";
            this.llblRegister.Size = new System.Drawing.Size(53, 12);
            this.llblRegister.TabIndex = 5;
            this.llblRegister.TabStop = true;
            this.llblRegister.Text = "账户注册";
            this.llblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRegister_LinkClicked);
            // 
            // llblSeekBackPwd
            // 
            this.llblSeekBackPwd.AutoSize = true;
            this.llblSeekBackPwd.Location = new System.Drawing.Point(320, 74);
            this.llblSeekBackPwd.Name = "llblSeekBackPwd";
            this.llblSeekBackPwd.Size = new System.Drawing.Size(53, 12);
            this.llblSeekBackPwd.TabIndex = 5;
            this.llblSeekBackPwd.TabStop = true;
            this.llblSeekBackPwd.Text = "找回密码";
            this.llblSeekBackPwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSeekBackPwd_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 190);
            this.Controls.Add(this.llblSeekBackPwd);
            this.Controls.Add(this.llblRegister);
            this.Controls.Add(this.cboxAutoLogin);
            this.Controls.Add(this.cboxRememberPwd);
            this.Controls.Add(this.cboxUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Shown += new System.EventHandler(this.frmLogin_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxUserName;
        private System.Windows.Forms.CheckBox cboxRememberPwd;
        private System.Windows.Forms.CheckBox cboxAutoLogin;
        private System.Windows.Forms.LinkLabel llblRegister;
        private System.Windows.Forms.LinkLabel llblSeekBackPwd;
    }
}

