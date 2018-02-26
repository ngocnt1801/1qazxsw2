﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }

        public Category(string name, string description, int parentId)
        {
            Name = name;
            Description = description;
            ParentId = parentId;
        }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}