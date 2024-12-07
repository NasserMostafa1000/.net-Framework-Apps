namespace BankSystem
{
    partial class Transfer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnChooseFrom = new System.Windows.Forms.Button();
            this.BtnChooseTo = new System.Windows.Forms.Button();
            this.TxAmount = new System.Windows.Forms.TextBox();
            this.TxFrom = new System.Windows.Forms.TextBox();
            this.TxTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // BtnChooseFrom
            // 
            this.BtnChooseFrom.Location = new System.Drawing.Point(203, 145);
            this.BtnChooseFrom.Name = "BtnChooseFrom";
            this.BtnChooseFrom.Size = new System.Drawing.Size(99, 23);
            this.BtnChooseFrom.TabIndex = 3;
            this.BtnChooseFrom.Text = "Choose";
            this.BtnChooseFrom.UseVisualStyleBackColor = true;
            this.BtnChooseFrom.Click += new System.EventHandler(this.BtnChooseFrom_Click);
            // 
            // BtnChooseTo
            // 
            this.BtnChooseTo.Location = new System.Drawing.Point(203, 243);
            this.BtnChooseTo.Name = "BtnChooseTo";
            this.BtnChooseTo.Size = new System.Drawing.Size(99, 23);
            this.BtnChooseTo.TabIndex = 4;
            this.BtnChooseTo.Text = "Choose";
            this.BtnChooseTo.UseVisualStyleBackColor = true;
            this.BtnChooseTo.Click += new System.EventHandler(this.BtnChooseTo_Click);
            // 
            // TxAmount
            // 
            this.TxAmount.Location = new System.Drawing.Point(404, 347);
            this.TxAmount.Name = "TxAmount";
            this.TxAmount.Size = new System.Drawing.Size(142, 22);
            this.TxAmount.TabIndex = 5;
            // 
            // TxFrom
            // 
            this.TxFrom.Location = new System.Drawing.Point(404, 146);
            this.TxFrom.Name = "TxFrom";
            this.TxFrom.Size = new System.Drawing.Size(142, 22);
            this.TxFrom.TabIndex = 6;
            // 
            // TxTo
            // 
            this.TxTo.Location = new System.Drawing.Point(404, 244);
            this.TxTo.Name = "TxTo";
            this.TxTo.Size = new System.Drawing.Size(142, 22);
            this.TxTo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 135);
            this.label4.TabIndex = 8;
            this.label4.Text = "|";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 135);
            this.label5.TabIndex = 9;
            this.label5.Text = "|";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 135);
            this.label6.TabIndex = 10;
            this.label6.Text = "|";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(267, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 69);
            this.label7.TabIndex = 11;
            this.label7.Text = "Transfer";
            // 
            // BtnTransfer
            // 
            this.BtnTransfer.Location = new System.Drawing.Point(301, 393);
            this.BtnTransfer.Name = "BtnTransfer";
            this.BtnTransfer.Size = new System.Drawing.Size(120, 39);
            this.BtnTransfer.TabIndex = 12;
            this.BtnTransfer.Text = "Transfer Now";
            this.BtnTransfer.UseVisualStyleBackColor = true;
            this.BtnTransfer.Click += new System.EventHandler(this.BtnTransfer_Click);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnTransfer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxTo);
            this.Controls.Add(this.TxFrom);
            this.Controls.Add(this.TxAmount);
            this.Controls.Add(this.BtnChooseTo);
            this.Controls.Add(this.BtnChooseFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Transfer";
            this.Text = "Teransfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnChooseFrom;
        private System.Windows.Forms.Button BtnChooseTo;
        private System.Windows.Forms.TextBox TxAmount;
        private System.Windows.Forms.TextBox TxFrom;
        private System.Windows.Forms.TextBox TxTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnTransfer;
    }
}