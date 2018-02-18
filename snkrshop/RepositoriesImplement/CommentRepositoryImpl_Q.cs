﻿using snkrshop.Models;
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
        public bool AddcommentToProduct(int proId, string username, string title, string content)
        {
            SqlConnection cnn = DBUtils.GetConnection();
            string sql = "AddCommentOFProduct";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Content", content);
            cmd.Parameters.AddWithValue("@ProductId", proId);
            cmd.Parameters.AddWithValue("@AuthorId", username);
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

        public bool EditComment(int commentId, string title, string content)
        {
            SqlConnection cnn = DBUtils.GetConnection();
            string sql = "UpdateComment";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@CoId", commentId);
            cmd.Parameters.AddWithValue("@Content", content);
            cmd.Parameters.AddWithValue("@Title", title);
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
        
        public List<Comment> GetCommentInComment(int sortByTime, int parentId)
        {
            SqlConnection cnn = DBUtils.GetConnection();
            string sql = "GetCommentOfComment";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@CoId", parentId);
            cmd.CommandType = CommandType.StoredProcedure;
            List<Comment> result = new List<Comment>();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(
                        new Comment((int)reader["id"], (string)reader["title"], (string)reader["commentContent"], (DateTime)reader["time"], (int)reader["parentId"], (int)reader["productId"], (int)reader["postId"], (string)reader["authorId"])
                        );
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
            return result;
        }

        public List<Comment> GetCommentInPost(int sortByTime, int postId)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetCommentInProduct(int sortByTime, int ProductId)
        {
            throw new NotImplementedException();
        }

        public bool ReplyComment(int parentId, string username, string content)
        {
            SqlConnection cnn = DBUtils.GetConnection();
            string sql = "ReplyComment";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@Content", content);
            cmd.Parameters.AddWithValue("@ParentId", parentId);
            cmd.Parameters.AddWithValue("@AuthorId", username);
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