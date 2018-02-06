using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
        public int OrderStatus { get; set; }
        public string UserId { get; set; }
        public int GuestId { get; set; }
        public string ApprovederId { get; set; }
    }
}