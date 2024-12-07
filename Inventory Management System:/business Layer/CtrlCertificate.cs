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
    public partial class CtrlCertificate : UserControl
    {
        public CtrlCertificate()
        {
            InitializeComponent();
        }
        public class CertificateInfo
        {
            public int CertificateId;
            public byte CertificatePeriodPerYears;
            public float CertificatePrice;
            public decimal MonthlyProfitPercentage;
            public float totalProfit ;
        }
      public CertificateInfo CurrentCertificate  = new CertificateInfo();
        public int CertificateId
        {
            get { return Convert.ToInt32(TxId.Text); }
            set { TxId.Text = value.ToString(); }
        }
        public void SetCertificateInfoIntoUI()
        {
            //we use current Certificate object to find certificate on it from data access layer
            TxCertificatePrice.Text = CurrentCertificate.CertificatePrice.ToString();
            TxTotalProfit.Text = CurrentCertificate.totalProfit.ToString();
            UdCertificatePeriod.Value = CurrentCertificate.CertificatePeriodPerYears;
            UdProfitPercentage.Value = CurrentCertificate.MonthlyProfitPercentage;

        }
        public void GetInfoFromUi()
        {
            CurrentCertificate.CertificateId = int.Parse(TxId.Text);
            CurrentCertificate.CertificatePrice = float.Parse(TxCertificatePrice.Text);
            CurrentCertificate.totalProfit = float.Parse(TxTotalProfit.Text);
            CurrentCertificate.CertificatePeriodPerYears =byte.Parse(UdCertificatePeriod.Value.ToString());
            CurrentCertificate.MonthlyProfitPercentage = byte.Parse(UdProfitPercentage.Value.ToString());
        }
        public byte CertificatePerioud
        {
            get { return Byte.Parse(UdCertificatePeriod.Value.ToString()); }
            set { UdCertificatePeriod.Value = value; }
        }
        public string LbCOntrolAddress
        {
            set { LbControlAddress.Text = value; }
        }
        public float CertificatePrice
        {
            get { return float.Parse(TxCertificatePrice.Text); }
            set { TxCertificatePrice.Text = value.ToString(); }
        }
        public float TotalProfit
        {
            get { return float.Parse(TxTotalProfit.Text); }
            set { TxTotalProfit.Text = value.ToString(); }
        }
        public decimal ProfitPercentagePerMonth
        {
            get { return UdProfitPercentage.Value; }
            set { UdCertificatePeriod.Value = value; }
        }
        public void HideAccountIdToPerformAddNew()
        {
            TxId.Visible = false;
        }
        public void ShowAccountId()
        {
            TxId.Visible = true;
        }
        public void DisableAllTextBoxesExceptAccountId()
        {
            //Used for read ,find and delete operation
            TxCertificatePrice.Enabled = false;
            TxTotalProfit.Enabled = false;
            UdCertificatePeriod.Enabled = false;
            UdProfitPercentage.Enabled = false;
        }
        public void EnableAllTextBoxes()
        {
            //Used for create Operation
            TxCertificatePrice.Enabled = true;
            TxTotalProfit.Enabled = true;
            UdCertificatePeriod.Enabled = true;
            UdProfitPercentage.Enabled = true;
        }
        public bool IsInfoCompeleteAndConsistancy()
        {
            return (float.TryParse(TxCertificatePrice.Text, out float Price) &&
              float.TryParse(TxTotalProfit.Text, out float Profit) &&
             decimal.TryParse(UdProfitPercentage.Value.ToString(), out decimal Percentage) &&
             byte.TryParse(UdCertificatePeriod.Value.ToString(), out byte PerioudPerYear));
        }
        public bool ISTxIdNotNullAndConsistancy()
        {
            return !string.IsNullOrEmpty(TxId.Text) && int.TryParse(TxId.Text, out _);
        }

        private void CtrlCertificate_Load(object sender, EventArgs e)
        {

        }
    }
}
