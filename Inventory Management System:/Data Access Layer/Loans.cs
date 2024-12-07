using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemDataAccessLayer
{
    public class Loans
    {
        public static DataTable GetAllLoans(int PageNumber)
        {
            DataTable AllLoans = new DataTable();
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                try
                {
                    string Query = "exec [GetAllLoans] @PageNumber";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        connection.Open();

                        using (SqlDataReader READER = command.ExecuteReader())
                        {
                            AllLoans.Load(READER);
                        }
                    }
                }
                catch (Exception ex)
                {
                    ClsSettings.ErrorsToEventLog(ex);
                }
            }
            return AllLoans;
        }
        public static bool AddNewLoan(float LoanPrice, decimal BenifetPercentage, byte PaymentPeriodPerYear)
        {
            bool isAddedSuccessfully = false;

            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string query = "EXEC SP_AddNewLoan @LoanId,@BenifetPercentage,@PaymentPeriodPerYear;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LoanId", LoanPrice);
                    command.Parameters.AddWithValue("@BenifetPercentage", BenifetPercentage);
                    command.Parameters.AddWithValue("@PaymentPeriodPerYear", PaymentPeriodPerYear);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            isAddedSuccessfully = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                }
                return isAddedSuccessfully;
            }
        }
        public static bool Find(int LoanId, ref float loanPrice, ref decimal benefitPercentage, ref byte paymentPeriodPerYear)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string query = "EXEC SP_GetLoanLoanById @LoanId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LoanId", LoanId);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // تحقق مما إذا كانت هناك نتائج
                            if (reader.Read())
                            {
                                // تحديث القيم المرجعية بناءً على البيانات المسترجعة
                                loanPrice = float.Parse(reader["LoanPrice"].ToString());
                                benefitPercentage =decimal.Parse(reader["BenifetPercantage"].ToString());
                                paymentPeriodPerYear =byte.Parse(reader["PaymentPeriodPerYear"].ToString());

                                isFound = true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                }
            }

            return isFound;
        }
        public static bool UpdateLoanById(int Id, float LoanPrice, decimal LoanBenifet, byte LoanPeriod )
        {
            bool IsUpdatedSuccessfully = false;
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string query = "EXEC SP_UpdateLoan @Id,@LoanPrice,@LoanBenifet,@LoanPeriod";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@LoanPrice", LoanPrice);
                    command.Parameters.AddWithValue("@LoanBenifet", LoanBenifet);
                    command.Parameters.AddWithValue("@LoanPeriod", LoanPeriod);
                 

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

        public static bool DeleteLoan(int LoanID)
        {
            bool IsdeletedSuccess = false;
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {

                string query = "exec SP_DeleteLoan @LoanID;";
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LoanID", LoanID);
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
        public static bool FindLoanPriceById(int LoanId, ref float loanPrice)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string query = "select LoanPrice From Loans Where LoanID=@LoanId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LoanId", LoanId);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // تحقق مما إذا كانت هناك نتائج
                            if (reader.Read())
                            {
                                // تحديث القيم المرجعية بناءً على البيانات المسترجعة
                                loanPrice = float.Parse(reader["LoanPrice"].ToString());
 

                                isFound = true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                }
            }

            return isFound;
        }

    }
}

