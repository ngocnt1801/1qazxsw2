using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class User_ProductColor
    {
        public int ProductId { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }

        public User_ProductColor()
        {
        }

        public User_ProductColor(int productId, int colorId, string colorName)
        {
            ProductId = productId;
            ColorId = colorId;
            ColorName = colorName;
        }
    }
}