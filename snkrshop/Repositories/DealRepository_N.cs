using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Repositories
{
    partial interface DealRepository
    {
        bool DeleteDeal(int dealId);
    }
}