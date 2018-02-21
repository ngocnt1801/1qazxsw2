﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class ProductQuantity
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public ProductQuantity()
        {
        }

        public ProductQuantity(int productId, int quantity)
        {
            ProductId = productId;
            Quantity = quantity;
        }
    }
}