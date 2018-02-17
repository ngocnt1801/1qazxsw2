using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snkrshop.Repositories
{
    interface ImageRepository_Q
    {
        bool AddImageToProduct(string url, int productId);
        
    }
}
