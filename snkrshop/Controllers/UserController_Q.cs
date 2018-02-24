using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace snkrshop.Controllers
{
    public partial class UserController : ApiController
    {
        [Route("user/login")]
        [HttpPost]
        public int LoginUser(string username, string password)
        {
            return userService.LoginUser(username, password);
        }
        [Route("user/set/role")]
        [HttpPost]
        public string SetRole(string username, int role)
        {
            return userService.SetRole(username, role);
        }
    }
}