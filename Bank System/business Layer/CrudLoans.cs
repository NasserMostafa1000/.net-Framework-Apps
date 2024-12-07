using BankSystemDataAccessLayer;
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
    public partial class CrudLoans : Form
    {
        public CrudLoans(int Mode)
        {
           
            InitializeComponent();
            if (Mode == 1)
            {
                CurrentMode = CrudLoans.Mode.AddNewMode;
                UpdateFormToPerformAddNew();
            }
            else if(Mode==2)
            {
                CurrentMode = CrudLoans.Mode.Find;

                UpdateFormToPerformFind();
            }
            else if(Mode==3)
            {
                CurrentMode = CrudLoans.Mode.Update;
                UpdateFormToPerformUpdate();
            }
            else
                    {
                CurrentMode = CrudLoans.Mode.Delete;
                UpdateFormToPerformDelete();
            }
        }
        public delegate void ShareLoanIdAfterFounded(int LoanId,float LoanPrice);
        public event ShareLoanIdAfterFounded OnGetLoanId;
        enum Mode
        {
            AddNewMode=1,Find=2,Update=3,Delete=4
        }
        Mode CurrentMode;
        private void UpdateFormToPerformUpdate()
        {
            ctrLoans1.ShowLoanId();
            ctrLoans1.DisableAllINfoExceptLoanId();
            BtnFinish.Text = "Update";
            ctrLoans1.UpdateFormAddress("Update");
        }
        private void UpdateFormToPerformDelete()
        {
            ctrLoans1.ShowLoanId();
            ctrLoans1.DisableAllINfoExceptLoanId();
            BtnFinish.Text = "Delete";
            ctrLoans1.UpdateFormAddress("Delete");
        }
        private void UpdateFormToPerformAddNew()
        {
            ctrLoans1.HideTxLoanId();
            BtnCheck.Visible = false;
            BtnFinish.Text = "Add";
            ctrLoans1.UpdateFormAddress("Add New Loan");
        }
        private void UpdateFormToPerformFind()
        {
            ctrLoans1.ShowLoanId();
            BtnFinish.Text = "Find";
            ctrLoans1.DisableAllINfoExceptLoanId();
            BtnCheck.Visible = false;
            ctrLoans1.UpdateFormAddress("Find Loan");
        }
        private void AddNewLoan()
        {
            if(ctrLoans1.IsInfoCompeleteAndConsistancy())
            {
                ctrLoans1.GetinfoFromUi();
                if (Loans.AddNewLoan(ctrLoans1.LoanPrice, ctrLoans1.BenifetPercentage, ctrLoans1.LoanPeriod))
                {
                    MessageBox.Show("Adding Done Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Ensure that all details about Loan Are Compelete and try again later",
                    "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Find()
        {
            if(!ctrLoans1.IsTxIdNullOrEmpty())
            {
                if (Loans.Find(ctrLoans1.LoanId, ref ctrLoans1.CurrentLoan.LoanPrice, ref ctrLoans1.CurrentLoan.LoanPercentage
                   , ref ctrLoans1.CurrentLoan.LoanPeriod))
                {
                    ctrLoans1.SetinofoIntoUi();
                }
                else
                {
                    MessageBox.Show("Not Found", "none", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Ensure that  Loan ID is Compelete and try again later",
                "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateLoan()
        {
            ctrLoans1.GetinfoFromUi();
            if(Loans.UpdateLoanById(ctrLoans1.LoanId,ctrLoans1.CurrentLoan.LoanPrice,ctrLoans1.CurrentLoan.LoanPercentage,
                ctrLoans1.CurrentLoan.LoanPeriod))
            {
                MessageBox.Show("Updated done Successfully", "Done!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
  
        }
        public void DeleteLoan()
        {
            if(Loans.DeleteLoan(ctrLoans1.LoanId))
            {
                MessageBox.Show("delettion done Successfully", "Done!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void BtnFinish_Click(object sender, EventArgs e)
        {
            switch(CurrentMode )
            {
                case Mode.AddNewMode:
                    {
                        AddNewLoan();
                    }
                    break;
                case Mode.Find:
                    {
                        Find();
                        OnGetLoanId.Invoke(ctrLoans1.LoanId,ctrLoans1.LoanPrice);
                    }
                    break;
                case Mode.Update:
                    {
                        UpdateLoan();
                    }
                    break;
                case Mode.Delete:
                    {
                        DeleteLoan();
                    }
                    break;
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //this button only has two mission which use for find the client that will be update Or Delete
            if(!ctrLoans1.IsTxIdNullOrEmpty())
            {
                if (Loans.Find(ctrLoans1.LoanId, ref ctrLoans1.CurrentLoan.LoanPrice, ref ctrLoans1.CurrentLoan.LoanPercentage
                , ref ctrLoans1.CurrentLoan.LoanPeriod))
                {
                    ctrLoans1.SetinofoIntoUi();
                    //hide this button to show update button
                    BtnCheck.Visible = false;
                    if(CurrentMode==CrudLoans.Mode.Update)
                    {
                        //if mode is update shoukd show all textboxes and numreic boxex to allow to update it
                        ctrLoans1.EnableAllINfoExceptLoanId();

                    }
                    else if(CurrentMode == CrudLoans.Mode.Delete)
                    {
                        //if mode is delete should hide all text boxes to simplify userinterface for user
                        ctrLoans1.DisableAllINfoExceptLoanId();
                        MessageBox.Show("You are So Close From Delete This Loan if you are sure press delete", "waening", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Not Founded ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("No Id Founded To Find", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrudLoans_Load(object sender, EventArgs e)
        {

        }
    }
}
