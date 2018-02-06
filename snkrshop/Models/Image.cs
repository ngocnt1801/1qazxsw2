using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class Image
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int PostId { get; set; }
        public string Url { get; set; }
    }
}