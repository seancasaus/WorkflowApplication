using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcTip_Click(object sender, EventArgs e)
        {
            GetTip.ServiceClient getTip = new GetTip.ServiceClient();

            if(this.tipBox.Text.Length != 0 && this.billBox.Text.Length != 0)
            {
                double percent = 0.01 * System.Convert.ToDouble(this.tipBox.Text);
                double bill = System.Convert.ToDouble(this.billBox.Text);
                String tip = getTip.GetTip(bill, percent);
                if(tip.Equals("0"))
                {
                    this.tipAmtLabel.Text = "Enter a valid percentage";
                }
                else
                {
                    this.tipAmtLabel.Text = "Tip: $ " + tip;
                }
            }
            else
            {
                this.tipAmtLabel.Text = "Enter both a tip percentage and a bill amount";
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            Crypto.ServiceClient crypto = new Crypto.ServiceClient();
            CodeActivity1 newCA = new CodeActivity1();

            String originalMessage = System.Convert.ToString(this.stringBox.Text);
            String encryptedMessage = crypto.Encrypt(originalMessage);
            this.messageLabel1.Text = "Encrypted Message: " + encryptedMessage;
            this.decrypterBox.Text = encryptedMessage;
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            Crypto.ServiceClient crypto = new Crypto.ServiceClient();

            String encryptedMessage = System.Convert.ToString(this.decrypterBox.Text);
            String decryptedMessage = crypto.Decrypt(encryptedMessage);
            this.decryptedMessage.Text = "Decrypted Message: " + decryptedMessage;
        }
    }
}
