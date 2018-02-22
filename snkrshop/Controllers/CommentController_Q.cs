using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace snkrshop.Controllers
{
    public partial class CommentController : ApiController
    {
        [Route("comment/delete")]
        [HttpPost]
        public string AddcommentToProduct(int proId, string username, string title, string content)
        {
            return commentService.AddcommentToProduct(proId, username, title, content);
        }
        string ReplyComment(int parentId, string username, string content)
        {
            return commentService.ReplyComment( parentId, username, content);
        }
    }
}