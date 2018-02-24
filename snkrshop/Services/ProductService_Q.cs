using snkrshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snkrshop.Services
{
    partial interface ProductService
    {
        List<Product> GetListProduct(int sortByPrice, int sortById);
        List<Product> GetSearchProduct(string searchString);
        string RatingProduct(int productId, string userId, int rate);
        List<Product> GetProductByCategory(int categoryId);
        string DeleteProduct(int productId);
        string AddProductColor(int productId, string color);
    }
}
