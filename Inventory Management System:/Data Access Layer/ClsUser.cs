using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemDataAccessLayer
{
    public class ClsUser
    {
        public static bool IsThisUserExists(string Email,string Password )
        {
            bool IsExists = false;
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string Query = "EXEC [SP_ISThisUserExists]@Email,@Password;";
                using (SqlCommand command=new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Password", Password);
                    try
                    {
                        connection.Open();
                    using (SqlDataReader reader=command.ExecuteReader())
                        {
                          
                                IsExists = reader.HasRows;
                            
                        }

                    }catch(Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }


                }
            }
            return IsExists;

        }
    }
}
