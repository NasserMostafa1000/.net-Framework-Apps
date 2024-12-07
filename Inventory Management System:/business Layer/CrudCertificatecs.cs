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
    public partial class CrudCertificatecs : Form
    {
        public CrudCertificatecs(byte Mode )
        {
            InitializeComponent();
            if(Mode==1)
            {
                CurrentMode = CrudCertificatecs.Mode.AddNewMode;
                UpdateFormToPerformAdd();
            }
            else if(Mode==2)
            {
                CurrentMode = CrudCertificatecs.Mode.FindMode;
                UpdateFormToPerdormFind();
            }
            else if(Mode==3)
            {
                CurrentMode = CrudCertificatecs.Mode.UpdateMode;
                UpdateFormToPerformUpdate();
                
            }
            else
            {
                CurrentMode = CrudCertificatecs.Mode.DeleteMode;
                UpdateFormToPerformDelete();
            }
        }
        public  delegate void ReturnPriceAfterFindingCertificate(float CertificatePrice,int id);
        public event ReturnPriceAfterFindingCertificate OnFindCertificate;
        private enum Mode 
        {
            AddNewMode=1,FindMode=2,UpdateMode=3,DeleteMode=4

        }
        Mode CurrentMode;
        private void UpdateFormToPerformDelete()
        {
            ctrlCertificate1.LbCOntrolAddress = "Delete Certificate";
            BtnFinish.Text = "delete ";
            ctrlCertificate1.DisableAllTextBoxesExceptAccountId();
            BtnCheck.Visible = true;


        }
        private void UpdateFormToPerdormFind()
        {
            ctrlCertificate1.LbCOntrolAddress = "Find Certificate";

            BtnFinish.Text = "Find ";
            BtnCheck.Visible = false;
            ctrlCertificate1.DisableAllTextBoxesExceptAccountId();
        }
        private void UpdateFormToPerformUpdate()
        {
            ctrlCertificate1.LbCOntrolAddress = " Update Certificate";
            BtnFinish.Text = "Update ";
            ctrlCertificate1.DisableAllTextBoxesExceptAccountId();
        }
        private void UpdateFormToPerformAdd()
        {
            ctrlCertificate1.LbCOntrolAddress = "Add New Certificate";
            BtnCheck.Visible = false;
            BtnFinish.Text = "Finish";
            //should hide account Id Cause Its Auto Increament coulmn
            ctrlCertificate1.HideAccountIdToPerformAddNew();
        }
        private bool FindCertificate()
        {
            return Certificates.FindCertificate(ctrlCertificate1.CertificateId, ref ctrlCertificate1.CurrentCertificate.CertificatePeriodPerYears, ref ctrlCertificate1.CurrentCertificate.CertificatePrice, ref ctrlCertificate1.CurrentCertificate.totalProfit, ref ctrlCertificate1.CurrentCertificate.MonthlyProfitPercentage);

        }
        private void FindCertificateAndSetInfoIntoUi()
        {
         
                if (ctrlCertificate1.ISTxIdNotNullAndConsistancy())
                {
                    if ( FindCertificate())
                    {
                        ctrlCertificate1.SetCertificateInfoIntoUI();
                    BtnCheck.Visible = false;
                    }
                else
                {
                    MessageBox.Show("Not found", "information", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
                }
                else
                {
                    MessageBox.Show(" Enter Certificate Id that you need to search", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
            
        }
        private void AddNewCertificateIfInfoCompeleteAndConsistancyAtUI()
        {
            if (ctrlCertificate1.IsInfoCompeleteAndConsistancy())
            {
                if (Certificates.AddNewCertificate(ctrlCertificate1.CertificatePerioud, ctrlCertificate1.CertificatePrice
                    , ctrlCertificate1.TotalProfit, ctrlCertificate1.ProfitPercentagePerMonth))
                {
                    MessageBox.Show("Certificate Added Successfully!", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(" Wrong input!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateCertificateAtCurrentOgject()
        {
            ctrlCertificate1.EnableAllTextBoxes();
        }
        private void updateCertificate()
        {
            if (Certificates.UpdateCertificate(ctrlCertificate1.CurrentCertificate.CertificateId,
              ctrlCertificate1.CurrentCertificate.CertificatePeriodPerYears, ctrlCertificate1.CurrentCertificate.CertificatePrice,
              ctrlCertificate1.CurrentCertificate.totalProfit, ctrlCertificate1.CurrentCertificate.MonthlyProfitPercentage))
            {
                MessageBox.Show("Updated Done Successfully", "Operation Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private void GetNewInfoAndUpdateIt()
        {
            ctrlCertificate1.GetInfoFromUi();
            updateCertificate();


        }
        private void BtnFinish_Click(object sender, EventArgs e)
        {
            switch(CurrentMode)
            {
                case Mode.AddNewMode:
                    {
                        AddNewCertificateIfInfoCompeleteAndConsistancyAtUI();
                        this.Close();
                    }
                    break;
                case Mode.FindMode:
                    {
                        FindCertificateAndSetInfoIntoUi();
                        OnFindCertificate.Invoke(ctrlCertificate1.CurrentCertificate.CertificatePrice,
                            ctrlCertificate1.CertificateId);
                    }
                    break;
                case Mode.UpdateMode:
                    {
                        //first step Get The Certificate Details at Cureent ogject inside ctrCertificate And set it into ui And BtnCheck Will deo that
                        //second Step Will get info from control and Update
                        GetNewInfoAndUpdateIt();
                        this.Close();


                    }
                    break;
                case Mode.DeleteMode:
                    {

                        if (Certificates.DeleteCertificate(ctrlCertificate1.CertificateId))
                        {
                            MessageBox.Show("deletion Done Successfully!", "Operation Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                      
                    }break;
            }
        }
        // this button used for update and delete to get information after delete
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            FindCertificateAndSetInfoIntoUi();
            // we need to be disable at delete mode only but  update should be enable
            if (CurrentMode != CrudCertificatecs.Mode.DeleteMode)

            {
                ctrlCertificate1.EnableAllTextBoxes();


            }
            if (CurrentMode == CrudCertificatecs.Mode.DeleteMode)
            {
                MessageBox.Show("you are so close from delete this certificate press delete to remove", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void CrudCertificatecs_Load(object sender, EventArgs e)
        {

        }
    }
}
