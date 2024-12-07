namespace FaisalSport
{
    partial class SignIn
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
            this.components = new System.ComponentModel.Container();
            this.TxEmail = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TxPassword = new System.Windows.Forms.TextBox();
            this.Btn_LogIn = new System.Windows.Forms.Button();
            this.LoginResult = new System.Windows.Forms.Label();
            this.LbResultOfLogIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxEmail
            // 
            this.TxEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxEmail.Location = new System.Drawing.Point(403, 302);
            this.TxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxEmail.Name = "TxEmail";
            this.TxEmail.Size = new System.Drawing.Size(315, 33);
            this.TxEmail.TabIndex = 0;
            this.TxEmail.Text = "البريد الالكتروني";
            this.TxEmail.MouseEnter += new System.EventHandler(this.TxEmail_MouseEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TxPassword
            // 
            this.TxPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxPassword.Location = new System.Drawing.Point(403, 370);
            this.TxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxPassword.Name = "TxPassword";
            this.TxPassword.PasswordChar = '*';
            this.TxPassword.Size = new System.Drawing.Size(315, 30);
            this.TxPassword.TabIndex = 2;
            this.TxPassword.Text = "كلمه السر";
            // 
            // Btn_LogIn
            // 
            this.Btn_LogIn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_LogIn.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LogIn.Location = new System.Drawing.Point(461, 464);
            this.Btn_LogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_LogIn.Name = "Btn_LogIn";
            this.Btn_LogIn.Size = new System.Drawing.Size(183, 47);
            this.Btn_LogIn.TabIndex = 4;
            this.Btn_LogIn.Text = "تسجيل دخول";
            this.Btn_LogIn.UseVisualStyleBackColor = false;
            this.Btn_LogIn.Click += new System.EventHandler(this.Btn_LogIn_Click);
            // 
            // LoginResult
            // 
            this.LoginResult.AutoSize = true;
            this.LoginResult.Location = new System.Drawing.Point(472, 175);
            this.LoginResult.Name = "LoginResult";
            this.LoginResult.Size = new System.Drawing.Size(0, 16);
            this.LoginResult.TabIndex = 5;
            // 
            // LbResultOfLogIn
            // 
            this.LbResultOfLogIn.AutoSize = true;
            this.LbResultOfLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbResultOfLogIn.ForeColor = System.Drawing.Color.Red;
            this.LbResultOfLogIn.Location = new System.Drawing.Point(527, 414);
            this.LbResultOfLogIn.Name = "LbResultOfLogIn";
            this.LbResultOfLogIn.Size = new System.Drawing.Size(0, 22);
            this.LbResultOfLogIn.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImage = global::FaisalSport.Properties.Resources.Person;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(461, 126);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 133);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FaisalSport.Properties.Resources.managerandmubark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1185, 633);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbResultOfLogIn);
            this.Controls.Add(this.LoginResult);
            this.Controls.Add(this.Btn_LogIn);
            this.Controls.Add(this.TxPassword);
            this.Controls.Add(this.TxEmail);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxEmail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TxPassword;
        private System.Windows.Forms.Button Btn_LogIn;
        private System.Windows.Forms.Label LoginResult;
        private System.Windows.Forms.Label LbResultOfLogIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

