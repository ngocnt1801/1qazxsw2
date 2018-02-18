using snkrshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snkrshop.Repositories
{
    partial interface CommentRepository
    {
        bool AddcommentToProduct(int proId, string username, string content);
        bool ReplyComment(int parentId, string username, string content);
        /// <summary>
        ///  load comment from newest -> oldest, pagination of post and product    
        /// </summary>
        /// <param name="sortByTime">1 to Ascending, 0 to no-sort, -1 to descending</param>
        /// <returns></returns>
        List<Comment> GetComment(int sortByTime);
        bool EditComment(int commentId, string content);

    }
}
