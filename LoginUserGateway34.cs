using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace LoginPanel1
{
    public class LoginUserGateway34
    {
        public UserLogin LoginUser(string userName, string passward)
        {
            UserLogin aUserLogin = new UserLogin();
            Command.Parameters.Clear();
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "sp_LoginUser";

            Command.Parameters.Add("@UserId", SqlDbType.VarChar, 200);
            Command.Parameters["@UserId"].Value = userName;
            Command.Parameters.Add("@Password", SqlDbType.VarChar, 200);
            Command.Parameters["@Password"].Value = passward;


            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        aUserLogin.UserId = reader["UserName"].ToString();
                        aUserLogin.RowCount++;

                    }
                }


            }
            catch (FormatException formatException)
            {
                throw new Exception("Error: " + formatException);

            }
            catch (Exception exception)
            {

                throw new Exception("Error: " + exception);
            }
            finally
            {
                if (Connection != null && Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }

            }
            return aUserLogin;
        }




        private readonly SqlCommand command;
        private readonly SqlConnection connection;

        public LoginUserGateway34()
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand();
        }

        public SqlConnection Connection
        {
            get { return connection; }
        }

        public SqlCommand Command
        {
            get
            {
                command.Connection = connection;
                return command;
            }
        }

        public SqlDataReader DataReader { get; set; }

        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["SOMCHConnectionString"].ConnectionString;
        }






    }
}