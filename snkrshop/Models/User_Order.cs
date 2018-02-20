using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class User_Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
        public string UserId { get; set; }
        public int Discount { get; set; }
        public string VoucherId { get; set; }
        public bool Type { get; set; }
        public string StatusName { get; set; }
        public List<User_ProductOrder> Products { get; set; }

        public User_Order(int orderId, DateTime orderDate, double totalPrice, string userId, int discount, string voucherId, bool type, string statusName)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
            UserId = userId;
            Discount = discount;
            VoucherId = voucherId;
            Type = type;
            StatusName = statusName;
        }

        
    }
}