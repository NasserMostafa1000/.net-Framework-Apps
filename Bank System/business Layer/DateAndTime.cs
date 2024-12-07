using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace BankSystem
{
    public partial class DateAndTime : Form
    {
        public DateAndTime()
        {
            InitializeComponent();
        }

        private void DateAndTime_Load(object sender, EventArgs e)
        {

        }
        private  void RefreshDate()
        {
            DateTime Today = DateTime.Today;
            LbYear.Text = Today.Year.ToString();
            LbMonth.Text = Today.Month.ToString();
            LbDay.Text = Today.Day.ToString();
            
        }
        private  void RefreshTime()
        {
            DateTime Time = DateTime.Now;
            LbHours.Text = Time.ToString("hh");
            LbMunite.Text = Time.ToString("mm");
            LbnightOrMorning.Text = Time.ToString("tt");
        }
        protected  void RefreshDateAndTime(object Sender,EventArgs e)
        {
            RefreshDate();
            RefreshTime();
        }
    }
}
