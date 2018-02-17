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
        List<Product> GetListProduct(bool sortByDiscount, bool sortByPrice, bool sortById);
        List<Product> GetSearchProduct(string searchString);
        void RatingProduct(int productId);
        List<Product> GetProductByCategory(int categoryId);
        bool DeleteProduct(int productId);
        bool AddProductColor(int productId, string color);//
    }
}
