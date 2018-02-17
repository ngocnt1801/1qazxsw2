using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Services
{
    partial interface DealService
    {
        string DeleteDeal(int dealId);
        int AddDeal(string content, DateTime startTime, int duration);
    }
}