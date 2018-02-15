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
    public partial class CommentRepositoryImpl : CommentRepository
    {
         

        public bool DeleteComment(int commentId)
        {
            SqlConnection cnn = DBUtils.GetConnection();
            string sql = "DeleteComment";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@CoId",commentId);
            cmd.CommandType = CommandType.StoredProcedure;
            
            int result;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                result = cmd.ExecuteNonQuery();
            }catch(Exception se)
            {
                throw new Exception(se.Message);
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