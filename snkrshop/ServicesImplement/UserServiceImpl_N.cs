using snkrshop.Repositories;
using snkrshop.RepositoriesImplement;
using snkrshop.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace snkrshop.ServicesImplement
{
    public partial class UserServiceImpl : UserService
    {
        const string SUCCESS = "success";
        const string FAIL = "fail";
        const string DUPLICATE = "duplicate";
        UserRepository userRepository;

        public UserServiceImpl()
        {
            userRepository = new UserRepositoryImpl();
        }
        public string Register(string username, string password, string fullname, string phone, string email, string address)
        {
            string result = FAIL;
            try
            {
               if ( userRepository.AddUser(username, password, fullname, email, phone, address))
                {
                    result = SUCCESS;
                }

            }
            catch (SqlException se)
            {
                if (se.Message.Contains("duplicate"))
                {
                    result =  DUPLICATE;
                }
            }catch (Exception ex)
            {
                result = FAIL;
                
            }
            return result;
        }
    }
}