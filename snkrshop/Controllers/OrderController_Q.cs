using snkrshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace snkrshop.Controllers
{
    public partial class OrderController : ApiController
    {
        [Route("order/history")]
        public List<Order> GetOrderHistory(string userId)
        {
            return this.orderService.GetOrderHistory(userId);
        }
        [Route("order/notapproved")]
        public List<Order> GetOrdersNotApproved()
        {
            return this.orderService.GetOrdersNotApproved();
        }
        public List<Order> GetListOrder(int sortByTime)
        {
            return this.orderService.GetListOrder(sortByTime);
        }

    }
}