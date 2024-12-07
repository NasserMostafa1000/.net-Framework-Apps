using BankSystemDataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class CrudDebtors : Form
    {
        public CrudDebtors(byte mode )
        {
            InitializeComponent();
            if(mode==1)
            {
                CurrentMode = Mode.AddNew;
                UpdateFormToPerformAddNew();
            }
            else if(mode==2)
            {
                CurrentMode = Mode.PayDues;
                UpdateFormToPerformPayDues();

            }
            else
            {
                CurrentMode = Mode.CloseLoan;
                UpdateFormToPerformClosingLoan();

                    }

        }
        enum Mode
        {
            AddNew=1,PayDues=2,CloseLoan
        }
        private void UpdateFormToPerformAddNew()
        {
            ctrDebtors1.ChangeFormAddress("Add New Debtor");
            ctrDebtors1.DisableTxId();
            BtnFindDebtor.Visible = false;
            ctrDebtors1.HideDuesDetails();
            ctrDebtors1.DisableAllExceptColletral();
        }
        private void UpdateFormToPerformPayDues()
        {
            ctrDebtors1.ChangeFormAddress("Pay Dues");
            ctrDebtors1.EnableTxId();
            ctrDebtors1.ShowDuesDetails();
            ctrDebtors1.DisableAllControlsExceptDebtorId();
        }
        private void UpdateFormToPerformClosingLoan()
        {
            ctrDebtors1.ChangeFormAddress("Close Loan");
            ctrDebtors1.EnableTxId();
            ctrDebtors1.HideDuesDetails();
            ctrDebtors1.DisableAllControlsExceptDebtorId();
        }
        Mode CurrentMode;
        private void AddNewDebtor()
        {
            if(ctrDebtors1.IsInfoCompleteAndConsistant())
            {
                DateTime Borrowingdate = DateTime.Today;
                DateTime DueDate = Borrowingdate.AddYears(1);
              if(ClsDebtors.AddNewDebtor(ctrDebtors1.OperationDetails.ClientId, ctrDebtors1.OperationDetails.LoanId,ctrDebtors1.Collateral ,Borrowingdate, DueDate))
                {
                    ClsSettings.CallMessageBoxForSuccessAdding();
                    this.Close();
                }
              
            }
            else
            {
                ClsSettings.CallMessageBoxForMissingOrWrongInformation();
                
            }
        }
        private void ctrDebtors1_Load(object sender, EventArgs e)
        {

        }
        private void UpdateDues()
        {
            if(ctrDebtors1.IsTxDuesNotNullAndConsistant())
            {
                if(ClsDebtors.UpdatePayedAmount(ctrDebtors1.ID, ctrDebtors1.DuesAmount))
                {
                    ClsSettings.CallMessageBoxForSuccessUpdates();
                }
            }
            else
            {
                ClsSettings.CallMessageBoxForMissingOrWrongInformation();
            }
        }
        private void FindDebtorAndSetitINtoUi()
        {

            if (ctrDebtors1.IsTxIdNotNull())
            {
                //find debtor details 
                DataTable TheDebtor = ClsDebtors.FindDebtorInfoById(ctrDebtors1.ID);
                DataRow DebtorRow = TheDebtor.Rows[0];
                ctrDebtors1.Collateral = DebtorRow["Collateral"].ToString();
                //find loan details with the Loanid that returns from Debtor and put it into UI
                float LoanPrice = 0;
                Loans.FindLoanPriceById(int.Parse(DebtorRow["LoanId"].ToString()), ref LoanPrice);
                ctrDebtors1.LoanPrice = LoanPrice;
                // find FullName with The Clientd Id That Return From Debtor And Put it into UI
                string FirstName = "", MidName = "", LastName = "";
                ClsClients.FindFullNameById(int.Parse(DebtorRow["ClientID"].ToString()), ref FirstName, ref MidName, ref LastName);
                ctrDebtors1.FullName = FirstName + ' ' + MidName + ' ' + LastName;
            }
            else
            {
                ClsSettings.CallMessageBoxForMissingOrWrongInformation();
            }
        }
        private void CloseLoan()
        {
            if(ctrDebtors1.IsTxIdNotNull())
            {
                if(ClsDebtors.CloseLoan(ctrDebtors1.ID))
                {
                    ClsSettings.CallMessageBoxForSuccessUpdates();
                    this.Close();
                }
            }
            else
            {
                ClsSettings.CallMessageBoxForMissingOrWrongInformation();
            }
        }
        private void BtnFinish_Click(object sender, EventArgs e)
        {
            switch(CurrentMode)
            {
                case Mode.AddNew:
                    {
                        AddNewDebtor();
                    }
                    break;
                case Mode.PayDues:
                    {
                        UpdateDues();
                    }
                    break;
                case Mode.CloseLoan:
                    {
                        CloseLoan();
                    }
                    break;
            }
        }

        private void CrudDebtors_Load(object sender, EventArgs e)
        {

        }

        private void BtnFindDebtor_Click(object sender, EventArgs e)
        {
            FindDebtorAndSetitINtoUi();
            BtnFindDebtor.Visible = false;
        }
    }
}
