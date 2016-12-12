using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// added namespaces
using System.IO;
using System.Security.Cryptography;
using System.Security;

namespace CustomEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Design start
            txtKey.PasswordChar = '*';
            txtPassword.PasswordChar = '*';
            txtTextKey.PasswordChar = '*';
            txtKey.MaxLength = 8;
            txtPassword.MaxLength = 8;
            txtTextKey.MaxLength = 8;
            this.richTextBox1.Visible = false;
            this.richTextBox2.Visible = false;
            this.btnText.Visible = false;
            this.labelTextKey.Visible = false;
            this.txtTextKey.Visible = false;
            this.txtPassword.Visible = false;
            this.labelPassword.Visible = false;
            // Design End
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxEncryption_CheckedChanged(object sender, EventArgs e)
        {
            // Design start
            if (checkBoxEncryption.Checked == true)
            {
                checkBoxDecryption.Enabled = false;
                this.button3.Text = "Encryption";
                this.button3.Image = global::CustomEncryption.Properties.Resources.locked_lock;
                this.btnText.Text = "Encryption";
                this.btnText.Image = global::CustomEncryption.Properties.Resources.locked_lock;
                this.currentStageLabel.Text = "Encryption operation was chosen";
            }
            else if (checkBoxEncryption.Checked == false)
            {
                checkBoxDecryption.Enabled = true;
            }
            // Design End
        }

        private void checkBoxDecryption_CheckedChanged(object sender, EventArgs e)
        {
            // Design start
            if (checkBoxDecryption.Checked == true)
            {
                checkBoxEncryption.Enabled = false;
                this.button3.Text = "Decryption";
                this.button3.Image = global::CustomEncryption.Properties.Resources.unlocked_lock;
                this.btnText.Text = "Decryption";
                this.btnText.Image = global::CustomEncryption.Properties.Resources.unlocked_lock;
                this.currentStageLabel.Text = "Decryption operation was chosen";
            }
            else if (checkBoxDecryption.Checked == false)
            {
                checkBoxEncryption.Enabled = true;
            }
            // Design End
        }

        private void button1_Click(object sender, EventArgs e)
        { // Search button
            OpenFileDialog openfile = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                txtSearch.Text = path;
            }

        }

        private void checkBoxText_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxText.Checked == true)
            {
                txtKey.PasswordChar = '*';
                txtKey.MaxLength = 8;
                txtTextKey.PasswordChar = '*';
                txtTextKey.MaxLength = 8;
                txtPassword.PasswordChar = '*';
                this.richTextBox1.Visible = true;
                this.richTextBox2.Visible = true;
                this.btnText.Visible = true;
                this.labelTextKey.Visible = true;
                this.txtTextKey.Visible = true;
                this.txtSearch.Visible = false;
                this.txtSave.Visible = false;
                this.txtPassword.Visible = true;
                this.labelPassword.Visible = true;
            }
            else if (checkBoxText.Checked == false)
            {
                txtKey.PasswordChar = '*';
                txtKey.MaxLength = 8;
                txtTextKey.PasswordChar = '*';
                txtTextKey.MaxLength = 8;
                txtPassword.PasswordChar = '*';
                this.richTextBox1.Visible = false;
                this.richTextBox2.Visible = false;
                this.btnText.Visible = false;
                this.labelTextKey.Visible = false;
                this.txtTextKey.Visible = false;
                this.txtSearch.Visible = true;
                this.txtSave.Visible = true;
                this.txtPassword.Visible = false;
                this.labelPassword.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (button3.Text)
            {
                default: break;
                case "Encryption":
                    {
                        try
                        {
                            string password = txtKey.Text;
                            UnicodeEncoding UE = new UnicodeEncoding();
                            byte[] key = UE.GetBytes(password);
                            string cryptedfile = txtSave.Text;
                            FileStream FsCrypt = new FileStream(cryptedfile, FileMode.Create);
                            RijndaelManaged RMCrypt = new RijndaelManaged();
                            CryptoStream CS = new CryptoStream(FsCrypt, RMCrypt.CreateEncryptor(key, key), CryptoStreamMode.Write);
                            FileStream FSIN = new FileStream(txtSearch.Text, FileMode.Open);
                            int data;
                            while ((data = FSIN.ReadByte()) != -1)
                                CS.WriteByte((byte)data);
                            FSIN.Close();
                            CS.Close();
                            FsCrypt.Close();
                            currentStageLabel.Text = "Done";
                            MessageBox.Show("the Encryption operation is done correctly");
                        }
                        catch (Exception)
                        {
                            currentStageLabel.Text = "the encryption operation failed";
                            MessageBox.Show("Error");
                        }
                        break;
                    }
                case "Decryption":
                    {
                        try
                        {
                            string password = txtKey.Text;
                            UnicodeEncoding UE = new UnicodeEncoding();
                            byte[] key = UE.GetBytes(password);
                            string cryptedfile = txtSearch.Text;
                            FileStream FsCrypt = new FileStream(cryptedfile, FileMode.Open);
                            RijndaelManaged RMCrypt = new RijndaelManaged();
                            CryptoStream CS = new CryptoStream(FsCrypt, RMCrypt.CreateDecryptor(key, key), CryptoStreamMode.Read);
                            FileStream FSout = new FileStream(txtSave.Text, FileMode.Create);
                            int data;
                            while ((data = CS.ReadByte()) != -1)
                                FSout.WriteByte((byte)data);
                            FSout.Close();
                            CS.Close();
                            FsCrypt.Close();
                            currentStageLabel.Text = "done";
                            MessageBox.Show("the Decryption operation is done correctly");
                        }
                        catch (Exception)
                        {
                            currentStageLabel.Text = "opertaion failed";
                            MessageBox.Show("Error");
                        }
                        break;
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog Savefile = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                txtSave.Text = path;
            }
        }

        private void btnText_Click(object sender, EventArgs e)
        // string !@^#(g`qp-+/%&0[
        {
                string VIKey = "!@^#(g`qp-+/%&0["; //choose your 16 char
                switch (btnText.Text)
                {
                    default: break;
                    case "Encryption":
                        {
                            try
                            {
                                byte[] palintextbyt = Encoding.UTF8.GetBytes(richTextBox1.Text);
                                byte[] keyBytes = new Rfc2898DeriveBytes(txtPassword.Text, Encoding.ASCII.GetBytes(txtTextKey.Text)).GetBytes(256 / 8);
                                var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
                                var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
                                byte[] cipherTextBytes;
                                using (var memoryStream = new MemoryStream())
                                {
                                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                                    {
                                        cryptoStream.Write(palintextbyt, 0, palintextbyt.Length);
                                        cryptoStream.FlushFinalBlock();
                                        cipherTextBytes = memoryStream.ToArray();
                                        cryptoStream.Close();
                                    }
                                    memoryStream.Close();
                                    richTextBox2.Text = Convert.ToBase64String(cipherTextBytes);
                                    currentStageLabel.Text = "Done";
                                    MessageBox.Show("the Encryption operation is done correctly");
                                }
                            }
                            catch (Exception)
                            {
                                currentStageLabel.Text = "the Encryption operation failed";
                                MessageBox.Show("Error");
                            }
                            break;
                        }
                    case "Decryption":
                        {
                            try
                            {
                                byte[] cipherTextBytes = Convert.FromBase64String(richTextBox2.Text);
                                byte[] keyBytes = new Rfc2898DeriveBytes(txtPassword.Text, Encoding.ASCII.GetBytes(txtTextKey.Text)).GetBytes(256 / 8);
                                var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };
                                var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
                                var memoryStream = new MemoryStream(cipherTextBytes);
                                var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                                byte[] plainTextBytes = new byte[cipherTextBytes.Length];
                                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                richTextBox1.Text = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
                                currentStageLabel.Text = "done";
                                MessageBox.Show("the Decryption operation is done correctly");
                            }
                            catch (Exception)
                            {
                                currentStageLabel.Text = "Operation failed";
                                MessageBox.Show("Error");
                            }
                            break;
                        }
                }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
