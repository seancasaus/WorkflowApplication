namespace myApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tipAmtLabel = new System.Windows.Forms.Label();
            this.moneySymb = new System.Windows.Forms.Label();
            this.calcTip = new System.Windows.Forms.Button();
            this.symbLabel = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.tipBox = new System.Windows.Forms.TextBox();
            this.billBox = new System.Windows.Forms.TextBox();
            this.billLabel = new System.Windows.Forms.Label();
            this.tipCalcLabel = new System.Windows.Forms.Label();
            this.stringLabel = new System.Windows.Forms.Label();
            this.stringBox = new System.Windows.Forms.TextBox();
            this.encryptedLabel = new System.Windows.Forms.Label();
            this.cryptoLabel = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.messageLabel1 = new System.Windows.Forms.Label();
            this.decryptedMessage = new System.Windows.Forms.Label();
            this.decryptButton = new System.Windows.Forms.Button();
            this.decrypterLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decrypterBox = new System.Windows.Forms.TextBox();
            this.messageLabel2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // tipAmtLabel
            // 
            this.tipAmtLabel.AutoSize = true;
            this.tipAmtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tipAmtLabel.ForeColor = System.Drawing.Color.Coral;
            this.tipAmtLabel.Location = new System.Drawing.Point(176, 172);
            this.tipAmtLabel.Name = "tipAmtLabel";
            this.tipAmtLabel.Size = new System.Drawing.Size(62, 25);
            this.tipAmtLabel.TabIndex = 17;
            this.tipAmtLabel.Text = "Tip: $";
            // 
            // moneySymb
            // 
            this.moneySymb.AutoSize = true;
            this.moneySymb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.moneySymb.ForeColor = System.Drawing.Color.Coral;
            this.moneySymb.Location = new System.Drawing.Point(78, 65);
            this.moneySymb.Name = "moneySymb";
            this.moneySymb.Size = new System.Drawing.Size(23, 25);
            this.moneySymb.TabIndex = 16;
            this.moneySymb.Text = "$";
            // 
            // calcTip
            // 
            this.calcTip.BackColor = System.Drawing.Color.LightGray;
            this.calcTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calcTip.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.calcTip.Location = new System.Drawing.Point(29, 165);
            this.calcTip.Name = "calcTip";
            this.calcTip.Size = new System.Drawing.Size(122, 32);
            this.calcTip.TabIndex = 15;
            this.calcTip.Text = "Calculate";
            this.calcTip.UseVisualStyleBackColor = false;
            this.calcTip.Click += new System.EventHandler(this.calcTip_Click);
            // 
            // symbLabel
            // 
            this.symbLabel.AutoSize = true;
            this.symbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.symbLabel.ForeColor = System.Drawing.Color.Coral;
            this.symbLabel.Location = new System.Drawing.Point(274, 116);
            this.symbLabel.Name = "symbLabel";
            this.symbLabel.Size = new System.Drawing.Size(30, 25);
            this.symbLabel.TabIndex = 14;
            this.symbLabel.Text = "%";
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tipLabel.ForeColor = System.Drawing.Color.Coral;
            this.tipLabel.Location = new System.Drawing.Point(24, 116);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(90, 25);
            this.tipLabel.TabIndex = 13;
            this.tipLabel.Text = "Percent: ";
            // 
            // tipBox
            // 
            this.tipBox.Location = new System.Drawing.Point(120, 116);
            this.tipBox.Name = "tipBox";
            this.tipBox.Size = new System.Drawing.Size(148, 22);
            this.tipBox.TabIndex = 12;
            // 
            // billBox
            // 
            this.billBox.Location = new System.Drawing.Point(107, 65);
            this.billBox.Name = "billBox";
            this.billBox.Size = new System.Drawing.Size(148, 22);
            this.billBox.TabIndex = 11;
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.billLabel.ForeColor = System.Drawing.Color.Coral;
            this.billLabel.Location = new System.Drawing.Point(24, 65);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(48, 25);
            this.billLabel.TabIndex = 10;
            this.billLabel.Text = "Bill: ";
            // 
            // tipCalcLabel
            // 
            this.tipCalcLabel.AutoSize = true;
            this.tipCalcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tipCalcLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tipCalcLabel.Location = new System.Drawing.Point(12, 9);
            this.tipCalcLabel.Name = "tipCalcLabel";
            this.tipCalcLabel.Size = new System.Drawing.Size(228, 39);
            this.tipCalcLabel.TabIndex = 9;
            this.tipCalcLabel.Text = "Tip Calculator";
            // 
            // stringLabel
            // 
            this.stringLabel.AutoSize = true;
            this.stringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.stringLabel.ForeColor = System.Drawing.Color.Coral;
            this.stringLabel.Location = new System.Drawing.Point(24, 286);
            this.stringLabel.Name = "stringLabel";
            this.stringLabel.Size = new System.Drawing.Size(104, 25);
            this.stringLabel.TabIndex = 18;
            this.stringLabel.Text = "Message: ";
            // 
            // stringBox
            // 
            this.stringBox.Location = new System.Drawing.Point(134, 286);
            this.stringBox.Name = "stringBox";
            this.stringBox.Size = new System.Drawing.Size(148, 22);
            this.stringBox.TabIndex = 19;
            // 
            // encryptedLabel
            // 
            this.encryptedLabel.AutoSize = true;
            this.encryptedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.encryptedLabel.ForeColor = System.Drawing.Color.Coral;
            this.encryptedLabel.Location = new System.Drawing.Point(24, 354);
            this.encryptedLabel.Name = "encryptedLabel";
            this.encryptedLabel.Size = new System.Drawing.Size(0, 25);
            this.encryptedLabel.TabIndex = 20;
            // 
            // cryptoLabel
            // 
            this.cryptoLabel.AutoSize = true;
            this.cryptoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cryptoLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cryptoLabel.Location = new System.Drawing.Point(12, 232);
            this.cryptoLabel.Name = "cryptoLabel";
            this.cryptoLabel.Size = new System.Drawing.Size(162, 39);
            this.cryptoLabel.TabIndex = 21;
            this.cryptoLabel.Text = "Encrypter";
            // 
            // encryptButton
            // 
            this.encryptButton.BackColor = System.Drawing.Color.LightGray;
            this.encryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.encryptButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.encryptButton.Location = new System.Drawing.Point(29, 328);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(122, 32);
            this.encryptButton.TabIndex = 22;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = false;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // messageLabel1
            // 
            this.messageLabel1.AutoSize = true;
            this.messageLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.messageLabel1.ForeColor = System.Drawing.Color.Coral;
            this.messageLabel1.Location = new System.Drawing.Point(176, 332);
            this.messageLabel1.Name = "messageLabel1";
            this.messageLabel1.Size = new System.Drawing.Size(197, 25);
            this.messageLabel1.TabIndex = 23;
            this.messageLabel1.Text = "Encrypted Message: ";
            // 
            // decryptedMessage
            // 
            this.decryptedMessage.AutoSize = true;
            this.decryptedMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.decryptedMessage.ForeColor = System.Drawing.Color.Coral;
            this.decryptedMessage.Location = new System.Drawing.Point(176, 499);
            this.decryptedMessage.Name = "decryptedMessage";
            this.decryptedMessage.Size = new System.Drawing.Size(198, 25);
            this.decryptedMessage.TabIndex = 29;
            this.decryptedMessage.Text = "Decrypted Message: ";
            // 
            // decryptButton
            // 
            this.decryptButton.BackColor = System.Drawing.Color.LightGray;
            this.decryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.decryptButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.decryptButton.Location = new System.Drawing.Point(29, 495);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(122, 32);
            this.decryptButton.TabIndex = 28;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = false;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // decrypterLabel
            // 
            this.decrypterLabel.AutoSize = true;
            this.decrypterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.decrypterLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.decrypterLabel.Location = new System.Drawing.Point(12, 399);
            this.decrypterLabel.Name = "decrypterLabel";
            this.decrypterLabel.Size = new System.Drawing.Size(164, 39);
            this.decrypterLabel.TabIndex = 27;
            this.decrypterLabel.Text = "Decrypter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(24, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 26;
            // 
            // decrypterBox
            // 
            this.decrypterBox.Location = new System.Drawing.Point(134, 453);
            this.decrypterBox.Name = "decrypterBox";
            this.decrypterBox.Size = new System.Drawing.Size(148, 22);
            this.decrypterBox.TabIndex = 25;
            // 
            // messageLabel2
            // 
            this.messageLabel2.AutoSize = true;
            this.messageLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.messageLabel2.ForeColor = System.Drawing.Color.Coral;
            this.messageLabel2.Location = new System.Drawing.Point(24, 453);
            this.messageLabel2.Name = "messageLabel2";
            this.messageLabel2.Size = new System.Drawing.Size(104, 25);
            this.messageLabel2.TabIndex = 24;
            this.messageLabel2.Text = "Message: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 645);
            this.Controls.Add(this.decryptedMessage);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.decrypterLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decrypterBox);
            this.Controls.Add(this.messageLabel2);
            this.Controls.Add(this.messageLabel1);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.cryptoLabel);
            this.Controls.Add(this.encryptedLabel);
            this.Controls.Add(this.stringBox);
            this.Controls.Add(this.stringLabel);
            this.Controls.Add(this.tipAmtLabel);
            this.Controls.Add(this.moneySymb);
            this.Controls.Add(this.calcTip);
            this.Controls.Add(this.symbLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.tipBox);
            this.Controls.Add(this.billBox);
            this.Controls.Add(this.billLabel);
            this.Controls.Add(this.tipCalcLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tipAmtLabel;
        private System.Windows.Forms.Label moneySymb;
        private System.Windows.Forms.Button calcTip;
        private System.Windows.Forms.Label symbLabel;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.TextBox tipBox;
        private System.Windows.Forms.TextBox billBox;
        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.Label tipCalcLabel;
        private System.Windows.Forms.Label stringLabel;
        private System.Windows.Forms.TextBox stringBox;
        private System.Windows.Forms.Label encryptedLabel;
        private System.Windows.Forms.Label cryptoLabel;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Label messageLabel1;
        private System.Windows.Forms.Label decryptedMessage;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Label decrypterLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox decrypterBox;
        private System.Windows.Forms.Label messageLabel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

