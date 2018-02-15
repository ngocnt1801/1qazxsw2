using snkrshop.Repositories;
using snkrshop.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace snkrshop.RepositoriesImplement
{
    public class UserRepositoryImpl : UserRepository
    {
        public string getName(string username)
        {
            return "";
        }

        public string getName()
        {
            String sql = "Select * from tbl_user";
            SqlConnection cnn = DBUtils.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    
                    return reader.GetString(1);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return "nothing";
        }

        public int processLogin(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool updatePassword(string username, string newPassword)
        {
            throw new NotImplementedException();
        }
    }
}