using snkrshop.Models;
using snkrshop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.RepositoriesImplement
{
    public partial class ProductRepositoryImpl : ProductRepository
    {
        public List<Product> GetListProduct(bool sortByDiscount, bool sortByPrice, bool sortById)
        {

        }
        public List<Product> GetSearchProduct(string searchString)
        {

        }
        public void RatingProduct(int productId);
        public List<Product> GetProductByCategory(int categoryId);
        public bool DeleteProduct(int productId);
        public bool AddProductColor(int productId, string color);
    }
}