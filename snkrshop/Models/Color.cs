using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Color(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}