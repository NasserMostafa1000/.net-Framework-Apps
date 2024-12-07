namespace BankSystem
{
    partial class CrudClient
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.client1 = new BankSystem.CtrlClient();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(530, 469);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(141, 39);
            this.BtnAdd.TabIndex = 112;
            this.BtnAdd.Text = "Finish";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(285, 469);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(141, 39);
            this.BtnClose.TabIndex = 113;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnCheck
            // 
            this.BtnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheck.Location = new System.Drawing.Point(530, 469);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(141, 39);
            this.BtnCheck.TabIndex = 115;
            this.BtnCheck.Text = "Check";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // client1
            // 
            this.client1.ImagePath = null;
            this.client1.Location = new System.Drawing.Point(-5, -7);
            this.client1.Name = "client1";
            this.client1.Size = new System.Drawing.Size(908, 470);
            this.client1.TabIndex = 114;
            this.client1.TXAddress = " ";
            this.client1.TXFirstName = " ";
            this.client1.TXLastName = " ";
            this.client1.TXMidName = " ";
            this.client1.TXNationalID = " ";
            this.client1.Load += new System.EventHandler(this.client1_Load);
            // 
            // CrudClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 529);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.client1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAdd);
            this.Name = "CrudClient";
            this.Text = "AddNewClient";
            this.Load += new System.EventHandler(this.AddNewClient_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnClose;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private CtrlClient client1;
        private System.Windows.Forms.Button BtnCheck;
    }
}