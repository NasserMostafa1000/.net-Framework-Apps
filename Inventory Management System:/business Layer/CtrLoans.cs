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
    public partial class CtrLoans : UserControl
    {
        public CtrLoans()
        {
            InitializeComponent();
        }
        public float LoanPrice
        {
            get { return float.Parse(TxLoanPrice.Text); }
            set { TxLoanPrice.Text = value.ToString(); }
        }
        public decimal BenifetPercentage
        {
            get { return UdBenifetPercentage.Value; }
            set { UdBenifetPercentage.Value = value; }
        }
        
            public byte LoanPeriod
        {
            get { return byte.Parse(UdPaymentPeriod.Value.ToString()); }
            set { UdPaymentPeriod.Value = value; }
        }
        public int LoanId
        {
            get { return int.Parse(TxLoanId.Text); }
            set { TxLoanId.Text = value.ToString();  }
        }
        public void HideTxLoanId()
        {
            TxLoanId.Enabled = false;
        }
        public void ShowLoanId()
        {
            TxLoanId.Enabled = true;
        }
        public void DisableAllINfoExceptLoanId()
        {
            TxLoanPrice.Enabled=false;
            UdBenifetPercentage.Enabled = false;
            UdPaymentPeriod.Enabled = false;
        }
        public void EnableAllINfoExceptLoanId()
        {
            TxLoanPrice.Enabled = true;
            UdBenifetPercentage.Enabled = true;
            UdPaymentPeriod.Enabled = true;
        }
        public bool IsTxIdNullOrEmpty()
        {
            return (TxLoanId == null && string.IsNullOrEmpty(TxLoanId.Text));
        }
        public void UpdateFormAddress(string FormAddress)
        {
            LbFormAddress.Text = FormAddress; 
        }
        public bool IsInfoCompeleteAndConsistancy()
        {
            if (string.IsNullOrEmpty(TxLoanPrice.Text)||
                UdBenifetPercentage.Value == 0 ||
                UdPaymentPeriod.Value == 0)
            {
                return false;
            }

            else
            {
                bool isLoanPriceValid = float.TryParse(TxLoanPrice.Text, out float LoanPrice);

                bool isBenifetValid = decimal.TryParse(UdBenifetPercentage.Value.ToString(), out decimal Benifet);

                bool isPeriodValid = byte.TryParse(UdPaymentPeriod.Value.ToString(), out byte Period);

                return isLoanPriceValid && isBenifetValid && isPeriodValid;
            }
        }

        public class LoanDetails
        {
            public int LoanId;
            public float LoanPrice;
            public byte LoanPeriod;
            public decimal LoanPercentage;
        }
        public LoanDetails CurrentLoan=new LoanDetails();
        public void GetinfoFromUi()
        {
if (int.TryParse(TxLoanId.Text, out int loanId))
    {
        CurrentLoan.LoanId = loanId;
    }
    else
    {
        CurrentLoan.LoanId = 0;
    }            CurrentLoan.LoanPrice = float.Parse(TxLoanPrice.Text.ToString());
            CurrentLoan.LoanPercentage =decimal.Parse(UdBenifetPercentage.Value.ToString());
            CurrentLoan.LoanPeriod = byte.Parse(UdPaymentPeriod.Value.ToString());
        }
        public void SetinofoIntoUi()
        {
            TxLoanId.Text = LoanId.ToString();
            TxLoanPrice.Text = CurrentLoan.LoanPrice.ToString();
            UdBenifetPercentage.Value =CurrentLoan.LoanPercentage;
            UdPaymentPeriod.Value = CurrentLoan.LoanPeriod;
        }
        private void CtrLoans_Load(object sender, EventArgs e)
        {

        }
    }
}
