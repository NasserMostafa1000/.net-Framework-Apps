using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemDataAccessLayer
{
    public class ClsEmployees
    {
        public static DataTable GetAllEmployees(int PageNum)
        {
            DataTable Employees = new DataTable();
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string query = "EXEC SP_GetAllEmployees @PageNum";
                using (SqlCommand command=new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@PageNum", PageNum);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                           
                            {
                                Employees.Load(reader);
                            }
                        }

                    }catch(Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                }
         
            }
            return Employees;
        }
        public static bool AddNewEmployee(string FirstName,string LastName,string MidName,string NationalId,string ImagePath,string Department)
        {
            bool IsAdded = false;
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string query = "EXEC SP_AddNewEmployee @FirstName,@MidName,@LastName,@Department,@NationalId,@ImagePath";
                using (SqlCommand command=new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@MidName", MidName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Department", Department);
                    command.Parameters.AddWithValue("@NationalId", NationalId);
                    command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    try
                    {
                        connection.Open();
                        int RowsAffected = command.ExecuteNonQuery();
                        if (RowsAffected>0)
                        {
                            IsAdded = true;
                        }
                    }
                    catch(Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                }
            }
            return IsAdded;

        }
        public static bool FindEmployee(int ID,ref string FirstName, ref string MideName, ref string LastName,ref string NationalId,ref string ImagePath,ref int DepartmentId)
        {
            bool IsFounded = false;
           using(SqlConnection connection=new SqlConnection(ClsSettings.connectionString))
            {
                string Query = "EXEC SP_GetEmployeeById @ID ;";
                using(SqlCommand command=new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                IsFounded = true;
                                while(reader.Read())
                                {
                                    FirstName = reader["FirstName"].ToString();
                                    LastName = reader["LastName"].ToString();
                                    MideName = reader["MidName"].ToString();
                                    DepartmentId = int.Parse(reader["DepartmentId"].ToString());
                                    NationalId = reader["NationalId"].ToString();
                                    ImagePath = reader["ImagePath"].ToString();
                                }
                           
                            }
                        }


                    }catch(Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                }
                return IsFounded;
            }
        }

        public static bool UpdateEmployee(int EmployeeId,string FirstName,string LastName,string MidName,string NationalId,string ImagePath,int DepartmentId)
        {
            bool IsUpdatedSuccessfully = false;
            using (SqlConnection connection=new SqlConnection(ClsSettings.connectionString))
            {
                string query = "SP_UpdateEmployee @EmployeeId,@FirstName,@MidName,@LastName,@DepartmentId,@NationalId,@ImagePath;";
                using (SqlCommand command=new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@MidName", MidName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DepartmentId", DepartmentId);
                    command.Parameters.AddWithValue("@NationalId", NationalId);
                    command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    try
                    {
                        connection.Open();
                        int RowsAffected = command.ExecuteNonQuery();
                        if(RowsAffected>0)
                        {
                            IsUpdatedSuccessfully = true;
                        }
                    }
                    catch(Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }

                }
            }
            return IsUpdatedSuccessfully;

        }
        public static bool DeleteEmployeeById(int EmployeeId)
        {
            bool IsdeletedSuccess = false;
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {

                string query = "exec SP_DeleteEmployee @EmployeeId;";
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                        connection.Open();
                        int RowAffect = command.ExecuteNonQuery();
                        if (RowAffect > 0)
                        {
                            IsdeletedSuccess = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    ClsSettings.ErrorsToEventLog(ex);
                }
            }
            return IsdeletedSuccess; ;
        }

    }
}
