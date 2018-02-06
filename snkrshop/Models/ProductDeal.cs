using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class ProductDeal
    {
        public int DealId { get; set; }
        public int ProductId { get; set; }
        public int Discount { get; set; }
        public bool Type { get; set; }
    }
}