﻿using snkrshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace snkrshop.Controllers
{
    public partial class PostController : ApiController
    {
        [Route("post/get")]
        public List<Post> GetListPost(int sortTime)
        {
            return this.postService.GetListPost(sortTime);
        }
        [Route("post/delete")]
        public string DeletePost(int postId)
        {
            return this.postService.DeletePost(postId);
        }
    }
}