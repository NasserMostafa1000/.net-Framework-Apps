namespace BankSystem
{
    partial  class DateAndTime
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
            this.LbHours = new System.Windows.Forms.Label();
            this.LbMunite = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbDay = new System.Windows.Forms.Label();
            this.LbMonth = new System.Windows.Forms.Label();
            this.LbYear = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LbnightOrMorning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbHours
            // 
            this.LbHours.AutoSize = true;
            this.LbHours.Location = new System.Drawing.Point(163, 18);
            this.LbHours.Name = "LbHours";
            this.LbHours.Size = new System.Drawing.Size(21, 16);
            this.LbHours.TabIndex = 0;
            this.LbHours.Text = "00";
            // 
            // LbMunite
            // 
            this.LbMunite.AutoSize = true;
            this.LbMunite.Location = new System.Drawing.Point(208, 18);
            this.LbMunite.Name = "LbMunite";
            this.LbMunite.Size = new System.Drawing.Size(21, 16);
            this.LbMunite.TabIndex = 1;
            this.LbMunite.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = " Time :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = " Date :";
            // 
            // LbDay
            // 
            this.LbDay.AutoSize = true;
            this.LbDay.Location = new System.Drawing.Point(146, 50);
            this.LbDay.Name = "LbDay";
            this.LbDay.Size = new System.Drawing.Size(21, 16);
            this.LbDay.TabIndex = 5;
            this.LbDay.Text = "00";
            // 
            // LbMonth
            // 
            this.LbMonth.AutoSize = true;
            this.LbMonth.Location = new System.Drawing.Point(190, 50);
            this.LbMonth.Name = "LbMonth";
            this.LbMonth.Size = new System.Drawing.Size(21, 16);
            this.LbMonth.TabIndex = 6;
            this.LbMonth.Text = "00";
            // 
            // LbYear
            // 
            this.LbYear.AutoSize = true;
            this.LbYear.Location = new System.Drawing.Point(235, 50);
            this.LbYear.Name = "LbYear";
            this.LbYear.Size = new System.Drawing.Size(21, 16);
            this.LbYear.TabIndex = 7;
            this.LbYear.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "/";
            // 
            // LbnightOrMorning
            // 
            this.LbnightOrMorning.AutoSize = true;
            this.LbnightOrMorning.Location = new System.Drawing.Point(251, 18);
            this.LbnightOrMorning.Name = "LbnightOrMorning";
            this.LbnightOrMorning.Size = new System.Drawing.Size(14, 16);
            this.LbnightOrMorning.TabIndex = 10;
            this.LbnightOrMorning.Text = "?";
            // 
            // DateAndTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 66);
            this.Controls.Add(this.LbnightOrMorning);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LbYear);
            this.Controls.Add(this.LbMonth);
            this.Controls.Add(this.LbDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbMunite);
            this.Controls.Add(this.LbHours);
            this.Name = "DateAndTime";
            this.Text = "DateAndTime";
            this.Load += new System.EventHandler(this.DateAndTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbHours;
        private System.Windows.Forms.Label LbMunite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbDay;
        private System.Windows.Forms.Label LbMonth;
        private System.Windows.Forms.Label LbYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LbnightOrMorning;
    }
}