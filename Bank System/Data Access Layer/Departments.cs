using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemDataAccessLayer
{
    public class Departments
    {
        public static void GetDepartmentsNameById(int DepartmentId, ref string DepartmentName)
        {
            DataTable Departments = new DataTable();
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string query = "select DepartmentName from Departments where DepartmentID=@DepartmentId ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DepartmentId", DepartmentId);
                    try
                    {
                        connection.Open();
                        object Result = command.ExecuteScalar();
                        if (Result != null)
                        {
                            DepartmentName = Convert.ToString(Result);
                        }

                    }
                    catch (Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                }
            }
        }
        public static DataTable GetAllDepartmentsName()
        {
            DataTable Departments = new DataTable();
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string query = "select DepartmentName from Departments ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            {
                                Departments.Load(reader);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                }
            }
            return Departments;
        }
        public static DataTable GetAllDepartments()
        {
            DataTable Departments = new DataTable();
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string query = "select * from Departments ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            {
                                Departments.Load(reader);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                }
            }
            return Departments;
        }
        public static bool AddNewDepartment(string Name, float Salary)
        {
            bool IsAddedSuccessfully = false;
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string Query = "INSERT INTO Departments  VALUES (@Name, @Salary)";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Salary", Salary);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            IsAddedSuccessfully = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                }
            }
            return IsAddedSuccessfully;
        }
        public static void FindDepartmentById(int DepartmentId, ref string DepartmentName,ref float salary)
        {
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string query = "select * from Departments where DepartmentID=@DepartmentId ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DepartmentId", DepartmentId);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                           
                                while(reader.Read())
                                {
                                    DepartmentName = reader["DepartmentName"].ToString();
                                    salary =float.Parse(reader["Salary"].ToString());
                                }
                            
                        }

                    }
                    catch (Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                }
            }
        }
        public static bool UpdateDepartmentById(int Id,float Salary,string DepartmentName)
        {
            bool IsUpdatedSuccessfully = false;
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))

            {
                string query = "update Departments set DepartmentName=@DepartmentName,Salary=@Salary where DepartmentID=@Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@Salary", Salary);
                    command.Parameters.AddWithValue("@DepartmentName", DepartmentName);

                    try
                    {
                        connection.Open();
                        int rowAffected = command.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            IsUpdatedSuccessfully = true;
                        }


                    }
                    catch (Exception ex)
                    {
                        IsUpdatedSuccessfully = false;
                        ClsSettings.ErrorsToEventLog(ex);
                    }

                    return IsUpdatedSuccessfully;
                }
            }


        }
        public static bool DeleteDepartment(int ID)
        {
            bool IsdeletedSuccess = false;
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {

                string query = "delete from Departments where DepartmentID=@ID;";
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
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
        public static void GetDepartmentsIDByName(string DepartmentName, ref int DepartmentId)
        {
            DataTable Departments = new DataTable();
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string query = "select DepartmentId from Departments where DepartmentName=@DepartmentName ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DepartmentName", DepartmentName);
                    try
                    {
                        connection.Open();
                        object Result = command.ExecuteScalar();
                        if (Result != null)
                        {
                            DepartmentId = int.Parse(Result.ToString());
                        }

                    }
                    catch (Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                }
            }
        }
    }
}
