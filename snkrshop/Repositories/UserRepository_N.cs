using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snkrshop.Repositories
{
    partial interface UserRepository
    {
        bool AddUser(string username, string password, string fullname, string email, string phone, string address);
        
    }
}
