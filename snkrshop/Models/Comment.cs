using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string  Content { get; set; }
        public DateTime Time { get; set; }
        public int ParentID { get; set; }
        public int ProductId { get; set; }
        public int PostId { get; set; }
        public string AuthorId { get; set; }
    }
}