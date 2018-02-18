using snkrshop.Repositories;
using snkrshop.RepositoriesImplement;
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
    public partial class UserController : ApiController
    {
        UserService userService = new UserServiceImpl();
        [Route("user/register")]
        [HttpPost]
        public string Register(string username, string password, string fullname, string email, string phone, string address)
        {
            return userService.Register(username, password, fullname, phone, email, address);
        }

        [Route("user/delete")]
        public string DeleteUser(string username)
        {
            return userService.DeleteAccount(username);
        }

    }
}
