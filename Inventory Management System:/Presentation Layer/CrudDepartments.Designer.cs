namespace BankSystem
{
    partial class CrudDepartments
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
            this.BtnCheck = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrDepartments1 = new BankSystem.CtrDepartments();
            this.SuspendLayout();
            // 
            // BtnFinish
            // 
            this.BtnFinish.Location = new System.Drawing.Point(310, 287);
            this.BtnFinish.Name = "BtnFinish";
            this.BtnFinish.Size = new System.Drawing.Size(91, 38);
            this.BtnFinish.TabIndex = 1;
            this.BtnFinish.Text = "Finish";
            this.BtnFinish.UseVisualStyleBackColor = true;
            this.BtnFinish.Click += new System.EventHandler(this.BtnFinish_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(154, 287);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(91, 38);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(310, 287);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(91, 38);
            this.BtnCheck.TabIndex = 3;
            this.BtnCheck.Text = "Check";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrDepartments1
            // 
            this.ctrDepartments1.DepartmentName = "";
            this.ctrDepartments1.Location = new System.Drawing.Point(-8, 12);
            this.ctrDepartments1.Name = "ctrDepartments1";
            this.ctrDepartments1.Size = new System.Drawing.Size(684, 247);
            this.ctrDepartments1.TabIndex = 0;
            this.ctrDepartments1.Load += new System.EventHandler(this.ctrDepartments1_Load);
            // 
            // CrudDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 337);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnFinish);
            this.Controls.Add(this.ctrDepartments1);
            this.Name = "CrudDepartments";
            this.Text = "CrudDepartments";
            this.Load += new System.EventHandler(this.CrudDepartments_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CtrDepartments ctrDepartments1;
        private System.Windows.Forms.Button BtnFinish;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button button1;
    }
}