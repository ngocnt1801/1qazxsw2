using snkrshop.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snkrshop.Repositories
{
    partial interface ProductRepository
    {
        List<Product> GetListProduct( int sortByPrice, int sortById);
        List<Product> GetSearchProduct(string searchString);
        bool RatingProduct(int productId, string userId, int rate);
        List<Product> GetProductByCategory(int categoryId);
        bool DeleteProduct(int productId);
        bool AddProductColor(int productId, string color);
    }
}
