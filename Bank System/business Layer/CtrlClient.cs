using BankSystemDataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class CtrlClient : UserControl
    {
        public CtrlClient()
        {
            InitializeComponent();
        }
        public class ClsClient
        {
            public string FirstName, LastName, MidName, Address, NationaltyNumber, ImagePath;
            public int ID;
            public float balance=0 ; public decimal Taxes;
        }
      public  ClsClient ClientInfo = new ClsClient();
        public void UpdateFormAddress(string text)
        {
            formAddress.Text = text;
        }
        //properties are important to call it from forms
        public string TXFirstName
        {
            get { return TxFirstName.Text; }
            set { TxFirstName.Text = value; }
        }
        public decimal TXTaxes
        {
            get { return decimal.Parse(TxTaxes.Text.ToString()); }
            set { TxTaxes.Text = value.ToString(); }
        }
        public string TXMidName
        {
            get { return TxMidName.Text; }
            set { TxMidName.Text = value; }
        }
        public string TXLastName
        {
            get { return TxLastName.Text; }
            set { TxLastName.Text = value; }
        }
        public string TXAddress
        {
            get { return TxAddress.Text; }
            set { TxAddress.Text = value; }
        }

        public float TXBalance
        {
            get { return float.Parse((TxBalance.Text)); }
            set { TxBalance.Text = value.ToString(); }
        }
        public string TXNationalID
        {
            get { return TxNationalId.Text; }
            set { TxNationalId.Text = value; }
        }
        public int TXAccountID
        {
            get { return Convert.ToInt32(TxAccountID.Text); }
            set { TxAccountID.Text = value.ToString(); }
        }
        public void EnableTxIDAndVisibleBtnFind()
        {
            //used for Find client only
            TxAccountID.Enabled = false;
            //used for Udpate client only
            BtnFind.Visible = false;
        }
        public void EnableTxID()
        {
            TxAccountID.Enabled = true;
        }
        //there are two label one for add and the other for update
        public void UpdateLinkedLabel(string NewLinkedLabel)
        {
            LkImage.Text = NewLinkedLabel;
        }
   
        public void ShowPictureBox()
        {
            ImageBox.Show();
        }
        //the inital value of the taxes are 0 so we hide Taxes info on adding and show it on updateing and finding
        public void HideTaxesInfo()
        {
            LbTaxes.Hide();
            TxTaxes.Hide();
        }
        public void ShowTaxesInfoButKeepDisable()
        {
            LbTaxes.Show();
            TxTaxes.Show();
            TxTaxes.Enabled = false;

        }
        public void ShowTaxesInfo()
        {

            LbTaxes.Show();
            TxTaxes.Show();
            TxTaxes.Enabled = true;

        }
       
        private void Client_Load(object sender, EventArgs e)
        {

        }
        public string ImagePath { get; set; }=null;
        public bool IsInfoCompelete()
        {
            if (string.IsNullOrEmpty(TxLastName.Text) || string.IsNullOrEmpty(TxFirstName.Text) ||
                string.IsNullOrEmpty(TxNationalId.Text) || string.IsNullOrEmpty(TxMidName.Text) ||
                string.IsNullOrEmpty(TxBalance.Text) || string.IsNullOrEmpty(TxAddress.Text) || ClientInfo.ImagePath == null)
            {
                return false;
            }
            return true;
        }
        private bool FindClient()
        {
            //this function will call data access layer
            return ClsClients.FindClientById(TXAccountID, ref ClientInfo.FirstName, ref ClientInfo.MidName, ref ClientInfo.Address, ref ClientInfo.NationaltyNumber,
                 ref ClientInfo.LastName, ref ClientInfo.balance, ref ClientInfo.Taxes, ref ClientInfo.ImagePath);
        }

        public void DisableAllControlsExceptAccountId()
        {
            //there are user only on adding and update not with show or find client 
            TxAddress.Enabled = false;
            TxBalance.Enabled = false;
            TxFirstName.Enabled = false;
            TxLastName.Enabled = false;
            TxNationalId.Enabled = false;
            TxMidName.Enabled = false;
            TxAccountID.Enabled = true;
            TxTaxes.Enabled = false;
            //used for Udpate And Delete client only
            BtnFind.Visible = false;
        }
        public void ShowFindButton()
        {
            BtnFind.Visible = true;
        }
        public void EnableAllControls()
        {
            TxAddress.Enabled = true;
            TxBalance.Enabled =   true;
            TxFirstName.Enabled = true;
            TxLastName.Enabled =  true;
            TxNationalId.Enabled =true;
            TxMidName.Enabled =   true;
        }
        public bool IsTxAccountIdNullOrEmpty()
        {
            return (TxAccountID.Text == "" || TxAccountID.Text == null);
        }
        public void SetClientinfoInUi()
        {
            TxAddress.Text         = ClientInfo.Address;
            TxBalance.Text         = ClientInfo.balance.ToString();
            TxFirstName.Text       = ClientInfo.FirstName;
            TxLastName.Text        = ClientInfo.LastName;
            TxNationalId.Text      = ClientInfo.NationaltyNumber;
            TxTaxes.Text           = ClientInfo.Taxes.ToString();
            TxMidName.Text         = ClientInfo.MidName;
            ImageBox.Image = Image.FromFile(ClientInfo.ImagePath);
        }
        private void LkImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image File";

                // فتح مربع الحوار وعرضه للمستخدم
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ClientInfo.ImagePath = openFileDialog.FileName;

                    // تعيين الصورة في PictureBox
                    ImageBox.Image = Image.FromFile(openFileDialog.FileName);

                }
            }
        }
        public void GetInfoFromUI()
        {
            ClientInfo.Address= TxAddress.Text      ;
            ClientInfo.balance =float.Parse(TxBalance.Text);    ;
            ClientInfo.FirstName= TxFirstName.Text  ;
            ClientInfo.LastName= TxLastName.Text   ;
            ClientInfo.NationaltyNumber= TxNationalId.Text ;
            ClientInfo.Taxes=decimal.Parse(TxTaxes.Text) ;
            ClientInfo.MidName= TxMidName.Text    ;
        }
        public bool UpdateClient()
        {
           return ClsClients.UpdateClientById(Convert.ToInt32(TxAccountID.Text),  ClientInfo.FirstName, 
                    ClientInfo.MidName,  ClientInfo.Address,  ClientInfo.NationaltyNumber,  ClientInfo.LastName,
                     ClientInfo.balance,  ClientInfo.Taxes,  ClientInfo.ImagePath);
         

        }
        private void BtnFind_Click(object sender, EventArgs e)
        {
            if(!IsTxAccountIdNullOrEmpty())
            {
              if(FindClient())
                {
                    EnableAllControls();
                    //to avoid any changed on Id after get the information to avoid ambigous and crashing data on database
                    TxAccountID.Enabled = false;
                    SetClientinfoInUi();
                }
            }
            else
            {
                MessageBox.Show("No Information To Found");
            }
        }

        private void LbTaxes_Click(object sender, EventArgs e)
        {

        }
    }
}
