using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class User_ProductOrder
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Brand { get; set; }
        public float Price { get; set; }
        public string Size { get; set; }
        public string Country { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public string ImageUrl { get; set; }

        public User_ProductOrder(int productId, string productName, int quantity, string brand, float price, string size, string country, string material, string color)
        {
            ProductId = productId;
            ProductName = productName;
            Quantity = quantity;
            Brand = brand;
            Price = price;
            Size = size;
            Country = country;
            Material = material;
            Color = color;
        }
    }
}