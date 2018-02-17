using snkrshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snkrshop.Repositories
{
    partial interface OrderRepository_Q
    {
        List<Order> GetOrderHistory(string userId);

    }
}
