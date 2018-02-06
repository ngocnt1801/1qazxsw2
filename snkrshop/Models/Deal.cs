using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class Deal
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }
    }
}