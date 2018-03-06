using Newtonsoft.Json.Linq;
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
        public int LoginUser(JObject jsonData)
        {
            dynamic json = jsonData;
            string username = json.username;
            string password = json.password;
            return userService.LoginUser(username, password);
        }
        [Route("user/set/role")]
        [HttpPost]
        public string SetRole(string username, int role)
        {
            return userService.SetRole(username, role);
        }
        [Route("user/test")]
        [HttpPost]
        //[AcceptVerbs("POST")]
        public string Test(JObject jsonData)
        {
            dynamic json = jsonData;
            string username = json.username;
            return "thanh cong roi " + username.Length  +"!!!";
        }

        [Route("user/test2")]
        [HttpGet]
        public string Test2(String id)
        {
            return "thanh cong " + id;

        }

    }
}