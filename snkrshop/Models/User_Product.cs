using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class User_Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public float Price { get; set; }
        public List<Size> Sizes { get; set; }
        public List<Color> Colors { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string Material { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public bool Type { get; set; }
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }

        public User_Product(int productId, string name, string brand, float price, string country, string description, string material, int quantity, int discount, bool type, DateTime startTime, int duration)
        {
            ProductId = productId;
            Name = name;
            Brand = brand;
            this.Price = price;
            Country = country;
            Description = description;
            Material = material;
            Quantity = quantity;
            Discount = discount;
            Type = type;
            StartTime = startTime;
            Duration = duration;
        }
    }
}