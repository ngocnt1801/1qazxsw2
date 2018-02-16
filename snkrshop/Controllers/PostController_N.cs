using snkrshop.Services;
using snkrshop.ServicesImplement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace snkrshop.Controllers
{
    public partial class PostController : ApiController
    {
        CommentService commentService = new CommentServiceImpl();

        [Route("post/comment/add")]
        public string AddCommentInPost(string title, string content, int postId, string authorId)
        {
            return commentService.AddCommentToPost(title, content, postId, authorId);
        }
    }
}
