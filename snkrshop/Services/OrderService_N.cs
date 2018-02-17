using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Services
{
    partial interface OrderService
    {
        string DeleteOrder(int orderId);
        string CancelOrder(int orderId);
        string ApproveOrder(int orderId);
    }
}