using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemDataAccessLayer
{
    public class ClsDebtors
    {
        public static DataTable GetAllDebtors(int PageNum)
        {
            DataTable Employees = new DataTable();
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string query = "EXEC SP_GetAllDebtors @PageNum";
                using (SqlCommand command = new SqlCommand(query, connection))
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

                    }
                    catch (Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                }

            }
            return Employees;
        }
        public static bool AddNewDebtor(int ClientID, int LoanId, string Collateral, DateTime BorrowingDate, DateTime DueDate)
        {
            float PayedAmount = 0;
            byte IsActive = 1;
            bool IsAdded = false;
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string query= "EXEC [SP_AddNewDebtor] @LoanId,@ClientID,@PayedAmount,@BorrowingDate,@DueDate,@IsActive,@Collateral"
               ;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientID", ClientID);
                    command.Parameters.AddWithValue("@Collateral", Collateral);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@LoanId", LoanId);
                    command.Parameters.AddWithValue("@PayedAmount", PayedAmount);
                    command.Parameters.AddWithValue("@BorrowingDate", BorrowingDate);
                    command.Parameters.AddWithValue("@DueDate", DueDate);

                    try
                    {
                        connection.Open();
                        int RowsAffected = command.ExecuteNonQuery();
                        if (RowsAffected > 0)
                        {
                            IsAdded = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                }
            }
            return IsAdded;

        }
        public static DataTable FindDebtorById(int Id)
        {
            DataTable Creditor = new DataTable();
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string Query = "Exec SpGetDebtorById @Id";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Creditor.Load(reader);


                        }
                    }
                    catch (Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }

                }

            }
            return Creditor;
        }
        public static DataTable FindDebtorInfoById(int Id)
        {
            DataTable Creditor = new DataTable();
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string Query = "select * from Debtors where DebtorID= @Id";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Creditor.Load(reader);


                        }
                    }
                    catch (Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }

                }

            }
            return Creditor;
        }
        public static bool UpdatePayedAmount(int DebtorId,float Dues)
        {
            bool IsUpdated = false;
            using (SqlConnection connection=new SqlConnection(ClsSettings.connectionString))
            {
                string qeury = "exec Sp_PayPartOfDUes @DebtorId,@Dues;";
                using (SqlCommand command = new SqlCommand(qeury, connection))
                {
                    command.Parameters.AddWithValue("DebtorId", DebtorId);
                    command.Parameters.AddWithValue("Dues", Dues);
                    try
                    {
                        connection.Open();
                        int RowsAffected = command.ExecuteNonQuery();
                        if (RowsAffected > 0)
                        {
                            IsUpdated = true;
                        }
                    }catch(Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                    

                }
            }
            return IsUpdated;
        }
        public static bool CloseLoan(int DebtorId)
        {
            bool IsUpdated = false;
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string qeury = "exec SP_CloseLoan @DebtorId;";
                using (SqlCommand command = new SqlCommand(qeury, connection))
                {
                    command.Parameters.AddWithValue("DebtorId", DebtorId);
                    try
                    {
                        connection.Open();
                        int RowsAffected = command.ExecuteNonQuery();
                        if (RowsAffected > 0)
                        {
                            IsUpdated = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }


                }
            }
            return IsUpdated;
        }


    }
}
