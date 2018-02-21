using snkrshop.Models;
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
    public partial class ProductRepositoryImpl : ProductRepository
    {
        public List<Product> GetListProduct( int sortByPrice, int sortById)
        {
            SqlConnection cnn = DBUtils.GetConnection();
            string sql = "View_AllProduct";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            List<Product> result = new List<Product>();
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
                            new Product((int)reader["productId"],(string)reader["name"], (string)reader["brand"], (double)reader["price"], (string)reader["brand"],
                            (string)reader["country"], (string)reader["description"], (string)reader["material"], (int)reader["categoryID"], (int)reader["quantity"])
                        );
                }
                result = sortList(result, sortByPrice, sortById);

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
        public List<Product> GetSearchProduct(string searchString)
        {
            
        }
        public bool RatingProduct(int productId, string userId, int rate)
        {
            SqlConnection cnn = DBUtils.GetConnection();
            string sql = "RatingProduct";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ProductId", productId);
            cmd.Parameters.AddWithValue("@UserId", userId);
            cmd.Parameters.AddWithValue("@Rate", rate);
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
        public List<Product> GetProductByCategory(int categoryId)
        {
            SqlConnection cnn = DBUtils.GetConnection();
            string sql = "ProductListByCategory";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@CategoryId", categoryId);
            cmd.CommandType = CommandType.StoredProcedure;
            List<Product> result = new List<Product>();
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
                            new Product((int)reader["productId"], (string)reader["name"], (string)reader["brand"], (double)reader["price"], (string)reader["brand"],
                            (string)reader["country"], (string)reader["description"], (string)reader["material"], (int)reader["categoryID"], (int)reader["quantity"])
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
        public bool DeleteProduct(int productId)
        {
            SqlConnection cnn = DBUtils.GetConnection();
            string sql = "DeleteProduct";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ProductId", productId);
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
        public bool AddProductColor(int productId, string color)
        {
            SqlConnection cnn = DBUtils.GetConnection();
            string sql = "AddProductColor";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ProductId", productId);
            cmd.Parameters.AddWithValue("@Color", color);
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

        private List<Product> sortList(List<Product> list, int sortByPrice, int sortById)
        {
            List<Product> sortedList = new List<Product>();
            //sort by Id
            if (sortById >= 1)
            {
                sortedList = list.OrderBy(o => o.ProductId).ToList();
            }
            else if (sortById <= -1)
            {
                sortedList = list.OrderByDescending(o => o.ProductId).ToList();
            }
            else
            {
                sortedList = list;
            }
            //sort by price
            if (sortByPrice >= 1)
            {
                sortedList = list.OrderBy(o => o.Price).ToList();
            }
            else if (sortByPrice <= -1)
            {
                sortedList = list.OrderByDescending(o => o.Price).ToList();
            }
            else
            {
                sortedList = list;
            }
            //sort by Discount - not ready
            //if (sortByDiscount >= 1)
            //{
            //    sortedList = list.OrderBy(o => o.dis).ToList();
            //}
            //else if (sortByDiscount <= -1)
            //{
            //    sortedList = list.OrderByDescending(o => o.Price).ToList();
            //}
            //else
            //{
            //    sortedList = list;
            //}

            return sortedList;
        }
    }
}