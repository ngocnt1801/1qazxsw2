﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Repositories
{
    partial interface OrderRepository
    {
        bool DeleteOrder(int orderId);
        bool CancelOrder(int orderId);
    }
}