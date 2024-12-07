namespace BankSystem
{
    partial class CtrDepartments
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxID = new System.Windows.Forms.TextBox();
            this.TxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbFormAddress
            // 
            this.LbFormAddress.AutoSize = true;
            this.LbFormAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFormAddress.Location = new System.Drawing.Point(223, 0);
            this.LbFormAddress.Name = "LbFormAddress";
            this.LbFormAddress.Size = new System.Drawing.Size(115, 39);
            this.LbFormAddress.TabIndex = 1;
            this.LbFormAddress.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = " Department ID";
            // 
            // TxID
            // 
            this.TxID.Location = new System.Drawing.Point(301, 62);
            this.TxID.Name = "TxID";
            this.TxID.Size = new System.Drawing.Size(157, 22);
            this.TxID.TabIndex = 3;
            // 
            // TxName
            // 
            this.TxName.Location = new System.Drawing.Point(208, 130);
            this.TxName.Name = "TxName";
            this.TxName.Size = new System.Drawing.Size(157, 22);
            this.TxName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Department Name";
            // 
            // TxSalary
            // 
            this.TxSalary.Location = new System.Drawing.Point(208, 194);
            this.TxSalary.Name = "TxSalary";
            this.TxSalary.Size = new System.Drawing.Size(157, 22);
            this.TxSalary.TabIndex = 7;
            this.TxSalary.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salary";
            // 
            // CtrDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbFormAddress);
            this.Name = "CtrDepartments";
            this.Size = new System.Drawing.Size(684, 247);
            this.Load += new System.EventHandler(this.CtrDepartments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbFormAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxID;
        private System.Windows.Forms.TextBox TxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxSalary;
        private System.Windows.Forms.Label label3;
    }
}
