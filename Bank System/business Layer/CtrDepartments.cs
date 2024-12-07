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
    public partial class CtrDepartments : UserControl
    {
        public CtrDepartments()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public string DepartmentName
        {
            get { return TxName.Text; }
            set { TxName.Text = value.ToString(); }
        }
        public float Salary
        {
            get { return int.Parse(TxSalary.Text); }
            set { TxSalary.Text = value.ToString(); }
        }
        public int DepartmentId
        {
            get { return int.Parse(TxID.Text); }
            set { TxID.Text = value.ToString(); }
        }
        public bool IsDepartmentDetailsCompleteAndConsistent()
        {
            if (string.IsNullOrEmpty(TxName.Text))
            {
                return false;
            }
            if (!float.TryParse(TxSalary.Text, out float Salary))
            {
                return false;
            }
            return true;
        }
        public void ChangeFormAddress(string NewAddress)
        {
            LbFormAddress.Text = NewAddress;
        }
        public void DesableAlldetailsExceptAccountID()
        {
            TxName.Enabled = false;
            TxSalary.Enabled = false;
        }
        public void EnableAlldetailsExceptAccountID()
        {
            TxName.Enabled = true;
            TxSalary.Enabled = true;
        }
        public void EnableTXDepartmentID()
        {
            TxID.Enabled = true;
        }
        public void DisableTxDepartmentID()
        {
            TxID.Enabled = false;
        }
        public class Department
        {
            public string Name;
            public int ID; public float Salary;
        }
      public  Department CurrentDepartment = new Department();
        public void GetTheDetailsFromUI()
        {
            CurrentDepartment.Salary = float.Parse(TxSalary.Text);
            CurrentDepartment.Name = TxName.Text;
        }
        public bool IsIdNullOrContainString()
        {
            if (!string.IsNullOrEmpty(TxID.Text))
            {
                return float.TryParse(TxID.Text, out float ID);
            }
            return false;
        }
        public void SetTheDetailsToUI()
        {
            TxSalary.Text = CurrentDepartment.Salary.ToString();
            TxName.Text = CurrentDepartment.Name;
        }
        private void CtrDepartments_Load(object sender, EventArgs e)
        {

        }
    }
}
