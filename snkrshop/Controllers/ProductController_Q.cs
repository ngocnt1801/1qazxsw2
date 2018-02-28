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
        [Route("product/all")]
        [HttpGet]
        public List<Product> GetListProduct(int sortByPrice, int sortById)
        {
            return productService.GetListProduct(sortByPrice, sortById);
        }
        [Route("product/search")]
        [HttpGet]
        public List<Product> GetSearchProduct(string searchString)
        {
            return productService.GetSearchProduct(searchString);
        }
        [Route("product/rating")]
        [HttpPost]
        public string RatingProduct(int productId, string userId, int rate)
        {
            return productService.RatingProduct(productId, userId, rate);
        }
        [Route("product/get/category")]
        [HttpGet]
        public List<Product> GetProductByCategory(int categoryId)
        {
            return productService.GetProductByCategory(categoryId);
        }
        [Route("product/delete")]
        [HttpGet]
        public string DeleteProduct(int productId)
        {
            return productService.DeleteProduct(productId);
        }
        [Route("product/add/color")]
        [HttpPost]
        public string AddProductColor(int productId, string color)
        {
            return productService.AddProductColor(productId, color);
        }
    }
}