using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class Voucher
    {
        public string VoucherId { get; set; }
        public bool Type { get; set; }
        public int Discount { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }
        public int Amount { get; set; }
    }
}