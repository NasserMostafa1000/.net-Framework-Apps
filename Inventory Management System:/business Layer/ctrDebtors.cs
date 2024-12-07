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
    public partial class ctrDebtors : UserControl
    {
        public ctrDebtors()
        {
            InitializeComponent();
        }
        public void ChangeFormAddress(string Formaddress)
        {
            LbFormAddress.Text = Formaddress;
        }
        public int ID
        {
            get { return int.Parse(TxId.Text); }
            set { TxId.Text = value.ToString(); }
        }
        public string FullName
        {
            get { return TxFullName.Text; }
            set { TxFullName.Text = value.ToString(); }
        }
        public string Collateral
        {
            get { return TxCollateral.Text; }
            set { TxCollateral.Text = value.ToString(); }
        }
        public float LoanPrice
        {
            get { return float.Parse( TxLoanPrice.Text.ToString()); }
            set { TxLoanPrice.Text = value.ToString(); }
        }
        public float DuesAmount
        {
            get { return float.Parse(TxDuesAMount.Text.ToString()); }
            set { TxDuesAMount.Text = value.ToString(); }
        }
        public class DebtorDetails
        {
            public int ClientId,LoanId;
         
        }
    public  DebtorDetails OperationDetails = new DebtorDetails();
        private void BtnChooseClint_Click(object sender, EventArgs e)
        {
            CrudClient FindClien = new CrudClient(3);
            FindClien.PersonFounded += GetClientDetails;
            FindClien.ShowDialog();


        }
        public void DisableTxId()
        {
            TxId.Enabled = false;
        }
        public void EnableTxId()
        {
            TxId.Enabled = true;
        }
        private void GetClientDetails(int Id,string FirstName,string MidName,string LastName,float Balance)
        {
            OperationDetails.ClientId = Id;
            TxFullName.Text = FirstName + ' ' + MidName + ' ' + LastName;
        }
        public void DisableAllExceptColletral()
        {
            TxFullName.Enabled = false;
            TxLoanPrice.Enabled = false;
        }
        public void DisableAllControlsExceptDebtorId()
        {
            TxFullName.Enabled = false;
            TxLoanPrice.Enabled = false;
            TxCollateral.Enabled = false;
            BtnChooseClint.Enabled = false;
            BtnChooseLoan.Enabled = false;
        }
        public bool IsTxDuesNotNullAndConsistant()
        {
            return float.TryParse(TxDuesAMount.Text, out float Amount);
        }
        private void BtnChooseLoan_Click(object sender, EventArgs e)
        {
            CrudLoans FindLoan = new CrudLoans(2);
            FindLoan.OnGetLoanId += GetLoanId;
            FindLoan.ShowDialog();
        }
        private void GetLoanId(int LoanId,float LoanPrice )
        {
            OperationDetails.LoanId = LoanId;
            TxLoanPrice.Text = LoanPrice.ToString();
        }
        public bool IsTxIdNotNull()
        {
            return int.TryParse(TxId.Text, out int id);
        }
        public bool IsInfoCompleteAndConsistant()
        {
            // تحقق من أن جميع الحقول المطلوبة ليست فارغة
            if (!string.IsNullOrEmpty(TxFullName.Text) &&
                !string.IsNullOrEmpty(TxCollateral.Text) &&
                !string.IsNullOrEmpty(TxLoanPrice.Text))
            {
                return true; // جميع الحقول غير فارغة
            }

            return false; // أ
        }
        public void HideDuesDetails()
        {
            TxDuesAMount.Visible = false;
            LbAmount.Visible = false;
        }
        public void ShowDuesDetails()
        {
            TxDuesAMount.Visible = true;
            LbAmount.Visible = true;
        }

        private void ctrDebtors_Load(object sender, EventArgs e)
        {

        }
    }
}
