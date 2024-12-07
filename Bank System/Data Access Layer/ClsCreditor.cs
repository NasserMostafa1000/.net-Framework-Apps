using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemDataAccessLayer
{
    public  class ClsCreditor
    {
        public static DataTable GatAllCerditors(int PageNumber)
        {
            DataTable Certificates = new DataTable();
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))

            {
                string Query = "exec SP_GetAllCreditor @PageNumber;";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@PageNumber", PageNumber);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        Certificates.Load(reader);


                    }
                }
            }
            return Certificates;
        }
        public static bool AddNewCreditor(int ClientID,int CertificateId)
        {
            float PayedProfit = 0;
            bool IsAdded = false;
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string query = "DECLARE @EndDate DATETIME; Declare @StartDate datetime;select @StartDate=GETDATe();SELECT @EndDate = dbo.GetTheEndDateOfTheCertificate(@CertificateId);EXEC SP_AddNewCreditors  @PayedProfit = @PayedProfit,   @ClientId = @ClientID,\r\n    @StartPeriod = @StartDate,  \r\n    @EndPeriod = @EndDate,  \r\n    @CertificateID = @CertificateId;" 
               ;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientID", ClientID);
                    command.Parameters.AddWithValue("@CertificateId", CertificateId);
                    command.Parameters.AddWithValue("@PayedProfit", PayedProfit);


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

        public static DataTable FindCreditorById(int Id)
        {
            DataTable Creditor = new DataTable();
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string Query = "Exec [SP_GetCreditorById] @Id";
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
        public static bool IsThisCreditorIsAlreadtExists(int Id)
        {
            bool IsExists = false;
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string Query = "Exec [SP_GetCreditorById] @Id";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                IsExists = true;
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        IsExists = false;
                        ClsSettings.ErrorsToEventLog(ex);
                    }

                }

            }
            return IsExists;
        }
        public static bool PayAllProfit()
        {
            bool IsPayed = false;
            using (SqlConnection connection=new SqlConnection(ClsSettings.connectionString))
            {
                string Query = " EXEC SP_PayProfitForAllCreditors;";
                using (SqlCommand command = new SqlCommand(Query,connection))
                {
                    connection.Open();
                    try
                    {
                        int RowsAffected = command.ExecuteNonQuery();
                        if (RowsAffected > 0)
                        {
                            IsPayed = true;
                        }
                    }catch(Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                   
                }
                return IsPayed;
            }
        }
        public static bool DropCertificate(int CertificateID)
        {
            bool IsPayed = false;
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string Query = " EXEC [SP_DeleteCreditor] @CertificateID;";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@CertificateID", CertificateID);
                    connection.Open();
                    try
                    {
                        int RowsAffected = command.ExecuteNonQuery();
                        if (RowsAffected > 0)
                        {
                            IsPayed = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }

                }
                return IsPayed;
            }
        }


    }
}
