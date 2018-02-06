using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class OrderVoucher
    {
        public string VoucherId { get; set; }
        public int OrderId { get; set; }
    }
}