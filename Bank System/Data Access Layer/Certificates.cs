using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemDataAccessLayer
{
    public  class Certificates
    {
        public static DataTable GatAllCertificates(int PageNumber)
        {
            DataTable Certificates = new DataTable();
            using(SqlConnection connection=new SqlConnection(ClsSettings.connectionString))

            {
                string Query = "exec GetAllCerificates @PageNumber;";
                using (SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@PageNumber", PageNumber);
                    connection.Open();
                    using(SqlDataReader reader=command.ExecuteReader() )
                    {
                      
                            Certificates.Load(reader);
                        
                        
                    }
                }
            }
            return Certificates;
        }
        public static bool AddNewCertificate( byte certificatePeriod, float certificatePrice, float totalProfit, decimal profitPercentage)
        {
            bool isAddedSuccessfully = false;

            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string query = "EXEC SP_AddNewCertificate @certificatePrice,@profitPercentage,@certificatePeriod,@totalProfit;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // إضافة المعلمات مع تحديد النوع والقيم
                    command.Parameters.Add("@CertificatePeriod", SqlDbType.SmallInt).Value = certificatePeriod;
                    command.Parameters.Add("@certificatePrice", SqlDbType.Float).Value = certificatePrice;
                    command.Parameters.Add("@totalProfit", SqlDbType.Float).Value = totalProfit;
                    command.Parameters.Add("@profitPercentage", SqlDbType.Float).Value = profitPercentage;

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
            }

            return isAddedSuccessfully;
        }
        public static bool FindCertificate(int certificateId, ref byte certificatePeriod, ref float certificatePrice, ref float totalProfit, ref decimal profitPercentage)
        {
            bool IsFounded = false;
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string query = "EXEC SP_GetCertificateById @CertificateId;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@CertificateId", SqlDbType.Int).Value = certificateId;

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFounded = true;
                                certificatePeriod = reader.GetByte(reader.GetOrdinal("CertificatePeriodPerYears"));
                                certificatePrice =float.Parse(reader["CertificatePrice"].ToString());
                                totalProfit =float.Parse(reader["TotalProfit"].ToString());
                                profitPercentage =decimal.Parse(reader["MonthlyProfitPercentage"].ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                }
            }
            return IsFounded;

        }
      public static bool UpdateCertificate(int certificateId, byte certificatePeriod, float certificatePrice, float totalProfit, decimal profitPercentage)
        {
            bool isUpdatedSuccessfully = false;

            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string query = "EXEC [SP_UpdateCertificate] @certificateId, @certificatePrice,@profitPercentage ,@certificatePeriod, @totalProfit;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@certificateId", certificateId);
                    command.Parameters.AddWithValue("@certificatePrice", certificatePrice);
                    command.Parameters.AddWithValue("@certificatePeriod", certificatePeriod);
                    command.Parameters.AddWithValue("@totalProfit", totalProfit);
                    command.Parameters.AddWithValue("@profitPercentage", profitPercentage);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            isUpdatedSuccessfully = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                }
            }

            return isUpdatedSuccessfully;
        }
        public static bool DeleteCertificate(int certificateId)
        {
            bool isDeletedSuccessfully = false;

            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string query = "EXEC [SP_DeleteCertificate] @certificateId;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@certificateId", certificateId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            isDeletedSuccessfully = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                }
            }

            return isDeletedSuccessfully;
        }

    }
}
