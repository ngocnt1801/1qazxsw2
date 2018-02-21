using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class User_ProductSize
    {
        public int ProductId { get; set; }
        public int SizeId { get; set; }
        public string SizeName { get; set; }

        public User_ProductSize()
        {
        }

        public User_ProductSize(int productId, int sizeId, string sizeName)
        {
            ProductId = productId;
            SizeId = sizeId;
            SizeName = sizeName;
        }
    }
}