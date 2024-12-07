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
    public partial class CrudEmployee : Form
    {
        public CrudEmployee(byte Mode)
        {
            InitializeComponent();
            if(Mode==1)
            {
                CurrentMode = CrudEmployee.Mode.AddNewMode;
                UpdateFormToPerfomAdd();
            }
            else if(Mode==2)
            {
                CurrentMode = CrudEmployee.Mode.FindMode;
                UpdateFormToPerfomFind();

            }
            else if(Mode==3)
            {
                CurrentMode = CrudEmployee.Mode.Update;
                UpdateFormToPerfomUpdate();
            }
            else
            {
                CurrentMode = CrudEmployee.Mode.Delete;
                UpdateFormToPerfomDelete();
            }
        }
        enum Mode
        {
            AddNewMode,FindMode,Update,Delete
        }
        Mode CurrentMode;
        public void AddCurrentEmployee()
        {
            //this function will get all details from the employee comtrol and call data access layer 
            ctrlEmployee1.GetInfoFromUi();
          if(ClsEmployees.AddNewEmployee(ctrlEmployee1.CurrentEmployee.FirstName,
                ctrlEmployee1.CurrentEmployee.LastName,
                ctrlEmployee1.CurrentEmployee.MidName, ctrlEmployee1.CurrentEmployee.NationalId,
                ctrlEmployee1.CurrentEmployee.ImagePath, ctrlEmployee1.CurrentEmployee.DepartmentName))
            {
                ClsSettings.CallMessageBoxForSuccessAdding();
            }
        }
        private void UpdateFormToPerfomFind()
        {
            ctrlEmployee1.DeisableAllInfoExceptEmployeeID();
            ctrlEmployee1.changeLkImage("Image");
            ctrlEmployee1.ChangeFormAddress("Find Employee");
            BtnCheck.Visible = false;
            btnFinish.Text = "Find";
            ctrlEmployee1.SetDepatmentsIntoCompoBox(Departments.GetAllDepartmentsName());
        }
        private void UpdateFormToPerfomDelete()
        {
            ctrlEmployee1.DeisableAllInfoExceptEmployeeID();
            ctrlEmployee1.changeLkImage("Image");
            ctrlEmployee1.ChangeFormAddress("Delete Employee");
            btnFinish.Text = "Delete";
            ctrlEmployee1.SetDepatmentsIntoCompoBox(Departments.GetAllDepartmentsName());
        }
        private void UpdateFormToPerfomUpdate()
        {
            ctrlEmployee1.changeLkImage("Update Image");
            ctrlEmployee1.DeisableAllInfoExceptEmployeeID();
            ctrlEmployee1.ChangeFormAddress("Update Employee");
            btnFinish.Text = "Update";
            ctrlEmployee1.SetDepatmentsIntoCompoBox(Departments.GetAllDepartmentsName());
        }

        private void UpdateFormToPerfomAdd()
        {
            btnFinish.Text = "Finish";
            BtnCheck.Visible = false;
            BtnCheck.Visible = false;
            ctrlEmployee1.HideAccountId();
            ctrlEmployee1.changeLkImage("Add Image");

            ctrlEmployee1.ChangeFormAddress("Add New Employee");
            ctrlEmployee1.SetDepatmentsIntoCompoBox(Departments.GetAllDepartmentsName());
        }
     private void AddNewEmployee()
        {
            if(ctrlEmployee1.IsInfoCompleteAndConsistent())
            {
                AddCurrentEmployee();
                this.Close();

            }
            else
            {
                ClsSettings.CallMessageBoxForMissingOrWrongInformation();
            }
        }
        private void FindEmployee()
        {
            if(ctrlEmployee1.IsTxEmployeeIdNullOrEmpty())
            {
                ClsSettings.CallMessageBoxForMissingOrWrongInformation();
            }
            else
            {
                int DepartmentID=0;
                if(!ClsEmployees.FindEmployee(ctrlEmployee1.EmployeeId, ref ctrlEmployee1.CurrentEmployee.FirstName,
                  ref ctrlEmployee1.CurrentEmployee.MidName, ref ctrlEmployee1.CurrentEmployee.LastName,
                    ref ctrlEmployee1.CurrentEmployee.NationalId, ref ctrlEmployee1.CurrentEmployee.ImagePath, ref DepartmentID))
                {
                    MessageBox.Show("Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //this will take the department id and return department name to put it into compo box
                Departments.GetDepartmentsNameById(DepartmentID,ref ctrlEmployee1.CurrentEmployee.DepartmentName);
                //set info into ui 
                ctrlEmployee1.SetinfoIntoUI();
            }
        }
        private void UpdateEmployee()
        {
            ctrlEmployee1.GetInfoFromUi();
            int DepartmentId=0;
            //get department Name from compo box and call data access layer to return The Id Of the Department Name 
            //cause this is related table for employee ,i separate employees and their departments for avoid redundancy
            Departments.GetDepartmentsIDByName(ctrlEmployee1.CurrentEmployee.DepartmentName, ref DepartmentId);
            if (ClsEmployees.UpdateEmployee(ctrlEmployee1.EmployeeId, ctrlEmployee1.CurrentEmployee.FirstName,
                ctrlEmployee1.CurrentEmployee.LastName, ctrlEmployee1.CurrentEmployee.MidName, ctrlEmployee1.CurrentEmployee.NationalId,
                 ctrlEmployee1.CurrentEmployee.ImagePath, DepartmentId))
            {
             ClsSettings.CallMessageBoxForSuccessUpdates();
                this.Close();

            }
        }
        private  void DeleteClient()
        {
            if (ClsEmployees.DeleteEmployeeById(ctrlEmployee1.EmployeeId))
            {

                ClsSettings.CallMessageBoxForSuccessDeletion();
                this.Close();

            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            switch(CurrentMode)
            {
                case Mode.AddNewMode:

                    {
                        AddNewEmployee();
                      
                    }break;
                case Mode.FindMode:
                    {
                        FindEmployee();
                    }
                    break;
                case Mode.Update:
                    {
                        UpdateEmployee();
                    }
                    break;
                case Mode.Delete:
                    {
                        DeleteClient();
                    }
                    break;
            }
        }

        private void CrudEmployee_Load(object sender, EventArgs e)
        {

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            FindEmployee();
            BtnCheck.Visible = false;
            if(CurrentMode==Mode.Update)
            {
                ctrlEmployee1.EnableAllInfoExceptEmployeeID();
            }
            else
            {
                MessageBox.Show("you are so close from delete this Employee!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ctrlEmployee1_Load(object sender, EventArgs e)
        {

        }
    }
}
