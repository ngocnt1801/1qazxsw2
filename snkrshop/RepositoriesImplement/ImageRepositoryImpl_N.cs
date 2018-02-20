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
    public partial class ImageRepositoryImpl : ImageRepository
    {
     

        public bool DeleteImageOfProduct(int imageId)
        {
            SqlConnection cnn = DBUtils.GetConnection();
            string sql = "DeleteImage";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ImageId", imageId);
            cmd.CommandType = CommandType.StoredProcedure;
            int result;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                result = cmd.ExecuteNonQuery();
            }catch(Exception ex)
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

        public string GetFirstImageOfProduct(int productId)
        {
            SqlConnection cnn = DBUtils.GetConnection();
            string sql = "GetFirstImageOfProduct";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ProductId", productId);
            cmd.CommandType = CommandType.StoredProcedure;
            string url = "";
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    url = (string)reader["url"];
                }
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
            return url;
        }
    }
}