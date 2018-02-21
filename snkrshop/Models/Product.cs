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
        public int CategoryId { get; set; }
        public int Quantity { get; set; }

        public Product(int productId, string name, string brand, double price, string size, string country, string description, string material, int categoryId, int quantity)
        {
            ProductId = productId;
            Name = name;
            Brand = brand;
            Price = price;
            Size = size;
            Country = country;
            Description = description;
            Material = material;
            CategoryId = categoryId;
            Quantity = quantity;
        }
    }
}