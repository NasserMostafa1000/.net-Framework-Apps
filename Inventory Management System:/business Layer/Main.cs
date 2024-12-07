using BankSystemDataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class Main :  DateAndTime
    {
        public Main()
        {
            InitializeComponent();
            TimerForTime();
        }
         public   DataTable RefreshAllClient()
        {
           
            return ClsClients.GetAllClient(Convert.ToUInt16(BtnClientsNext.Tag));
        }
        private void TimerForTime()
        {
           
            timer1.Interval = 60000; // تعيين الفاصل الزمني إلى  دقيقه
            timer1.Tick += RefreshDateAndTime; // ربط الحدث
            timer1.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ClsSettings.connectionString = ConfigurationManager.ConnectionStrings["BankSystemConnection"].ConnectionString;
            RefreshDateAndTime(this,e);
            HideAllInfoThatBelongsToLoan();
            HideAllInfoThatBelongsToCreditors();
            HideAllInfoThatBelongsToCertifiactes();
            HideAllinfoThatbelongsToRecivers();
            HideAllInfoThatBelongsToSenders();
            HideAllIngoThatBelongsToUsers();
            HideAllINfoThatBelongsToDebtor();
            SHowAllIcons();
            HideAllDetailsThatBelongsToDepartments();
            HideAllInfoThatBelongsToEmployees();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = RefreshAllClient();
           
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            BtnClientsNext.Tag = Convert.ToInt32(BtnClientsNext.Tag) + 1;
           dataGridView1.DataSource= RefreshAllClient();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            BtnClientsNext.Tag = Convert.ToInt32(BtnClientsNext.Tag) - 1;
            dataGridView1.DataSource = RefreshAllClient();
        }


  

     

    


     
        private DataTable RefreshCertificates()
        {

            return Certificates.GatAllCertificates(Convert.ToInt32(BtnCertificatesNext.Tag));
        }
        private void HideAllInfoThatBelongsToCertifiactes()
        {
            BtnAddCertificate.Visible = false;
            BtnCertificatesNext.Visible = false;
            BtnCertificatesPrev.Visible = false;
            BtnFindCertifiacte.Visible = false;
            BtnUpdateCertificate.Visible = false;
            BtnDeleteCertificate.Visible = false;
        }
        private void HideAllInfoThatBelongsToClients()
        {
            //clients buttons
            btnUpdateClient.Visible = false;
            BtnAddNewClient.Visible = false;
            BtnFindClient.Visible = false;
            BtnTransfer.Visible = false;
            BtnDeleteClient.Visible = false;
            //this 2 buttons  Developed to Move on clients only
            BtnClientsNext.Visible = false;
            BtnClientsPrevious.Visible = false;
            //icons buttons
            Icon1.Visible = false;
      
        }
        private void ShowAllInfoThatBelongsToClients()
        {
            //clients buttons
            btnUpdateClient.Visible = true;
            BtnAddNewClient.Visible = true;
            BtnFindClient.Visible = true;
            BtnTransfer.Visible = true;
            BtnDeleteClient.Visible = true;
            //this 2 buttons  Developed to Move on clients only
            BtnClientsNext.Visible = true;
            BtnClientsPrevious.Visible = true;
            //icons buttons
            Icon1.Visible = true;

        }
        private void ShowAllInfoThatBelongsToCertifiacte()
        {
            BtnAddCertificate.Visible = true;
            BtnCertificatesNext.Visible = true;
            BtnCertificatesPrev.Visible = true;
            BtnFindCertifiacte.Visible = true;
            BtnUpdateCertificate.Visible = true;
            BtnDeleteCertificate.Visible = true;
        }
   
        private void BtnCertificatesNext_Click(object sender, EventArgs e)
        {
            BtnCertificatesNext.Tag = Convert.ToInt32(BtnCertificatesNext.Tag)+1;
            dataGridView1.DataSource= RefreshCertificates();
            
        }
        private void BtnCertificatesPrev_Click(object sender, EventArgs e)
        {
            BtnCertificatesNext.Tag = Convert.ToInt32(BtnCertificatesNext.Tag) - 1;
            dataGridView1.DataSource = RefreshCertificates();


        }

        private void ShowAllInfoThatBelongsToLoan()
        {
            BtnAddNewLoan.Visible = true;
            BtnUpdateLoan.Visible = true;
            BtnDeleteLoan.Visible = true;
            BtnFIndLoan.Visible = true;
            BtnNextLoans.Visible = true;
            BtnPrevLoans.Visible = true;
        }
        private void HideAllInfoThatBelongsToLoan()
        {
            BtnAddNewLoan.Visible = false;
            BtnUpdateLoan.Visible = false;
            BtnDeleteLoan.Visible = false;
            BtnFIndLoan.Visible = false;
            BtnNextLoans.Visible = false;
            BtnPrevLoans.Visible = false;
        }
        private DataTable RefreshAllLoans()
        {
            return Loans.GetAllLoans(int.Parse(BtnNextLoans.Tag.ToString()));
        }

        private void BtnNextLoans_Click(object sender, EventArgs e)
        {
            BtnNextLoans.Tag = int.Parse(BtnNextLoans.Tag.ToString()) + 1;
            dataGridView1.DataSource = RefreshAllLoans();
        }
        private void BtnPrevLoans_Click(object sender, EventArgs e)
        {
            BtnNextLoans.Tag = int.Parse(BtnNextLoans.Tag.ToString()) - 1;
            dataGridView1.DataSource = RefreshAllLoans();
        }

  
       
        private void BtnDeleteLoan_Click(object sender, EventArgs e)
        {
            CrudLoans delete = new CrudLoans(4);
            delete.ShowDialog();
        }
        private void ShowAllInfoThatBelongsToEmployee()
        {
            LkDepartments.Visible = true; ;
            BtnNextEmployee.Visible = true;
            BtnPrevEmployee.Visible = true;
            BtnAddnewEmployee.Visible = true;
            BtnUpdateEmployee.Visible = true;
            BtnFindEmployee.Visible = true;
            BtnDeleteEMployee.Visible = true;
        }
        private void HideAllInfoThatBelongsToEmployees()
        {
            LkDepartments.Visible = false;
            BtnNextEmployee.Visible = false;
            BtnPrevEmployee.Visible = false;
            BtnAddnewEmployee.Visible = false;
            BtnUpdateEmployee.Visible = false;
            BtnFindEmployee.Visible = false;
            BtnDeleteEMployee.Visible = false;
        }
        private DataTable RefreshAllEmployees()
        {
            return ClsEmployees.GetAllEmployees(int.Parse(BtnNextEmployee.Tag.ToString()));
        }
        private void BtnNextEmployee_Click(object sender, EventArgs e)
        {
            BtnNextEmployee.Tag = int.Parse(BtnNextEmployee.Tag.ToString()) + 1;
            dataGridView1.DataSource = RefreshAllEmployees();
        }
        private void BtnPrevEmployee_Click(object sender, EventArgs e)
        {
            BtnNextEmployee.Tag = int.Parse(BtnNextEmployee.Tag.ToString()) - 1;
            dataGridView1.DataSource = RefreshAllEmployees();


        }
       
      
     
    
        private void ShowAllDetailsThatBelongsToDepartments()
        {
            BtnAddDepartment.Visible = true;
            btnUpdateDepartment.Visible = true;
            BtnFIndDepartment.Visible = true;
            BtnDeleteDepartment.Visible = true;
        }
        private void HideAllDetailsThatBelongsToDepartments()
        {
            BtnAddDepartment.Visible = false;
            btnUpdateDepartment.Visible = false;
            BtnFIndDepartment.Visible = false;
            BtnDeleteDepartment.Visible = false;
        }
        private DataTable RefreshDepartment()
        {
            return Departments.GetAllDepartments();
        }

        private void BtnClients_Click_1(object sender, EventArgs e)
        {
            HideAllInfoThatBelongsToCertifiactes();
            HideAllDetailsThatBelongsToDepartments();
            HideAllInfoThatBelongsToLoan();
            HideAllInfoThatBelongsToSenders();
            HideAllInfoThatBelongsToEmployees();
            SHowAllIcons();
            HideAllIngoThatBelongsToUsers();
            HideAllinfoThatbelongsToRecivers();
            HideAllINfoThatBelongsToDebtor();
            HideAllInfoThatBelongsToCreditors();
            dataGridView1.DataSource = RefreshAllClient();
            ShowAllInfoThatBelongsToClients();
        }

        private void BtnLoans_Click_1(object sender, EventArgs e)
        {
            LbFormAddress.Text = "Loans List";
            HideAllInfoThatBelongsToCertifiactes();
            HideAllInfoThatBelongsToClients();
            HideAllDetailsThatBelongsToDepartments();
            HideAllinfoThatbelongsToRecivers();
            HideAllIngoThatBelongsToUsers();
            SHowAllIcons();
            HideAllInfoThatBelongsToSenders();
            HideAllINfoThatBelongsToDebtor();
            ShowAllInfoThatBelongsToLoan();
            HideAllInfoThatBelongsToCreditors();
            HideAllInfoThatBelongsToEmployees();
            dataGridView1.DataSource = RefreshAllLoans();
        }

        private void BtnCertificates_Click_1(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LbFormAddress.Text = "Certificates List";
            HideAllInfoThatBelongsToClients();
            HideAllIngoThatBelongsToUsers();
            HideAllDetailsThatBelongsToDepartments();
            HideAllInfoThatBelongsToLoan();
            HideAllINfoThatBelongsToDebtor();
            SHowAllIcons();
            HideAllInfoThatBelongsToCreditors();
            ShowAllInfoThatBelongsToCertifiacte();
            HideAllInfoThatBelongsToEmployees();
            dataGridView1.DataSource = RefreshCertificates();
        }

        private void BtnEmployees_Click_1(object sender, EventArgs e)
        {
            LbFormAddress.Text = "Employees List";
            HideAllInfoThatBelongsToCertifiactes();
            HideAllInfoThatBelongsToSenders();
            HideAllInfoThatBelongsToClients();
            HideAllIngoThatBelongsToUsers();
            HideAllINfoThatBelongsToDebtor();
            HideAllinfoThatbelongsToRecivers();
            HideAllDetailsThatBelongsToDepartments();
            HideAllInfoThatBelongsToLoan();
            SHowAllIcons();
            ShowAllInfoThatBelongsToEmployee();
            HideAllInfoThatBelongsToCreditors();
            dataGridView1.DataSource = RefreshAllEmployees();
        }
        private void ShowAllInfoThatBelongsToCreditors()
        {
            BtnOpernCertificate.Visible = true;
            BtnDropCertificate.Visible = true;
            BtnFindCreditor.Visible = true;
            BtnPayProfit.Visible=true;
            TxFindCreditor.Visible = true;
            BtnPrevCreditor.Visible = true;
            BtnNextCreditor.Visible = true;
        }
        private void HideAllInfoThatBelongsToCreditors()
        {
            BtnOpernCertificate.Visible = false;
            BtnDropCertificate.Visible = false;
            BtnFindCreditor.Visible = false;
            BtnPayProfit.Visible = false;
            TxFindCreditor.Visible = false;
            BtnPrevCreditor.Visible = false;
            BtnNextCreditor.Visible = false;
        }
        private DataTable RefreshAllCreditors()
        {
            return ClsCreditor.GatAllCerditors(int.Parse(BtnNextCreditor.Tag.ToString()));
        }
        private void BtnDebtors_Click_1(object sender, EventArgs e)
        {
            LbFormAddress.Text = "Creditors List";
            HideAllInfoThatBelongsToCertifiactes();
            HideAllInfoThatBelongsToSenders();
            HideAllInfoThatBelongsToClients();
            HideAllDetailsThatBelongsToDepartments();
            HideAllinfoThatbelongsToRecivers();
            HideAllInfoThatBelongsToLoan();
            HideAllInfoThatBelongsToEmployees();
            ShowAllInfoThatBelongsToCreditors();
            HideAllIngoThatBelongsToUsers();
            HideAllINfoThatBelongsToDebtor();
            SHowAllIcons();
            ShowAllInfoThatBelongsToCreditors();

            dataGridView1.DataSource = RefreshAllCreditors();

        }

        private void BtnNextCreditor_Click(object sender, EventArgs e)
        {
            BtnNextCreditor.Tag = int.Parse(BtnNextCreditor.Tag.ToString()) + 1;
            dataGridView1.DataSource = RefreshAllCreditors();
        }
        private void BtnPrevCreditor_Click(object sender, EventArgs e)
        {
            BtnNextCreditor.Tag = int.Parse(BtnNextCreditor.Tag.ToString()) - 1;
            dataGridView1.DataSource = RefreshAllCreditors();
        }

 
        private void BtnFind_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxFindCreditor.Text, out int ID) && ClsCreditor.IsThisCreditorIsAlreadtExists(int.Parse(TxFindCreditor.Text)))
            {
                dataGridView1.DataSource = ClsCreditor.FindCreditorById(int.Parse(TxFindCreditor.Text));

            }

            else
            {
                MessageBox.Show("Wrong Information Or Creditor Not Found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxFind_MouseHover(object sender, EventArgs e)
        {
            TxFindCreditor.Text = "";
        }
        private void SHowAllInfoThatBelongsToDebtors()
        {
            BtnIssueLoan.Visible = true;
            BtnCloseLoan.Visible = true;
            TxFIndDebtor.Visible = true;
            BtnFindDebtor.Visible = true;
            BtnPayDebtorsDues.Visible = true;
            BtnNextDebtor.Visible = true;
            BTnPrevDebtor.Visible = true;
        }
        private void HideAllINfoThatBelongsToDebtor()
        {
            BtnIssueLoan.Visible = false;
            BtnCloseLoan.Visible = false;
            TxFIndDebtor.Visible = false;
            BtnFindDebtor.Visible = false;
            BtnPayDebtorsDues.Visible = false;
            BtnNextDebtor.Visible = false;
            BTnPrevDebtor.Visible = false;
        }

        private DataTable RefreshAllDeptors()
        {
            return ClsDebtors.GetAllDebtors(int.Parse(BtnNextDebtor.Tag.ToString()));
        }
        private void BtnTheDebtor_Click(object sender, EventArgs e)
        {
            LbFormAddress.Text = "Debtors List";

            HideAllInfoThatBelongsToCertifiactes();
            HideAllInfoThatBelongsToClients();
            dataGridView1.DataSource = RefreshAllDeptors();
            HideAllDetailsThatBelongsToDepartments();
            HideAllInfoThatBelongsToLoan();
            HideAllInfoThatBelongsToSenders();
            HideAllInfoThatBelongsToEmployees();
            HideAllinfoThatbelongsToRecivers();
            SHowAllIcons();
            SHowAllInfoThatBelongsToDebtors();
            HideAllIngoThatBelongsToUsers();
            HideAllInfoThatBelongsToCreditors();
        }


        private void TxFIndLoan_MouseHover(object sender, EventArgs e)
        {
            TxFIndDebtor.Text = "";
        }

      
      
        private DataTable RefreshAllUsers()
        {
            return ClsUsers.GetAllUsers(int.Parse(BtnNextUsers.Tag.ToString()));
        }
        private void BtnUsers_Click(object sender, EventArgs e)
        {
            LbFormAddress.Text = "Users List";
            HideAllInfoThatBelongsToCertifiactes();
            HideAllInfoThatBelongsToClients();
            dataGridView1.DataSource = RefreshAllUsers();
            HideAllDetailsThatBelongsToDepartments();
            HideAllInfoThatBelongsToLoan();
            HideAllIngoThatBelongsToUsers();
            HideAllInfoThatBelongsToEmployees();
            HideAllINfoThatBelongsToDebtor();
            HideAllinfoThatbelongsToRecivers();
            HideAllInfoThatBelongsToSenders();
            HideAllIcons();
            HideAllInfoThatBelongsToCreditors();
            ShowAllIngoThatBelongsToUsers();
        }
        private void HideAllIcons()
        {
            Icon1.Visible = false;
            Icon2.Visible = false;
            Icon3.Visible = false;
            Icon4.Visible = false;
            Icon5.Visible = false;
        }
        private void SHowAllIcons()
        {
            Icon2.Visible =true;
            Icon3.Visible =true;
            Icon4.Visible =true;
            Icon5.Visible =true;
        }
        private void BtnNextUsers_Click(object sender, EventArgs e)
        {
            BtnNextUsers.Tag = int.Parse(BtnNextUsers.Tag.ToString()) + 1;
            dataGridView1.DataSource = RefreshAllUsers();
        }

        private void BtnPrevUsers_Click(object sender, EventArgs e)
        {
            BtnNextUsers.Tag = int.Parse(BtnNextUsers.Tag.ToString()) - 1;
            dataGridView1.DataSource = RefreshAllUsers();
        }
        private void RefreshAllSenders()
        {
            dataGridView1.DataSource = ClsSenders.GetAllSenders(Convert.ToInt32((BtnNextSenders.Tag)));
        }
        private void HideAllInfoThatBelongsToSenders()
        {
            BtnNextSenders.Visible=false;
            BtnPrevSender.Visible = false;
        }
        private void ShowAllInfoThatBelongsToSenders()
        {
            BtnNextSenders.Visible = true;
            BtnPrevSender.Visible = true;
        }
        private void BtnSenders_Click(object sender, EventArgs e)
        {
            LbFormAddress.Text = "Senders List";
            HideAllInfoThatBelongsToCertifiactes();
            HideAllInfoThatBelongsToClients();
            ShowAllInfoThatBelongsToSenders();
            dataGridView1.DataSource = RefreshAllUsers();
            HideAllDetailsThatBelongsToDepartments();
            HideAllInfoThatBelongsToLoan();
            HideAllIngoThatBelongsToUsers();
            HideAllInfoThatBelongsToEmployees();
            HideAllINfoThatBelongsToDebtor();
            HideAllinfoThatbelongsToRecivers();
            HideAllIcons();
            HideAllInfoThatBelongsToCreditors();
            RefreshAllSenders();
        }

        private void BtnNextSenders_Click(object sender, EventArgs e)
        {
            BtnNextSenders.Tag = Convert.ToInt32(BtnNextSenders.Tag) + 1;
            RefreshAllSenders();

        }

        private void BtnPrevSender_Click(object sender, EventArgs e)
        {
            BtnNextSenders.Tag = Convert.ToInt32(BtnNextSenders.Tag) - 1;
            RefreshAllSenders();
        }
        private DataTable RefreshAllReciver()
        {
            return ClsRecivers.GetAllRecivers(Convert.ToInt32((BtnNextRecivers.Tag)));
        }
        private void BtnNextRecivers_Click(object sender, EventArgs e)
        {
            BtnNextRecivers.Tag = Convert.ToInt32(BtnNextRecivers.Tag) + 1;
            dataGridView1.DataSource = RefreshAllReciver();
        }

  
        private void ShowAllinfoThatbelongsToRecivers()
        {
            BtnNextRecivers.Visible = true;
            BtnPrevReciver.Visible = true;
        }
        private void HideAllinfoThatbelongsToRecivers()
        {
            BtnNextRecivers.Visible = false;
            BtnPrevReciver.Visible = false;
        }
        private void BtnRecivers_Click(object sender, EventArgs e)
        {
            LbFormAddress.Text = "Recivers List";
            HideAllInfoThatBelongsToCertifiactes();
            HideAllInfoThatBelongsToClients();
            dataGridView1.DataSource = RefreshAllUsers();
            HideAllDetailsThatBelongsToDepartments();
            HideAllInfoThatBelongsToLoan();
            HideAllInfoThatBelongsToEmployees();
            HideAllINfoThatBelongsToDebtor();
            HideAllIcons();
            ShowAllinfoThatbelongsToRecivers();
            HideAllInfoThatBelongsToSenders();
            HideAllInfoThatBelongsToCreditors();
            dataGridView1.DataSource = RefreshAllReciver();
        }
        private void HideAllIngoThatBelongsToUsers()
        {
            BtnNextUsers.Visible = false;
            BtnPrevUsers.Visible = false;
        }
        private void ShowAllIngoThatBelongsToUsers()
        {
            BtnNextUsers.Visible = true;
            BtnPrevUsers.Visible = true;
        }

        private void BtnPrevReciver_Click_1(object sender, EventArgs e)
        {
            BtnNextRecivers.Tag = Convert.ToInt32(BtnNextRecivers.Tag) - 1;
            dataGridView1.DataSource = RefreshAllReciver();
        }

        private void BtnIssueLoan_Click_1(object sender, EventArgs e)
        {
            CrudDebtors AddNew = new CrudDebtors(1);
            AddNew.ShowDialog();
        }

        private void BtnPayDebtorsDues_Click_1(object sender, EventArgs e)
        {
            CrudDebtors PayDues = new CrudDebtors(2);
            PayDues.ShowDialog();
        }

        private void BtnCloseLoan_Click(object sender, EventArgs e)
        {
            CrudDebtors PayDues = new CrudDebtors(3);
            PayDues.ShowDialog();
        }

        private void BtnFindDebtor_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ClsDebtors.FindDebtorById(int.Parse(TxFIndDebtor.Text));

        }

        private void LkDepartments_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HideAllInfoThatBelongsToEmployees();
            ShowAllDetailsThatBelongsToDepartments();
            dataGridView1.DataSource = RefreshDepartment();
        }

        private void BtnTransfer_Click_1(object sender, EventArgs e)
        {
            Transfer TransferMoney = new Transfer();
            TransferMoney.ShowDialog();
        }

        private void BtnOpernCertificate_Click_1(object sender, EventArgs e)
        {
            CrudCreditors AddNew = new CrudCreditors(1);
            AddNew.ShowDialog();
        }

    

        private void BtnFindCreditor_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ClsCreditor.FindCreditorById(int.Parse(TxFindCreditor.Text));

        }

        private void BtnPayProfit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("are You Sure For Pay Profit For All Certificate!?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (ClsCreditor.PayAllProfit())
                {
                    MessageBox.Show(" Operations Done Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("an error occure while looping at database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void BtnDropCertificate_Click_1(object sender, EventArgs e)
        {
            CrudCreditors AddNew = new CrudCreditors(3);
            AddNew.ShowDialog();
        }

        private void BtnAddDepartment_Click_1(object sender, EventArgs e)
        {
            CrudDepartments AddNew = new CrudDepartments(1);
            AddNew.ShowDialog();
        }

        private void BtnFIndDepartment_Click_1(object sender, EventArgs e)
        {
            CrudDepartments AddNew = new CrudDepartments(2);
            AddNew.ShowDialog();
        }

        private void btnUpdateDepartment_Click_1(object sender, EventArgs e)
        {
            CrudDepartments AddNew = new CrudDepartments(3);
            AddNew.ShowDialog();
        }

        private void BtnDeleteDepartment_Click_1(object sender, EventArgs e)
        {
            CrudDepartments AddNew = new CrudDepartments(4);
            AddNew.ShowDialog();
        }

        private void BtnDeleteEMployee_Click_1(object sender, EventArgs e)
        {
            CrudEmployee Delete = new CrudEmployee(4);
            Delete.ShowDialog();
        }

        private void BtnUpdateEmployee_Click_1(object sender, EventArgs e)
        {
            CrudEmployee Update = new CrudEmployee(3);
            Update.ShowDialog();
        }

        private void BtnFindEmployee_Click_1(object sender, EventArgs e)
        {
            CrudEmployee Find = new CrudEmployee(2);
            Find.ShowDialog();
        }

        private void BtnAddnewEmployee_Click_1(object sender, EventArgs e)
        {
            CrudEmployee AddNewEMployee = new CrudEmployee(1);
            AddNewEMployee.ShowDialog();
        }

        private void BtnAddCertificate_Click_1(object sender, EventArgs e)
        {
            CrudCertificatecs AddnewCertificate = new CrudCertificatecs(1);
            AddnewCertificate.ShowDialog();
        }

        private void BtnFindCertifiacte_Click_1(object sender, EventArgs e)
        {
            CrudCertificatecs FindCertificate = new CrudCertificatecs(2);
            FindCertificate.ShowDialog();
        }

        private void BtnUpdateCertificate_Click_1(object sender, EventArgs e)
        {
            CrudCertificatecs UpdateCertificatecs = new CrudCertificatecs(3);
            UpdateCertificatecs.ShowDialog();
        }

        private void BtnDeleteCertificate_Click_1(object sender, EventArgs e)
        {
            CrudCertificatecs DeleteCertificate = new CrudCertificatecs(4);
            DeleteCertificate.ShowDialog();
        }

        private void BtnDeleteClient_Click_1(object sender, EventArgs e)
        {
            CrudClient Frm = new CrudClient(4);
            Frm.ShowDialog();
        }

        private void btnUpdateClient_Click_1(object sender, EventArgs e)
        {
            CrudClient Frm = new CrudClient(2);
            Frm.ShowDialog();
        }

        private void BtnFindClient_Click_1(object sender, EventArgs e)
        {
            CrudClient Frm = new CrudClient(3);
            Frm.ShowDialog();
        }

        private void BtnAddNewClient_Click_1(object sender, EventArgs e)
        {
            //1 is from Add New Mode
            CrudClient FrmAdd = new CrudClient(1);
            FrmAdd.ShowDialog();
        }

        private void BtnAddNewLoan_Click_1(object sender, EventArgs e)
        {
            CrudLoans AddNewLoan = new CrudLoans(1);
            AddNewLoan.ShowDialog();
        }

        private void BtnFIndLoan_Click_1(object sender, EventArgs e)
        {
            CrudLoans Find = new CrudLoans(2);
            Find.ShowDialog();
        }

        private void BtnUpdateLoan_Click_1(object sender, EventArgs e)
        {
            CrudLoans Update = new CrudLoans(3);
            Update.ShowDialog();
        }

        private void BtnDeleteLoan_Click_1(object sender, EventArgs e)
        {
            CrudLoans delete = new CrudLoans(4);
            delete.ShowDialog();
        }

        private void LbFormAddress_Click(object sender, EventArgs e)
        {

        }
    }
}
