namespace MyProject_Home.EncryptAndDecrypt
{
    partial class frmEncryptAndDecrypt
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
            this.rbtnMD5 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtString = new System.Windows.Forms.TextBox();
            this.rtxtEncryption = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnDES = new System.Windows.Forms.RadioButton();
            this.rbtnReversible = new System.Windows.Forms.RadioButton();
            this.rbtnSymmetric = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEncryption = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtDecryptStr = new System.Windows.Forms.TextBox();
            this.rtxtDecrypt = new System.Windows.Forms.RichTextBox();
            this.rbtnDESDecrypt = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnReversibleDecrypt = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnSymmetricDecrypt = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnMD5
            // 
            this.rbtnMD5.AutoSize = true;
            this.rbtnMD5.Checked = true;
            this.rbtnMD5.Location = new System.Drawing.Point(8, 6);
            this.rbtnMD5.Name = "rbtnMD5";
            this.rbtnMD5.Size = new System.Drawing.Size(65, 16);
            this.rbtnMD5.TabIndex = 0;
            this.rbtnMD5.TabStop = true;
            this.rbtnMD5.Text = "MD5加密";
            this.rbtnMD5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "加密源字符串";
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(91, 37);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(667, 21);
            this.txtString.TabIndex = 2;
            // 
            // rtxtEncryption
            // 
            this.rtxtEncryption.Location = new System.Drawing.Point(91, 69);
            this.rtxtEncryption.Name = "rtxtEncryption";
            this.rtxtEncryption.Size = new System.Drawing.Size(667, 88);
            this.rtxtEncryption.TabIndex = 3;
            this.rtxtEncryption.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "加密后字符串";
            // 
            // rbtnDES
            // 
            this.rbtnDES.AutoSize = true;
            this.rbtnDES.Enabled = false;
            this.rbtnDES.Location = new System.Drawing.Point(233, 6);
            this.rbtnDES.Name = "rbtnDES";
            this.rbtnDES.Size = new System.Drawing.Size(65, 16);
            this.rbtnDES.TabIndex = 0;
            this.rbtnDES.Text = "DES加密";
            this.rbtnDES.UseVisualStyleBackColor = true;
            // 
            // rbtnReversible
            // 
            this.rbtnReversible.AutoSize = true;
            this.rbtnReversible.Enabled = false;
            this.rbtnReversible.Location = new System.Drawing.Point(79, 6);
            this.rbtnReversible.Name = "rbtnReversible";
            this.rbtnReversible.Size = new System.Drawing.Size(71, 16);
            this.rbtnReversible.TabIndex = 0;
            this.rbtnReversible.Text = "可逆加密";
            this.rbtnReversible.UseVisualStyleBackColor = true;
            // 
            // rbtnSymmetric
            // 
            this.rbtnSymmetric.AutoSize = true;
            this.rbtnSymmetric.Location = new System.Drawing.Point(156, 6);
            this.rbtnSymmetric.Name = "rbtnSymmetric";
            this.rbtnSymmetric.Size = new System.Drawing.Size(71, 16);
            this.rbtnSymmetric.TabIndex = 0;
            this.rbtnSymmetric.Text = "对称加密";
            this.rbtnSymmetric.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(774, 237);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEncryption);
            this.tabPage1.Controls.Add(this.txtString);
            this.tabPage1.Controls.Add(this.rtxtEncryption);
            this.tabPage1.Controls.Add(this.rbtnMD5);
            this.tabPage1.Controls.Add(this.rbtnDES);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rbtnReversible);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rbtnSymmetric);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "加密";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEncryption
            // 
            this.btnEncryption.Location = new System.Drawing.Point(91, 163);
            this.btnEncryption.Name = "btnEncryption";
            this.btnEncryption.Size = new System.Drawing.Size(169, 40);
            this.btnEncryption.TabIndex = 4;
            this.btnEncryption.Text = "加密";
            this.btnEncryption.UseVisualStyleBackColor = true;
            this.btnEncryption.Click += new System.EventHandler(this.btnEncryption_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDecrypt);
            this.tabPage2.Controls.Add(this.txtDecryptStr);
            this.tabPage2.Controls.Add(this.rtxtDecrypt);
            this.tabPage2.Controls.Add(this.rbtnDESDecrypt);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.rbtnReversibleDecrypt);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.rbtnSymmetricDecrypt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(766, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "解密";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(91, 164);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(169, 40);
            this.btnDecrypt.TabIndex = 13;
            this.btnDecrypt.Text = "解密";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtDecryptStr
            // 
            this.txtDecryptStr.Location = new System.Drawing.Point(91, 137);
            this.txtDecryptStr.Name = "txtDecryptStr";
            this.txtDecryptStr.Size = new System.Drawing.Size(667, 21);
            this.txtDecryptStr.TabIndex = 11;
            // 
            // rtxtDecrypt
            // 
            this.rtxtDecrypt.Location = new System.Drawing.Point(91, 38);
            this.rtxtDecrypt.Name = "rtxtDecrypt";
            this.rtxtDecrypt.Size = new System.Drawing.Size(667, 93);
            this.rtxtDecrypt.TabIndex = 12;
            this.rtxtDecrypt.Text = "";
            // 
            // rbtnDESDecrypt
            // 
            this.rbtnDESDecrypt.AutoSize = true;
            this.rbtnDESDecrypt.Enabled = false;
            this.rbtnDESDecrypt.Location = new System.Drawing.Point(162, 6);
            this.rbtnDESDecrypt.Name = "rbtnDESDecrypt";
            this.rbtnDESDecrypt.Size = new System.Drawing.Size(65, 16);
            this.rbtnDESDecrypt.TabIndex = 6;
            this.rbtnDESDecrypt.Text = "DES解密";
            this.rbtnDESDecrypt.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "解密后字符串";
            // 
            // rbtnReversibleDecrypt
            // 
            this.rbtnReversibleDecrypt.AutoSize = true;
            this.rbtnReversibleDecrypt.Enabled = false;
            this.rbtnReversibleDecrypt.Location = new System.Drawing.Point(8, 6);
            this.rbtnReversibleDecrypt.Name = "rbtnReversibleDecrypt";
            this.rbtnReversibleDecrypt.Size = new System.Drawing.Size(71, 16);
            this.rbtnReversibleDecrypt.TabIndex = 7;
            this.rbtnReversibleDecrypt.Text = "可逆解密";
            this.rbtnReversibleDecrypt.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "解密源字符串";
            // 
            // rbtnSymmetricDecrypt
            // 
            this.rbtnSymmetricDecrypt.AutoSize = true;
            this.rbtnSymmetricDecrypt.Location = new System.Drawing.Point(85, 6);
            this.rbtnSymmetricDecrypt.Name = "rbtnSymmetricDecrypt";
            this.rbtnSymmetricDecrypt.Size = new System.Drawing.Size(71, 16);
            this.rbtnSymmetricDecrypt.TabIndex = 8;
            this.rbtnSymmetricDecrypt.Text = "对称解密";
            this.rbtnSymmetricDecrypt.UseVisualStyleBackColor = true;
            // 
            // frmEncryptAndDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 237);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEncryptAndDecrypt";
            this.Text = "加密解密";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnMD5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.RichTextBox rtxtEncryption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnDES;
        private System.Windows.Forms.RadioButton rbtnReversible;
        private System.Windows.Forms.RadioButton rbtnSymmetric;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEncryption;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtDecryptStr;
        private System.Windows.Forms.RichTextBox rtxtDecrypt;
        private System.Windows.Forms.RadioButton rbtnDESDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnReversibleDecrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnSymmetricDecrypt;
    }
}

