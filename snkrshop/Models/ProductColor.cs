using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class ProductColor
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Color { get; set; }
    }
}