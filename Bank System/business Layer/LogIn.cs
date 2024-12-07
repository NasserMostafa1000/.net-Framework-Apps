using BankSystemDataAccessLayer;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class LogIn :Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
     
        private void LogIn_Load(object sender, EventArgs e)
        {
            
        
                TxEmail.Text = ReadFromRegistry("Email");
                TxPassword.Text = ReadFromRegistry("Password");
            
       
        }
        private void WriteToRegistry( string valueName, string EmailOrPassword, string keyPath = "Software\\BankSystem")
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(keyPath);
            if (key != null)
            {
                key.SetValue(valueName, EmailOrPassword);
                key.Close();
            }
        }
        static string ReadFromRegistry( string EmailOrPassword,string keyPath = "Software\\BankSystem")
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath);
            if (key != null)
            {
                object value = key.GetValue(EmailOrPassword);
                key.Close();
                return value?.ToString();
            }
            return null;
        }
        private void ProcessRememberMeCheckbox()
        {
           
            WriteToRegistry("Email", TxEmail.Text);
            WriteToRegistry("Password", TxPassword.Text);

        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string Password = TxPassword.Text;
            string Email = TxEmail.Text;
            if(ClsUser.IsThisUserExists(TxEmail.Text, TxPassword.Text))
            {
                Main Menue = new Main();
                Menue.Show();
                if (checkBox1.Checked)
                {
                    ProcessRememberMeCheckbox();
                }
            }
            else
            {
                MessageBox.Show("wrong details Please Try Again", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
