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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void GetDefault()
        {
            TxFrom.Enabled = false;
            TxTo.Enabled = false;
            BtnChooseTo.Visible = true;
            BtnChooseFrom.Visible = true;


        }
        private bool IsValidateTextBoxes ()
        {
            if (string.IsNullOrEmpty(TxAmount.Text) || string.IsNullOrEmpty(TxFrom.Text) || string.IsNullOrEmpty(TxTo.Text))
            {
                return false;
            }
            if (!float.TryParse(TxAmount.Text, out float Amount))
            {
                return false;
            }
            return true;
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            GetDefault();
        }
        public struct SenderAndReciver
        {
            public int SenderId,ReciverID;public float SenderBalance;
        }public SenderAndReciver OperationINfo = new SenderAndReciver();

        private void GetSenderInfoFromFindForm(int Id,string FirstName,string MidName,string LastName,float Balance)
        {
            TxFrom.Text = FirstName + " " + LastName;
            OperationINfo.SenderId = Id;
            OperationINfo.SenderBalance = Balance;
            HideChooseFromButtonAfterChoosing();

        }
        private void HideChooseFromButtonAfterChoosing()
        {
            BtnChooseFrom.Visible = false;
        }
        private void HideChooseToButtonAfterChoosing()
        {
            BtnChooseTo.Visible = false;
        }
        private void GetReciverInfoFromFindForm(int Id, string FirstName,string MidName ,string LastName, float Balance)
        {
            TxTo.Text = FirstName + " " + LastName;
            OperationINfo.ReciverID = Id;
           
            HideChooseToButtonAfterChoosing();
        }
        private void BtnChooseFrom_Click(object sender, EventArgs e)
        {
            //3 means its find mode
            CrudClient FindClientToTransferTO = new CrudClient(3);
            FindClientToTransferTO.PersonFounded += GetSenderInfoFromFindForm;
            FindClientToTransferTO.ShowDialog();
        }

        private void BtnChooseTo_Click(object sender, EventArgs e)
        {
            CrudClient FindClientToReciveMoney = new CrudClient(3);
            FindClientToReciveMoney.PersonFounded += GetReciverInfoFromFindForm;
            FindClientToReciveMoney.ShowDialog();
        }
        private bool CheckAccountBalance(float Amount,float SenderBalance)
        {
            return (Amount < SenderBalance);
        }
        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            float Amount = float.Parse(TxAmount.Text);
            if (IsValidateTextBoxes()&& CheckAccountBalance(Amount, OperationINfo.SenderBalance))
            {
              if(ClsClients.Transer(OperationINfo.SenderId,OperationINfo.ReciverID, Amount))
                {
                    MessageBox.Show("Transferd Done Successfully", "Operation Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Information Missed Or Balanced Not Enought!!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
