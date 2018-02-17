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
    public partial class ProductSizeRepositoryImpl : ProductSizeRepository
    {
        public bool AddProductSize(int productId, int size)
        {
            SqlConnection cnn = DBUtils.GetConnection();
            string sql = "AddProductSize";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ProductId", productId);
            cmd.Parameters.AddWithValue("@Size", size);

            cmd.CommandType = CommandType.StoredProcedure;
            int result;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                result = cmd.ExecuteNonQuery();
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
    }
}