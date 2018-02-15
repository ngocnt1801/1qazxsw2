using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Services
{
    partial interface UserService
    {
        string Register(string username, string password, string fullname, string phone, string email, string address);
    }
}