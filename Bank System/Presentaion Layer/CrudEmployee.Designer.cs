namespace BankSystem
{
    partial class CrudEmployee
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
            this.btnFinish = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.ctrlEmployee1 = new BankSystem.ctrlEmployee();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(445, 410);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(79, 31);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(306, 409);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(73, 32);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // ctrlEmployee1
            // 
            this.ctrlEmployee1.Department = "";
            this.ctrlEmployee1.FirstName = " ";
            this.ctrlEmployee1.LastName = "";
            this.ctrlEmployee1.Location = new System.Drawing.Point(3, 12);
            this.ctrlEmployee1.MidName = "";
            this.ctrlEmployee1.Name = "ctrlEmployee1";
            this.ctrlEmployee1.NationalID = "";
            this.ctrlEmployee1.Size = new System.Drawing.Size(833, 396);
            this.ctrlEmployee1.TabIndex = 0;
            this.ctrlEmployee1.Load += new System.EventHandler(this.ctrlEmployee1_Load);
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(445, 410);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(79, 31);
            this.BtnCheck.TabIndex = 3;
            this.BtnCheck.Text = "Check";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // CrudEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.ctrlEmployee1);
            this.Name = "CrudEmployee";
            this.Text = "CrudEmployee";
            this.Load += new System.EventHandler(this.CrudEmployee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlEmployee ctrlEmployee1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button BtnCheck;
    }
}