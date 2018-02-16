using snkrshop.Services;
using snkrshop.ServicesImplement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace snkrshop.Controllers
{
    public partial class OrderController:ApiController
    {
        OrderService orderService = new OrderServiceImpl();

        [Route("order/delete")]
        public string DeleteOrder(int orderId)
        {
            return this.orderService.DeleteOrder(orderId);
        }
        [Route("order/cancel")]
        public string CancelOrder(int orderId)
        {
            return this.orderService.CancelOrder(orderId);
        }
    }
}