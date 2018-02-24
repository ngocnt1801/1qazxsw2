using snkrshop.Services;
using snkrshop.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.ServicesImplement
{
    public partial class UserServiceImpl : UserService
    {
        public int LoginUser(string username, string password)
        {
            return userRepository.LoginUser(username, password);
        }
        public string SetRole(string username, int role)
        {
            string result = FAIL;
            try
            {
                if (userRepository.SetRole(username, role))
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