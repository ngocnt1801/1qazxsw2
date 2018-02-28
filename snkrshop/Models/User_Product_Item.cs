using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace snkrshop.Models
{
    [DataContract]
    public class User_Product_Item
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Discount { get; set; }
        [DataMember]
        public DateTime StartTime { get; set; }
        [DataMember]
        public bool Type { get; set; }
        [DataMember]
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