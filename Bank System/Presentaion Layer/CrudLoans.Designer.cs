namespace BankSystem
{
    partial class CrudLoans
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
            this.BtnFinish = new System.Windows.Forms.Button();
            this.BtnCalcel = new System.Windows.Forms.Button();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.ctrLoans1 = new BankSystem.CtrLoans();
            this.SuspendLayout();
            // 
            // BtnFinish
            // 
            this.BtnFinish.Location = new System.Drawing.Point(294, 322);
            this.BtnFinish.Name = "BtnFinish";
            this.BtnFinish.Size = new System.Drawing.Size(75, 32);
            this.BtnFinish.TabIndex = 1;
            this.BtnFinish.Text = "Finish";
            this.BtnFinish.UseVisualStyleBackColor = true;
            this.BtnFinish.Click += new System.EventHandler(this.BtnFinish_Click);
            // 
            // BtnCalcel
            // 
            this.BtnCalcel.Location = new System.Drawing.Point(135, 321);
            this.BtnCalcel.Name = "BtnCalcel";
            this.BtnCalcel.Size = new System.Drawing.Size(75, 33);
            this.BtnCalcel.TabIndex = 2;
            this.BtnCalcel.Text = "Cancel";
            this.BtnCalcel.UseVisualStyleBackColor = true;
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(294, 321);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(75, 33);
            this.BtnCheck.TabIndex = 3;
            this.BtnCheck.Text = "Check";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // ctrLoans1
            // 
            this.ctrLoans1.BenifetPercentage = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ctrLoans1.LoanPeriod = ((byte)(0));
            this.ctrLoans1.Location = new System.Drawing.Point(-9, -3);
            this.ctrLoans1.Name = "ctrLoans1";
            this.ctrLoans1.Size = new System.Drawing.Size(746, 289);
            this.ctrLoans1.TabIndex = 0;
            // 
            // CrudLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 398);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.BtnCalcel);
            this.Controls.Add(this.BtnFinish);
            this.Controls.Add(this.ctrLoans1);
            this.Name = "CrudLoans";
            this.Text = "CrudLoans";
            this.Load += new System.EventHandler(this.CrudLoans_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CtrLoans ctrLoans1;
        private System.Windows.Forms.Button BtnFinish;
        private System.Windows.Forms.Button BtnCalcel;
        private System.Windows.Forms.Button BtnCheck;
    }
}