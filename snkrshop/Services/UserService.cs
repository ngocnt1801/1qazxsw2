using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Services
{
    interface UserService
    {
        int checkLogin(string username, string password);
        string getUserName();
        bool resetPassword(string oldPassword, string newPassword, string confirmPassword);
    }
}