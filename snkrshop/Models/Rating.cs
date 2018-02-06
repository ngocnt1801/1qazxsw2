using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class Rating
    {
        public int ProductId { get; set; }
        public string UserId { get; set; }
        public int Rate { get; set; }
    }
}