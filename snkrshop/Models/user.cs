using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string fullname { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
        public int gender { get; set; }
        public int role { get; set; }
        public DateTime regisDate { get; set; }
    }
}