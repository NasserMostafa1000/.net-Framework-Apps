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
    public partial class CrudClient : Form
    {
        public CrudClient(int Mode)
        {
            InitializeComponent();
            if (Mode == 1)
            {
                EnMode = CrudClient.Mode.EnAddNew;
                UpdateFormToPerformAdding();
            }
            else if (Mode == 2)
            {
                EnMode = CrudClient.Mode.EnUpdate;
                UpdateFormToPerformUpdateClient();
            }
            else if (Mode == 3)
            {
                EnMode = CrudClient.Mode.EnFind;
                UpdateFormToPerformFindClient();

            }
            else if(Mode==4)
            {
                EnMode = CrudClient.Mode.EnDelete;
                UpdateFormToPerformDeleteClient();

            }

        }
        public delegate void onFindPerson(int ID,string FirstName,string MidName ,string LastName,float balance);
        public event onFindPerson PersonFounded;
        private void UpdateFormToPerformFindClient()
         {
            //use for delete  only
            BtnCheck.Visible = false;
            client1.UpdateFormAddress("Find Client");
            client1.DisableAllControlsExceptAccountId();
            BtnAdd.Text = "Finish";

            client1.ShowTaxesInfoButKeepDisable();
            client1.UpdateLinkedLabel("Image");

        }
        private void UpdateFormToPerformDeleteClient()
        {
      
            client1.UpdateFormAddress("Delete Client");
            BtnAdd.Text = "Delete";
            client1.UpdateLinkedLabel("Image");
            client1.DisableAllControlsExceptAccountId();


        }
        private void UpdateFormToPerformUpdateClient()
        {
            //use for delete  only
            BtnCheck.Visible = false;
            client1.UpdateFormAddress("Update Client");
            client1.ShowTaxesInfoButKeepDisable();
            BtnAdd.Text = "Update";
            client1.ShowTaxesInfo();
            client1. UpdateLinkedLabel("Update Image");
            client1.DisableAllControlsExceptAccountId();
            client1.ShowFindButton();

        }
        private void UpdateFormToPerformAdding()
        {
            //use for delete  only
            BtnCheck.Visible = false;
            client1.UpdateFormAddress("Add New Client");
            client1.HideTaxesInfo();
            BtnAdd.Text = "Add";
            client1.UpdateLinkedLabel("Add Image");
            client1.EnableTxIDAndVisibleBtnFind();
        }
        private Mode EnMode;
        private enum Mode
        { EnAddNew = 1, EnUpdate = 2, EnFind = 3,EnDelete=4 }
        private void AddNewClient_Load(object sender, EventArgs e)
        {
        }
        private int addNewClient()
        {
            //call data acess layer
         return   ClsClients.AddNewClient(client1.TXFirstName, client1.TXLastName, client1.TXMidName,client1.TXAddress ,client1.TXNationalID,
               client1.TXBalance, 0, client1.ClientInfo.ImagePath);
        }
        private bool FindClient()
        {
            //this function will call data access layer
          return  ClsClients.FindClientById( client1.TXAccountID, ref client1.ClientInfo.FirstName, ref client1.ClientInfo.MidName , ref client1.ClientInfo.Address, ref client1.ClientInfo.NationaltyNumber,
               ref client1.ClientInfo.LastName, ref client1.ClientInfo.balance, ref client1.ClientInfo.Taxes,ref  client1.ClientInfo.ImagePath);
        }
    
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            switch(EnMode)
            {
                case CrudClient.Mode.EnAddNew:
                    {
                        if (client1.IsInfoCompelete())
                        {
                            client1.TXAccountID = addNewClient();
                            client1.DisableAllControlsExceptAccountId();
                            //to avoid multiple adding the same item
                            BtnAdd.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("there are informations Missed");
                        }
                    }
                    break;
                case CrudClient.Mode.EnFind:
                    {
                        FindClientAndSetIntoUiIfAccountIdAtUiNotNull();
                        PersonFounded?.Invoke(client1.TXAccountID,client1.TXFirstName ,client1.TXMidName, client1.TXLastName,client1.TXBalance);

                    }
                    break;
                case CrudClient.Mode.EnUpdate:
                    {
                        //at the User Control we take the information
                        client1.GetInfoFromUI();
                        if (!client1.UpdateClient())
                        {
                            MessageBox.Show("errors occur");
                        }
                        else
                        {
                            MessageBox.Show("Done successfully ", "Done!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }

                    }break;
                case CrudClient.Mode.EnDelete:
                    {
                        if(deleteClientIdAccountIdExistsAtUI())
                        {
                            MessageBox.Show("Done!!"," Operation Done",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("nothing to delete");
                        }

                    }
                    break;
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool deleteClientIdAccountIdExistsAtUI()
        {
            return ClsClients.DeleteClient(client1.TXAccountID);
        }
        private void client1_Load(object sender, EventArgs e)
        {

        }
        private void FindClientAndSetIntoUiIfAccountIdAtUiNotNull()
        {
            if (client1.IsTxAccountIdNullOrEmpty())
            {
                MessageBox.Show("Nothing information to Find", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!FindClient())
                {
                    MessageBox.Show("Not Found");
                }
                else
                {
                    client1.SetClientinfoInUi();
                }
            }
        }
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            {
                if (client1.IsTxAccountIdNullOrEmpty())
                {
                    MessageBox.Show("Nothing information to Find", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!FindClient())
                    {
                        MessageBox.Show("Not Found");
                        this.Close();
                        return;
                        
                    }
                    else
                    {
                        client1.SetClientinfoInUi();
                        
                    }
                }
            }
            BtnCheck.Visible = false;
            MessageBox.Show("you are so close for delete this Client if you are sure press delete button ","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
;        }
    }
}
