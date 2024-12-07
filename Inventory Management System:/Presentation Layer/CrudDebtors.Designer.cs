namespace BankSystem
{
    partial class CrudDebtors
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.ctrDebtors1 = new BankSystem.ctrDebtors();
            this.BtnFindDebtor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFinish
            // 
            this.BtnFinish.Location = new System.Drawing.Point(387, 353);
            this.BtnFinish.Name = "BtnFinish";
            this.BtnFinish.Size = new System.Drawing.Size(95, 38);
            this.BtnFinish.TabIndex = 1;
            this.BtnFinish.Text = "Finish";
            this.BtnFinish.UseVisualStyleBackColor = true;
            this.BtnFinish.Click += new System.EventHandler(this.BtnFinish_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(209, 353);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(95, 38);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // ctrDebtors1
            // 
            this.ctrDebtors1.Collateral = "";
            this.ctrDebtors1.FullName = "";
            this.ctrDebtors1.Location = new System.Drawing.Point(0, 2);
            this.ctrDebtors1.Name = "ctrDebtors1";
            this.ctrDebtors1.Size = new System.Drawing.Size(747, 344);
            this.ctrDebtors1.TabIndex = 0;
            this.ctrDebtors1.Load += new System.EventHandler(this.ctrDebtors1_Load);
            // 
            // BtnFindDebtor
            // 
            this.BtnFindDebtor.Location = new System.Drawing.Point(387, 352);
            this.BtnFindDebtor.Name = "BtnFindDebtor";
            this.BtnFindDebtor.Size = new System.Drawing.Size(95, 38);
            this.BtnFindDebtor.TabIndex = 3;
            this.BtnFindDebtor.Text = " Find";
            this.BtnFindDebtor.UseVisualStyleBackColor = true;
            this.BtnFindDebtor.Click += new System.EventHandler(this.BtnFindDebtor_Click);
            // 
            // CrudDebtors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 403);
            this.Controls.Add(this.BtnFindDebtor);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnFinish);
            this.Controls.Add(this.ctrDebtors1);
            this.Name = "CrudDebtors";
            this.Text = "CrudDebtors";
            this.Load += new System.EventHandler(this.CrudDebtors_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrDebtors ctrDebtors1;
        private System.Windows.Forms.Button BtnFinish;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnFindDebtor;
    }
}