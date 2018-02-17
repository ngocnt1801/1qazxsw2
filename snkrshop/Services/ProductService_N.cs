using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Services
{
    partial interface ProductService
    {
        string DeleteImage(int imageId);
        string AddProductSize(int productId, int size);
    }
}