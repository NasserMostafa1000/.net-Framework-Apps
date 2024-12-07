using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemDataAccessLayer
{
    public class ClsClients
    {
        public static  int AddNewClient(string FirstName,string LastName,string MidName,string Address,string IdentityNumber,float Balance, decimal Taxes,string ImagePath)
        {
            int ClientID = 0;
            using(SqlConnection connection=new SqlConnection(ClsSettings.connectionString))
            {
                string Query = "EXEC [SP_AddNewClient] @FirstName,@MidName,@Address,@IdentityNumber,@LastName,@Balance,@Taxes,@ImagePath;";
                using (SqlCommand command=new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@MidName", MidName);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@IdentityNumber", IdentityNumber);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Taxes", Taxes);
                    command.Parameters.AddWithValue("@Balance", Balance);
                    command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    try
                    {
                        connection.Open();

                        var result = command.ExecuteScalar();
                        if(result!=null&&int.TryParse(result.ToString(),out int InsertedID))
                        {
                            ClientID = Convert.ToInt32(result.ToString());

                        }
                    }
                    catch (Exception ex )
                    { ClsSettings.ErrorsToEventLog(ex); }

                }
            }
            return ClientID;
        }
        public static DataTable GetAllClient(int PageNumber)
        {
            DataTable AllCLients = new DataTable();
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                try
                {
                    string Query = "exec [GetAllClient] @PageNumber";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        connection.Open();

                        using (SqlDataReader READER = command.ExecuteReader())
                        {
                                AllCLients.Load(READER);
                        }
                    }
                }
                catch(Exception ex)
                {
                    ClsSettings.ErrorsToEventLog(ex);
                }
            }
            return AllCLients;
        }
        public static bool DeleteClient(int ClientID)
        {
            bool IsdeletedSuccess=false;
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {

                string query = "exec SP_DeleteClient @ClientID;";
                try
                {
                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@ClientID", ClientID);
                        connection.Open();
                        int RowAffect = command.ExecuteNonQuery();
                        if(RowAffect>0)
                        {
                            IsdeletedSuccess = true;
                        }
                    }
                }
                catch(Exception ex)
                {
                    ClsSettings.ErrorsToEventLog(ex);
                }
            }
            return IsdeletedSuccess; ;
        }
        public static DataTable FindClientWhereNameStartWith(string prefix)
        {
            DataTable Clients = new DataTable();
            using (SqlConnection connection=new SqlConnection(ClsSettings.connectionString))
            {
                string Query = "Exec SP_GetClientByPrefix @Prefix";
                using (SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@prefix", prefix);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            Clients.Load(Reader);
                        }
                    }catch(Exception ex)
                    {
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                }
            }
            return Clients;
        }
        public static bool FindClientById(int Id,ref string FirstName, ref string MidName, ref string Address, ref string Identitiynumber, ref string LastName, ref float Balance, ref decimal Taxes,ref  string ImagePath)
        {
            bool IsFounded = false;
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string Query = "Exec SP_GetClientById @Id";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFounded = true;
                                FirstName = Convert.ToString(reader["firstName"]);
                                MidName = Convert.ToString(reader["MidName"]);
                                Address = Convert.ToString(reader["Address"]);
                                Identitiynumber = Convert.ToString(reader["identityNumber"]);
                                LastName = Convert.ToString(reader["LastName"]);
                                Balance = float.Parse(reader["Balance"].ToString());
                                Taxes = Convert.ToDecimal(reader["Taxes"]);
                                ImagePath = Convert.ToString(reader["ImagePath"]);
                            }


                            }
                    }
                    catch (Exception ex)
                    {
                        IsFounded = false;
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                   
                }

            }
            return IsFounded;
        }
        public static bool UpdateClientById(int Id,string FirstaName,string MidName,string Address,string IdentityNumber,string LastName,float Balance, decimal Taxex,string ImagePath)
        {
            bool IsUpdatedSuccessfully = false;
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string query = "EXEC SP_UpdateClient @Id,@FirstaName,@MidName,@Address,@IdentityNumber,@LastName,@Balance,@Taxex,@ImagePath; "; 
                using (SqlCommand command=new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    command.Parameters.AddWithValue("@Id", Id);

                    command.Parameters.AddWithValue("@FirstaName", FirstaName);
                    command.Parameters.AddWithValue("@MidName", MidName);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@IdentityNumber", IdentityNumber);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Balance", Balance);
                    command.Parameters.AddWithValue("@Taxex", Taxex);

                    try
                    {
                        connection.Open();
                        int rowAffected = command.ExecuteNonQuery();
                        if(rowAffected>0)
                        {
                            IsUpdatedSuccessfully = true;
                        }

                        
                    }catch(Exception ex)
                    {
                        IsUpdatedSuccessfully = false;
                        ClsSettings.ErrorsToEventLog(ex);
                    }

                    return IsUpdatedSuccessfully;
                }
            }


        }
        public static bool Transer(int SenderID,int ReciverId,float Amount)
        {
            bool IsTransferdSuccessfully = false;
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string Query = "EXEC SP_Transfer @SenderID,@ReciverId,@Amount;";
                using (SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@SenderID", SenderID);
                    command.Parameters.AddWithValue("@ReciverId", ReciverId);
                    command.Parameters.AddWithValue("@Amount", Amount);

                    try
                    {
                        connection.Open();
                        int RowsAffected = command.ExecuteNonQuery();
                        if(RowsAffected>0)
                        {
                            IsTransferdSuccessfully = true;
                        }

                    }catch(Exception ex)
                    {
                        IsTransferdSuccessfully = false;
                        ClsSettings.ErrorsToEventLog(ex);
                    }
                }
            }
            return IsTransferdSuccessfully;
        }
        public static bool FindFullNameById(int Id, ref string FirstName, ref string MidName,ref string LastName)
        {
            bool IsFounded = false;
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                string Query = "select firstName,MidName,LastName from Clients where ClientID=@Id";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFounded = true;
                                FirstName = Convert.ToString(reader["firstName"]);
                                MidName = Convert.ToString(reader["MidName"]);
                                LastName = Convert.ToString(reader["LastName"]);
                             
                            }


                        }
                    }
                    catch (Exception ex)
                    {
                        IsFounded = false;
                        ClsSettings.ErrorsToEventLog(ex);
                    }

                }

            }
            return IsFounded;
        }


    }
}
