using snkrshop.Repositories;
using snkrshop.RepositoriesImplement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace snkrshop.Controllers
{
    public class UserController : ApiController
    {
        public string Get()
        {
            return "test";
        }
        [Route("user/test")]
        public string test()
        {
            

        }

    }
}
