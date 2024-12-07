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
    public partial class ctrlCreditors : UserControl
    {
        public ctrlCreditors()
        {
            InitializeComponent();
        }
    public class CreditorDetails
        {
           public int ClientId, CertificateId;
        }
        public CreditorDetails OperationDetails = new CreditorDetails();

        private void ctrlCreditors_Load(object sender, EventArgs e)
        {
            TxCertificate.Enabled = false;
            TxName.Enabled = false;
        }
     public void disableTxID()
        {
            TxID.Enabled = false;
        }
        public void EnableTxId()
        {
            TxID.Enabled = true;
        }
        public void disableAllInfo()
        {
            BtnChooseCertificate.Enabled = false;
            BtnChooseClient.Enabled = false;
           
        }
        public void disableAllInfoExceptID()
        {
            TxCertificate.Enabled = false;
            TxName.Enabled = false;
        }
        public void EnableAllInfoExceptID()
        {
            TxCertificate.Enabled = true;
            TxName.Enabled = true;
        }
        public void ChangeFormAddress(string NewAddress)
        {
            LbFormAddress.Text = NewAddress;
        }
        public int CreditorId
        {
            get { return int.Parse(TxID.Text); }
            set { TxID.Text = value.ToString(); }
        }
        public string FullName
        {
            get { return (TxName.Text).ToString(); }
            set { TxName.Text = value.ToString(); }
        }
        public float CertificatePrice
        {
            get { return float.Parse(TxCertificate.Text); }
            set { TxCertificate.Text = value.ToString(); }
        }
        public bool IsTxIdNotNullAndConsistant()
        {
            return (int.TryParse(TxID.Text, out int ID));
        }
        public bool IsInfoCompeleteAndConsistant()
        {
            if(!string.IsNullOrEmpty(TxName.Text))
            {
                return float.TryParse(TxCertificate.Text, out float Price);
            }
            return false;
        }

        private void BtnChooseClient_Click(object sender, EventArgs e)
        {
            CrudClient Find = new CrudClient(3);
            Find.PersonFounded += GetClientDetails;
            Find.ShowDialog();
        }
        private void GetClientDetails(int ID,string FirstName,string MidName,string LastName,float Balance)
        {
            OperationDetails.ClientId = ID;
            TxName.Text = FirstName + " " + MidName + " " + LastName;
        }
        private void BtnChooseCertificate_Click(object sender, EventArgs e)
        {
            CrudCertificatecs Find = new CrudCertificatecs(2);
            Find.OnFindCertificate += GetCertificateDetails;
            Find.ShowDialog();
        }
        private void GetCertificateDetails(float CertificatePrice,int CertificateID)
        {
            OperationDetails.CertificateId = CertificateID;
            TxCertificate.Text = CertificatePrice.ToString();

        }
    }
}
