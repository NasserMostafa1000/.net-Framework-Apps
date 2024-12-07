using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UhlSportDataAccessLayer;

using System.Windows.Forms;
using FaisalSport.Properties;
using static UhlSportDataAccessLayer.GlobalCurrentUser;
using System.Drawing.Text;

namespace FaisalSport
{
    public partial class SignIn : Form
    {
        public GlobalCurrentUser CurrentUser = new GlobalCurrentUser();

        public SignIn()
        {
            InitializeComponent();
        }
        private void GetLogInInfoFromTextBoxesIntoClsCurrentUser()
        {
            CurrentUser.UserName = TxEmail.Text;
            CurrentUser.Password = TxPassword.Text;
        }
        private void Btn_LogIn_Click(object sender, EventArgs e)
        {
            GetLogInInfoFromTextBoxesIntoClsCurrentUser();
           if( ClsUser.IsThisAccountExistsAndreturnInfoIfExists(ref  CurrentUser.UserId, ref CurrentUser.FirstName, ref CurrentUser.LastName,ref CurrentUser.UserName ,ref CurrentUser.Password, ref CurrentUser.PermissionNumber))
            {
                // this will call data access layel ti add the time for the log-in time
                ClsLoginDate.AddNew(DateTime.Now, CurrentUser.UserId);
                Form FrmMain = new FrmMain( ref CurrentUser, this);
                FrmMain.ShowDialog();
                
            }
         
            else
            {
                LbResultOfLogIn.Text = "خطأ في كلمه المرور او البريد الالكتروني";
       
            }
        }
        static int GenerateRandomNumber(Random random, int min, int max)
        {
            // إضافة 1 إلى max لأن الدالة Next تستثني القيمة العليا من النطاق
            return random.Next(min, max + 1);
        }
        public int GenrateRandomBetween()
        {
            Random Rand = new Random();
          return  GenerateRandomNumber(Rand, 1, 5);
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            pictureBox1.Show();
            if (GenrateRandomBetween()==1)
            {
                this.BackgroundImage = Resources.Mostafa;
                pictureBox1.Hide();
            }
         else   if (GenrateRandomBetween() == 2)
            {
                this.BackgroundImage = Resources.Mustafa;
            }
            else if (GenrateRandomBetween() == 3)
            {
                this.BackgroundImage = Resources.saad;
            }
            else if (GenrateRandomBetween() == 4)
            {
                this.BackgroundImage = Resources.managerandmubark;
            }
            else 
            {
                this.BackgroundImage = Resources.kuwity;

            }
           
        }

        private void TxEmail_MouseEnter(object sender, EventArgs e)
        {
            if(TxEmail.Text=="البريد الالكتروني")
            {
                TxEmail.Text = "";
            }
                   
        }
    }
}
