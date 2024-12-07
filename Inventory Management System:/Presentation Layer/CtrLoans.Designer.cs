namespace BankSystem
{
    partial class CtrLoans
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
            this.LbFormAddress = new System.Windows.Forms.Label();
            this.LbLoanAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxLoanPrice = new System.Windows.Forms.TextBox();
            this.UdBenifetPercentage = new System.Windows.Forms.NumericUpDown();
            this.UdPaymentPeriod = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TxLoanId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UdBenifetPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdPaymentPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // LbFormAddress
            // 
            this.LbFormAddress.AutoSize = true;
            this.LbFormAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFormAddress.Location = new System.Drawing.Point(167, 17);
            this.LbFormAddress.Name = "LbFormAddress";
            this.LbFormAddress.Size = new System.Drawing.Size(214, 36);
            this.LbFormAddress.TabIndex = 0;
            this.LbFormAddress.Text = "Form Address";
            // 
            // LbLoanAmount
            // 
            this.LbLoanAmount.AutoSize = true;
            this.LbLoanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLoanAmount.Location = new System.Drawing.Point(14, 137);
            this.LbLoanAmount.Name = "LbLoanAmount";
            this.LbLoanAmount.Size = new System.Drawing.Size(106, 22);
            this.LbLoanAmount.TabIndex = 1;
            this.LbLoanAmount.Text = "Loan Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Benifet Percentage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Payment Period(year)";
            // 
            // TxLoanPrice
            // 
            this.TxLoanPrice.Location = new System.Drawing.Point(289, 139);
            this.TxLoanPrice.Name = "TxLoanPrice";
            this.TxLoanPrice.Size = new System.Drawing.Size(125, 22);
            this.TxLoanPrice.TabIndex = 4;
            // 
            // UdBenifetPercentage
            // 
            this.UdBenifetPercentage.DecimalPlaces = 2;
            this.UdBenifetPercentage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.UdBenifetPercentage.Location = new System.Drawing.Point(289, 197);
            this.UdBenifetPercentage.Name = "UdBenifetPercentage";
            this.UdBenifetPercentage.Size = new System.Drawing.Size(125, 22);
            this.UdBenifetPercentage.TabIndex = 5;
            // 
            // UdPaymentPeriod
            // 
            this.UdPaymentPeriod.Location = new System.Drawing.Point(289, 256);
            this.UdPaymentPeriod.Name = "UdPaymentPeriod";
            this.UdPaymentPeriod.Size = new System.Drawing.Size(125, 22);
            this.UdPaymentPeriod.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loan Id";
            // 
            // TxLoanId
            // 
            this.TxLoanId.Location = new System.Drawing.Point(213, 78);
            this.TxLoanId.Name = "TxLoanId";
            this.TxLoanId.Size = new System.Drawing.Size(125, 22);
            this.TxLoanId.TabIndex = 8;
            // 
            // CtrLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxLoanId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UdPaymentPeriod);
            this.Controls.Add(this.UdBenifetPercentage);
            this.Controls.Add(this.TxLoanPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbLoanAmount);
            this.Controls.Add(this.LbFormAddress);
            this.Name = "CtrLoans";
            this.Size = new System.Drawing.Size(624, 289);
            this.Load += new System.EventHandler(this.CtrLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UdBenifetPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdPaymentPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbFormAddress;
        private System.Windows.Forms.Label LbLoanAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxLoanPrice;
        private System.Windows.Forms.NumericUpDown UdBenifetPercentage;
        private System.Windows.Forms.NumericUpDown UdPaymentPeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxLoanId;
    }
}
