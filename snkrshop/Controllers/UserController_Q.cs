using snkrshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace snkrshop.Controllers
{
    public partial class UserController : ApiController
    {
        [Route("user/login")]
        [HttpPost]
        [AcceptVerbs("POST")]
        public int LoginUser(LoginForm loginForm)
        {
            return userService.LoginUser(loginForm.Username, loginForm.Password);
        }

        [Route("user/test")]
        [HttpPost]
        [AcceptVerbs("POST")]
        public HttpResponseMessage Test(String id)
        {
            return Request.CreateResponse<String>(HttpStatusCode.OK,"thanh cong " + id);
        }

        [Route("user/abc")]
        [HttpGet]
        public HttpResponseMessage Test2(String id)
        {
            return Request.CreateResponse<String>(HttpStatusCode.OK, "thanh cong " + id);
        }

        [Route("user/set/role")]
        [HttpPost]
        public string SetRole(string username, int role)
        {
            return userService.SetRole(username, role);
        }
    }
}