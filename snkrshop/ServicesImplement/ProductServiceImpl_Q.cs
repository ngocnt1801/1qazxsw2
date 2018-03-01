using snkrshop.Models;
using snkrshop.Services;
using snkrshop.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.ServicesImplement
{
    public partial class ProductServiceImpl : ProductService
    {
        public List<Product> GetListProduct(int sortByPrice, int sortById)
        {
            List<Product> result = null;
            try
            {
                result = productRepository.GetListProduct(sortByPrice, sortById);
            }
            catch (Exception ex)
            {
                //ex.LogExceptionToFile();
                throw new Exception(ex.Message);
            }
            return result;
        }
        public List<User_Product_Item> GetSearchProduct(string searchString)
        {
            List<User_Product_Item> result = null;
            try
            {
                result = productRepository.GetSearchProduct(searchString);
            }
            catch (Exception ex)
            {
                //ex.LogExceptionToFile();
                throw new Exception(ex.Message);
            }
            return result;
        }
        public string RatingProduct(int productId, string userId, int rate)
        {
            string result = FAIL;
            try
            {
                if (productRepository.RatingProduct(productId, userId, rate))
                {
                    result = SUCCESS;
                }
            }
            catch (Exception ex)
            {
                //ex.LogExceptionToFile();
                throw new Exception(ex.Message);
            }
            return result;
        }
        public List<Product> GetProductByCategory(int categoryId)
        {
            List<Product> result = null;
            try
            {
                result = productRepository.GetProductByCategory(categoryId);
            }
            catch (Exception ex)
            {
                //ex.LogExceptionToFile();
                throw new Exception(ex.Message);
            }
            return result;
        }
        public string DeleteProduct(int productId)
        {
            string result = FAIL;
            try
            {
                if (productRepository.DeleteProduct(productId))
                {
                    result = SUCCESS;
                }
            }
            catch (Exception ex)
            {
                //ex.LogExceptionToFile();
                throw new Exception(ex.Message);
            }
            return result;
        }
        public string AddProductColor(int productId, string color)
        {
            string result = FAIL;
            try
            {
                if (productRepository.AddProductColor(productId, color))
                {
                    result = SUCCESS;
                }
            }
            catch (Exception ex)
            {
                ex.LogExceptionToFile();
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}