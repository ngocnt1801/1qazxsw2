using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace snkrshop.Models
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public string Size { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Material { get; set; }
        [DataMember]
        public int CategoryId { get; set; }
        [DataMember]
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