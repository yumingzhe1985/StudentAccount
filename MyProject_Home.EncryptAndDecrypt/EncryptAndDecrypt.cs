using MyProject_Home.Common.Encryption;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject_Home.EncryptAndDecrypt
{
    public partial class frmEncryptAndDecrypt : Form
    {
        public frmEncryptAndDecrypt()
        {
            InitializeComponent();
        }

        //解密
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.rtxtDecrypt.Text))
            {
                this.rtxtDecrypt.Focus();
                return;
            }
            if (this.rbtnDESDecrypt.Checked)
            { }
            else if (this.rbtnReversibleDecrypt.Checked)
            {
                try
                {
                    this.txtDecryptStr.Text = Encryption.Decode(this.rtxtDecrypt.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (this.rbtnSymmetricDecrypt.Checked)
            {
                this.txtDecryptStr.Text = new Encryption().Decrypto(this.rtxtDecrypt.Text);
            }
        }

        //加密
        private void btnEncryption_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtString.Text))
            {
                this.txtString.Focus();
                return;
            }
            if (this.rbtnMD5.Checked)
            {
                this.rtxtEncryption.Text = Encryption.Encrypt(this.txtString.Text);
            }
            else if (this.rbtnReversible.Checked)
            {
                this.rtxtEncryption.Text = Encryption.Encode(this.txtString.Text);
            }
            else if (this.rbtnSymmetric.Checked)
            {
                this.rtxtEncryption.Text = new Encryption().Encrypto(this.txtString.Text);
            }
            else if (this.rbtnDES.Checked)
            { }
        }
    }
}
