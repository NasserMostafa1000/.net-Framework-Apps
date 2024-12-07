namespace BankSystem
{
    partial class CtrlCertificate
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
            this.TxCertificatePrice = new System.Windows.Forms.TextBox();
            this.TxTotalProfit = new System.Windows.Forms.TextBox();
            this.TxId = new System.Windows.Forms.TextBox();
            this.UdCertificatePeriod = new System.Windows.Forms.NumericUpDown();
            this.LbControlAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UdProfitPercentage = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UdCertificatePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdProfitPercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // TxCertificatePrice
            // 
            this.TxCertificatePrice.Location = new System.Drawing.Point(181, 153);
            this.TxCertificatePrice.Name = "TxCertificatePrice";
            this.TxCertificatePrice.Size = new System.Drawing.Size(137, 22);
            this.TxCertificatePrice.TabIndex = 0;
            // 
            // TxTotalProfit
            // 
            this.TxTotalProfit.Location = new System.Drawing.Point(181, 219);
            this.TxTotalProfit.Name = "TxTotalProfit";
            this.TxTotalProfit.Size = new System.Drawing.Size(137, 22);
            this.TxTotalProfit.TabIndex = 1;
            // 
            // TxId
            // 
            this.TxId.Location = new System.Drawing.Point(279, 85);
            this.TxId.Name = "TxId";
            this.TxId.Size = new System.Drawing.Size(137, 22);
            this.TxId.TabIndex = 0;
            // 
            // UdCertificatePeriod
            // 
            this.UdCertificatePeriod.Location = new System.Drawing.Point(598, 152);
            this.UdCertificatePeriod.Name = "UdCertificatePeriod";
            this.UdCertificatePeriod.Size = new System.Drawing.Size(120, 22);
            this.UdCertificatePeriod.TabIndex = 3;
            // 
            // LbControlAddress
            // 
            this.LbControlAddress.AutoSize = true;
            this.LbControlAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbControlAddress.Location = new System.Drawing.Point(188, 24);
            this.LbControlAddress.Name = "LbControlAddress";
            this.LbControlAddress.Size = new System.Drawing.Size(366, 42);
            this.LbControlAddress.TabIndex = 4;
            this.LbControlAddress.Text = "Add New Certificate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Certificate Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Certificate Period(year)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Profit Percentage(Month)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Certificate Price";
            // 
            // UdProfitPercentage
            // 
            this.UdProfitPercentage.DecimalPlaces = 2;
            this.UdProfitPercentage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.UdProfitPercentage.Location = new System.Drawing.Point(598, 220);
            this.UdProfitPercentage.Name = "UdProfitPercentage";
            this.UdProfitPercentage.Size = new System.Drawing.Size(120, 22);
            this.UdProfitPercentage.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total Profit";
            // 
            // CtrlCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UdProfitPercentage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbControlAddress);
            this.Controls.Add(this.UdCertificatePeriod);
            this.Controls.Add(this.TxId);
            this.Controls.Add(this.TxTotalProfit);
            this.Controls.Add(this.TxCertificatePrice);
            this.Name = "CtrlCertificate";
            this.Size = new System.Drawing.Size(739, 284);
            this.Load += new System.EventHandler(this.CtrlCertificate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UdCertificatePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdProfitPercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxCertificatePrice;
        private System.Windows.Forms.TextBox TxTotalProfit;
        private System.Windows.Forms.TextBox TxId;
        private System.Windows.Forms.NumericUpDown UdCertificatePeriod;
        private System.Windows.Forms.Label LbControlAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown UdProfitPercentage;
        private System.Windows.Forms.Label label3;
    }
}
