using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Repositories
{
    partial interface ImageRepository
    {
        bool DeleteImageOfProduct(int imageId);
        string GetFirstImageOfProduct(int productId);
    }
}