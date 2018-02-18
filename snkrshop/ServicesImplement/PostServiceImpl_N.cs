using snkrshop.Repositories;
using snkrshop.Services;
using snkrshop.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.ServicesImplement
{
    public partial class PostServiceImpl : PostService
    {
        const string FAIL = "fail";
        const string SUCCESS = "success";

        PostRepository postRepository;

        public PostServiceImpl()
        {
            this.postRepository = new PostRepositoryImpl();
        }

        public string UpdatePost(int postId, string title, string content)
        {
            string result = FAIL;
            try
            {
                if (postRepository.UpdatePost(postId, title, content))
                {
                    result = SUCCESS;
                }
            }
            catch (Exception ex)
            {
                ex.LogExceptionToFile();
                throw new Exception(ex.Message);


            }
            return result;
        }
    }
}