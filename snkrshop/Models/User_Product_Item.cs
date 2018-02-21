using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class User_Product_Item
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Discount { get; set; }
        public DateTime StartTime { get; set; }
        public bool Type { get; set; }
        public float Price { get; set; }
        public User_Product_Item(int productId, string name, float price, int discount, DateTime startTime, bool type)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            Discount = discount;
            StartTime = startTime;
            Type = type;
        }
    }
}