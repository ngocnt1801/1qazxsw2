using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snkrshop.Repositories
{
    partial interface UserRepository
    {
        int LoginUser(string username, string password);
        bool SetRole(string username, int role);
    }
}
