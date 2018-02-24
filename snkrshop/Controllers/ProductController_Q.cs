using snkrshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace snkrshop.Controllers
{
    public partial class ProductController : ApiController
    {
        [Route("product/getlist")]
        public List<Product> GetListProduct(int sortByPrice, int sortById)
        {
            return productService.GetListProduct(sortByPrice, sortById);
        }
        [Route("product/search")]
        public List<Product> GetSearchProduct(string searchString)
        {
            return productService.GetSearchProduct(searchString);
        }
        [Route("product/rating")]
        public string RatingProduct(int productId, string userId, int rate)
        {
            return productService.RatingProduct(productId, userId, rate);
        }
        [Route("product/getlist/bycategory")]
        public List<Product> GetProductByCategory(int categoryId)
        {
            return productService.GetProductByCategory(categoryId);
        }
        [Route("product/delete")]
        public string DeleteProduct(int productId)
        {
            return productService.DeleteProduct(productId);
        }
        [Route("product/add/color")]
        public string AddProductColor(int productId, string color)
        {
            return productService.AddProductColor(productId, color);
        }
    }
}