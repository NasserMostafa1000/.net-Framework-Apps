using BankSystemDataAccessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class CrudCreditors : Form
    {
        public CrudCreditors(byte Mode)
        {
            InitializeComponent();
            if(Mode==1)
            {
                CurrentMode = mode.Addnew;
                UpdateFormToPerformAdd();
            }
            else if(Mode==3)
            {
                CurrentMode = mode.Drop;
                UpdateFormToPerformDrop();
            }
        }
        private void UpdateFormToPerformAdd()
        {
            ctrlCreditors1.ChangeFormAddress("Add New Creditor");
            ctrlCreditors1.disableTxID();
            btnfind.Visible = false;

            BtnFinish.Text = "Add";
        }
        private void UpdateFormToPerformDrop()
        {
            ctrlCreditors1.ChangeFormAddress("Drop Creditor");
            btnfind.Visible = true;
            ctrlCreditors1.disableAllInfo();
            BtnFinish.Text = "Drop";
        }
        enum mode
        {
            Addnew,Drop
        }
        mode CurrentMode;
        private void CrudCreditors_Load(object sender, EventArgs e)
        {

        }

        private bool AddNewCreditor()
        {
            if(ctrlCreditors1.IsInfoCompeleteAndConsistant())
            {
                if (ClsCreditor.AddNewCreditor(ctrlCreditors1.OperationDetails.ClientId, ctrlCreditors1.OperationDetails.CertificateId))
                {
                    return true;
                }
            }
            else
            {
                ClsSettings.CallMessageBoxForMissingOrWrongInformation();
                return false;
            }
            return false;
        }
        private bool dropCertificate()
        {
            return ClsCreditor.DropCertificate(ctrlCreditors1.CreditorId);
        }
        private void BtnFinish_Click(object sender, EventArgs e)
        {
            switch(CurrentMode)
            {
                case mode.Addnew:
                    {
                        if(AddNewCreditor())
                        {
                            ClsSettings.CallMessageBoxForSuccessAdding();
                            this.Close();
                        }
                    }break;
                case mode.Drop:
                    {
                        if(dropCertificate())
                        {
                            ClsSettings.CallMessageBoxForSuccessDeletion();
                            this.Close();
                        }
               
                    }break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ctrlCreditors1.IsTxIdNotNullAndConsistant())
            {
                if(ClsCreditor.IsThisCreditorIsAlreadtExists(ctrlCreditors1.CreditorId))
                {
                    DataTable Certifiacte = ClsCreditor.FindCreditorById(ctrlCreditors1.CreditorId);
                    btnfind.Visible = false;
                    DataRow row = Certifiacte.Rows[0];
                    ctrlCreditors1.FullName = row["FullName"].ToString();
                    ctrlCreditors1.CertificatePrice = float.Parse(row["CertificatePrice"].ToString());
                    MessageBox.Show("if you are sure for drop this cerificate press Drop", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ClsSettings.CallMessageBoxForMissingOrWrongInformation();
                }
            }
        }
    }
}
