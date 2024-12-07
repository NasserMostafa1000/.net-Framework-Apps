namespace BankSystem
{
    partial class ctrlCreditors
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxCertificate = new System.Windows.Forms.TextBox();
            this.TxName = new System.Windows.Forms.TextBox();
            this.BtnChooseCertificate = new System.Windows.Forms.Button();
            this.BtnChooseClient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbFormAddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxCertificate
            // 
            this.TxCertificate.Location = new System.Drawing.Point(624, 245);
            this.TxCertificate.Name = "TxCertificate";
            this.TxCertificate.Size = new System.Drawing.Size(135, 22);
            this.TxCertificate.TabIndex = 13;
            // 
            // TxName
            // 
            this.TxName.Location = new System.Drawing.Point(624, 133);
            this.TxName.Name = "TxName";
            this.TxName.Size = new System.Drawing.Size(135, 22);
            this.TxName.TabIndex = 12;
            // 
            // BtnChooseCertificate
            // 
            this.BtnChooseCertificate.Location = new System.Drawing.Point(309, 244);
            this.BtnChooseCertificate.Name = "BtnChooseCertificate";
            this.BtnChooseCertificate.Size = new System.Drawing.Size(90, 23);
            this.BtnChooseCertificate.TabIndex = 11;
            this.BtnChooseCertificate.Text = "Choose";
            this.BtnChooseCertificate.UseVisualStyleBackColor = true;
            this.BtnChooseCertificate.Click += new System.EventHandler(this.BtnChooseCertificate_Click);
            // 
            // BtnChooseClient
            // 
            this.BtnChooseClient.Location = new System.Drawing.Point(309, 133);
            this.BtnChooseClient.Name = "BtnChooseClient";
            this.BtnChooseClient.Size = new System.Drawing.Size(90, 23);
            this.BtnChooseClient.TabIndex = 10;
            this.BtnChooseClient.Text = "Choose";
            this.BtnChooseClient.UseVisualStyleBackColor = true;
            this.BtnChooseClient.Click += new System.EventHandler(this.BtnChooseClient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose cretificate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose Client";
            // 
            // LbFormAddress
            // 
            this.LbFormAddress.AutoSize = true;
            this.LbFormAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFormAddress.Location = new System.Drawing.Point(230, 10);
            this.LbFormAddress.Name = "LbFormAddress";
            this.LbFormAddress.Size = new System.Drawing.Size(264, 42);
            this.LbFormAddress.TabIndex = 7;
            this.LbFormAddress.Text = "Form Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Full Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price";
            // 
            // TxID
            // 
            this.TxID.Location = new System.Drawing.Point(294, 68);
            this.TxID.Name = "TxID";
            this.TxID.Size = new System.Drawing.Size(130, 22);
            this.TxID.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cerditor ID";
            // 
            // ctrlCreditors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxCertificate);
            this.Controls.Add(this.TxName);
            this.Controls.Add(this.BtnChooseCertificate);
            this.Controls.Add(this.BtnChooseClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbFormAddress);
            this.Name = "ctrlCreditors";
            this.Size = new System.Drawing.Size(777, 293);
            this.Load += new System.EventHandler(this.ctrlCreditors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxCertificate;
        private System.Windows.Forms.TextBox TxName;
        private System.Windows.Forms.Button BtnChooseCertificate;
        private System.Windows.Forms.Button BtnChooseClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbFormAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxID;
        private System.Windows.Forms.Label label5;
    }
}
