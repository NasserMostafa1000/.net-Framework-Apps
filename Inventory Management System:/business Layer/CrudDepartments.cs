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
    public partial class CrudDepartments : Form
    {
        public CrudDepartments(byte ModeNumber)
        {
            InitializeComponent();
            if(ModeNumber==1)
            {
                UpdateFormToPerformAddnew();
                CurrentMode = CrudDepartments.Mode.addnew;
            }
           else if (ModeNumber == 2)
            {
                UpdateFormToPerformFind();
                CurrentMode = CrudDepartments.Mode.find;
            }
          else  if(ModeNumber==3)
            {
                CurrentMode = CrudDepartments.Mode.Update;
                UpdateFormToPerformUpdate();
            }
            else
            {
                CurrentMode = CrudDepartments.Mode.Delete;
                UpdateFormToPerformDelete();
            }
        }
        private void UpdateFormToPerformAddnew()
        {
            ctrDepartments1.ChangeFormAddress("Add New Department");
            BtnFinish.Text = "Add";
            ctrDepartments1.DisableTxDepartmentID();
        }
        private void UpdateFormToPerformFind()
        {
            ctrDepartments1.ChangeFormAddress("Find Departmemt");
            BtnFinish.Text = "Find";
            ctrDepartments1.DesableAlldetailsExceptAccountID();
        }
        private void UpdateFormToPerformUpdate()
        {
            ctrDepartments1.ChangeFormAddress("Update Department");
            BtnFinish.Text = "Update";
            ctrDepartments1.DesableAlldetailsExceptAccountID();
        }
        private void UpdateFormToPerformDelete()
        {
            BtnFinish.Text = "Delete";
            ctrDepartments1.ChangeFormAddress("delete Department");
            ctrDepartments1.DesableAlldetailsExceptAccountID();
        }
        enum Mode
        {
            addnew,Update,find,Delete
        }
        Mode CurrentMode;
    private void AddNewDepartment()
        {
            if(ctrDepartments1.IsDepartmentDetailsCompleteAndConsistent())
            {
                ctrDepartments1.GetTheDetailsFromUI();
              if(Departments.AddNewDepartment(ctrDepartments1.CurrentDepartment.Name, ctrDepartments1.CurrentDepartment.Salary))
                    {
                    ClsSettings.CallMessageBoxForSuccessAdding();
                    this.Close();
                }
            }
        }
        private void FindDepartment()
        {
            if(ctrDepartments1.IsIdNullOrContainString())
            {
                Departments.FindDepartmentById(ctrDepartments1.DepartmentId,ref ctrDepartments1.CurrentDepartment.Name
                    ,ref ctrDepartments1.CurrentDepartment.Salary);
                ctrDepartments1.SetTheDetailsToUI();
            }
            else
            {
                ClsSettings.CallMessageBoxForNotFound();
            }
        }
        private void UpdateDepartment()
        {
            if(!ctrDepartments1.IsIdNullOrContainString())
            {
                ClsSettings.CallMessageBoxForNotFound();
            }
            else
            {
                ctrDepartments1.GetTheDetailsFromUI();
              if(Departments.UpdateDepartmentById(ctrDepartments1.DepartmentId, ctrDepartments1.CurrentDepartment.Salary, ctrDepartments1.CurrentDepartment.Name))
                    {
                    ClsSettings.CallMessageBoxForSuccessUpdates();
                    this.Close();
                }
            }
        }
        private void DeleteDeparmtent()
        {
            if (!ctrDepartments1.IsIdNullOrContainString())
            {
                ClsSettings.CallMessageBoxForNotFound();
            }
            else
            {
                if(Departments.DeleteDepartment(ctrDepartments1.DepartmentId))
                {
                    ClsSettings.CallMessageBoxForSuccessDeletion();
                    this.Close();
                }
            }
        }
        private void BtnFinish_Click(object sender, EventArgs e)
        {
            switch(CurrentMode)
            {
                case Mode.addnew:
                    {
                        AddNewDepartment();
                        
                    }
                    break;
                case Mode.find:
                    {
                        FindDepartment();
                    }
                    break;
                case Mode.Update:
                    {
                        UpdateDepartment();
                    }
                    break;
                case Mode.Delete:
                    {
                        DeleteDeparmtent();
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CurrentMode==Mode.Update)
            {
                FindDepartment();
                ctrDepartments1.EnableAlldetailsExceptAccountID();
                BtnCheck.Visible = false;
            }
            else
            {
                FindDepartment();
                MessageBox.Show("You Are So Close From Deleting This Department ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnCheck.Visible = false;

            }
        }

        private void ctrDepartments1_Load(object sender, EventArgs e)
        {

        }

        private void CrudDepartments_Load(object sender, EventArgs e)
        {

        }
    }
}
