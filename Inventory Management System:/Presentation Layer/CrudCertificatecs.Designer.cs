namespace BankSystem
{
    partial class CrudCertificatecs
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnFinish = new System.Windows.Forms.Button();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.ctrlCertificate1 = new BankSystem.CtrlCertificate();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(198, 358);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(98, 34);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnFinish
            // 
            this.BtnFinish.Location = new System.Drawing.Point(423, 358);
            this.BtnFinish.Name = "BtnFinish";
            this.BtnFinish.Size = new System.Drawing.Size(98, 34);
            this.BtnFinish.TabIndex = 2;
            this.BtnFinish.Text = " Finish";
            this.BtnFinish.UseVisualStyleBackColor = true;
            this.BtnFinish.Click += new System.EventHandler(this.BtnFinish_Click);
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(423, 358);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(98, 34);
            this.BtnCheck.TabIndex = 3;
            this.BtnCheck.Text = "Check";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // ctrlCertificate1
            // 
            this.ctrlCertificate1.CertificatePerioud = ((byte)(0));
            this.ctrlCertificate1.Location = new System.Drawing.Point(-4, 12);
            this.ctrlCertificate1.Name = "ctrlCertificate1";
            this.ctrlCertificate1.ProfitPercentagePerMonth = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ctrlCertificate1.Size = new System.Drawing.Size(810, 321);
            this.ctrlCertificate1.TabIndex = 0;
            // 
            // CrudCertificatecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.BtnFinish);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.ctrlCertificate1);
            this.Name = "CrudCertificatecs";
            this.Text = "CrudCertificatecs";
            this.Load += new System.EventHandler(this.CrudCertificatecs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlCertificate ctrlCertificate1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnFinish;
        private System.Windows.Forms.Button BtnCheck;
    }
}