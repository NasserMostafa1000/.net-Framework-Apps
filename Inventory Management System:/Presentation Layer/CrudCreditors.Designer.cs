namespace BankSystem
{
    partial class CrudCreditors
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.ctrlCreditors1 = new BankSystem.ctrlCreditors();
            this.btnfind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFinish
            // 
            this.BtnFinish.Location = new System.Drawing.Point(398, 331);
            this.BtnFinish.Name = "BtnFinish";
            this.BtnFinish.Size = new System.Drawing.Size(94, 38);
            this.BtnFinish.TabIndex = 1;
            this.BtnFinish.Text = "Finish";
            this.BtnFinish.UseVisualStyleBackColor = true;
            this.BtnFinish.Click += new System.EventHandler(this.BtnFinish_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(242, 331);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(94, 38);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // ctrlCreditors1
            // 
            this.ctrlCreditors1.Location = new System.Drawing.Point(3, 12);
            this.ctrlCreditors1.Name = "ctrlCreditors1";
            this.ctrlCreditors1.Size = new System.Drawing.Size(790, 293);
            this.ctrlCreditors1.TabIndex = 0;
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(398, 331);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(94, 38);
            this.btnfind.TabIndex = 3;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.button1_Click);
            // 
            // CrudCreditors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 389);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnFinish);
            this.Controls.Add(this.ctrlCreditors1);
            this.Name = "CrudCreditors";
            this.Text = "CrudCreditors";
            this.Load += new System.EventHandler(this.CrudCreditors_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlCreditors ctrlCreditors1;
        private System.Windows.Forms.Button BtnFinish;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button btnfind;
    }
}