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
    public partial class ctrlEmployee : UserControl
    {
        public ctrlEmployee()
        {
            InitializeComponent();
        }
        public int EmployeeId
        {
            get { return int.Parse(TxEmployeeId.Text); }
            set { TxEmployeeId.Text = value.ToString(); }
        }
        public string FirstName
        {
            get { return TxFirstName.Text; }
            set { TxFirstName.Text = value; }
        }
        public string MidName
        {
            get { return TxMidName.Text; }
            set { TxMidName.Text = value; }
        }
        public string LastName
        {
            get { return TxLastName.Text; }
            set { TxLastName.Text = value; }
        }
        public string NationalID
        {
            get { return TxNationalId.Text; }
            set { TxNationalId.Text = value; }
        }
        public string Department
        {
            get { return CbDeparments.Text; }
            set { CbDeparments.Text = value; }
        }
        public void SetDepatmentsIntoCompoBox(DataTable DepartmentsTable)
        {
            foreach(DataRow Row in DepartmentsTable.Rows)
            {
                CbDeparments.Items.Add(Row["DepartmentName"]);
            }
        }
        public void ChangeFormAddress(string NewAddress)
        {
            LbFormAddress.Text = NewAddress;
        }
        public void changeLkImage(string NewText)
        {
            LkImage.Text = NewText;
        }
        public void HideAccountId()
        {
            TxEmployeeId.Enabled = false;
        }
        public void ShowAccountId()
        {
            TxEmployeeId.Enabled = true;
        }
        public bool IsTxEmployeeIdNullOrEmpty()
        {
            return (TxEmployeeId.Text != null && TxEmployeeId.Text == "");
        }
        public void DeisableAllInfoExceptEmployeeID()
        {
            TxFirstName.Enabled = false;
            TxLastName.Enabled = false;
            TxMidName.Enabled = false;
            TxNationalId.Enabled = false;
            LkImage.Enabled = false;
        }
        public void EnableAllInfoExceptEmployeeID()
        {
            TxFirstName.Enabled = true;
            TxLastName.Enabled = true;
            TxMidName.Enabled = true;
            TxNationalId.Enabled = true;
            LkImage.Enabled = true;
        }
        private void ctrlEmployee_Load(object sender, EventArgs e)
        {
        }
        public bool IsInfoCompleteAndConsistent()
        {
            // تحقق أن جميع الحقول غير فارغة
            if (string.IsNullOrEmpty(TxFirstName.Text) ||
                string.IsNullOrEmpty(TxMidName.Text) ||
                string.IsNullOrEmpty(TxLastName.Text) ||
                string.IsNullOrEmpty(TxNationalId.Text))
            {
                return false;
            }

            // تحقق أن TxEmployeeId.Text يمكن تحويله إلى عدد صحيح
           

            return true;
        }
        public string ImagePath="";
        private void LkImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image File";
                if(openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    EmployeeImage.Image = Image.FromFile(openFileDialog.FileName);
                    CurrentEmployee.ImagePath = openFileDialog.FileName;
                }
            }
        }
        public class ClsEmployees
        {
            public string FirstName, LastName, MidName, NationalId, ImagePath = "", DepartmentName;
            public int AccountId;
        }
        public ClsEmployees CurrentEmployee=new ClsEmployees();
     public void GetInfoFromUi()
        {
            CurrentEmployee.FirstName = TxFirstName.Text;
            CurrentEmployee.MidName = TxMidName.Text;
            CurrentEmployee.NationalId = TxNationalId.Text;
            CurrentEmployee.DepartmentName = CbDeparments.Text;
            CurrentEmployee.LastName =(TxLastName.Text);
        }
        public void SetinfoIntoUI()
        {
            TxEmployeeId.Text = EmployeeId.ToString();
            TxNationalId.Text = CurrentEmployee.NationalId;
            TxFirstName.Text = CurrentEmployee.FirstName;
            TxLastName.Text = CurrentEmployee.LastName;
            TxMidName.Text = CurrentEmployee.MidName;
            CbDeparments.SelectedIndex = CbDeparments.FindString(CurrentEmployee.DepartmentName);
            EmployeeImage.ImageLocation = CurrentEmployee.ImagePath;
        }



    }
}
