﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Repositories
{
    partial interface PostRepository
    {
        bool UpdatePost(int postId, string title, string content);
    }
}