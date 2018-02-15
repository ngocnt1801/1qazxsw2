using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snkrshop.Repositories
{
    partial interface UserRepository
    {
        int processLogin(string username, string password);
        string getName(string username);
        bool updatePassword(string username, string newPassword);
        
    }
}
