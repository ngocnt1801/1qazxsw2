﻿using snkrshop.Repositories;
using snkrshop.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace snkrshop.RepositoriesImplement
{
    public partial class UserRepositoryImpl : UserRepository
    {
        public bool AddUser(string username, string password, string fullname, string email, string phone, string address)
        {
            SqlConnection cnn = DBUtils.GetConnection();
            string sql = "AddUser";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Username",username));
            cmd.Parameters.Add(new SqlParameter("@Password",password));
            cmd.Parameters.Add(new SqlParameter("@Fullname",fullname));
            cmd.Parameters.Add(new SqlParameter("@Phone",phone));
            cmd.Parameters.Add(new SqlParameter("@Email",email));
            cmd.Parameters.Add(new SqlParameter("@Address",address));
            int result;
            try
            {
               if(cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                 result = cmd.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            return result > 0;
        }

        public string model()
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

       
    }
}