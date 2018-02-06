using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string Material { get; set; }
        public string color { get; set; }
        public int CategoryId { get; set; }
    }
}