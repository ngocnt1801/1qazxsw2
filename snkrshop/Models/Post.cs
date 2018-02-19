using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PostTime { get; set; }
        public string UserId { get; set; }

        public Post(int id, string title, string content, DateTime postTime, string userId)
        {
            Id = id;
            Title = title;
            Content = content;
            PostTime = postTime;
            UserId = userId;
        }
    }
}