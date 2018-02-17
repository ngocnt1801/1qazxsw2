using snkrshop.Services;
using snkrshop.ServicesImplement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace snkrshop.Controllers
{
    public partial class DealController : ApiController
    {
        DealService dealService = new DealServiceImpl();
        [Route("deal/delete")]
        public string DeleteDeal(int dealId)
        {
            return this.dealService.DeleteDeal(dealId);
        }

        [Route("deal/add")]
        [HttpPost]
        public int AddDeal(string content, DateTime startTime, int duration)
        {
            return this.dealService.AddDeal(content, startTime, duration);
        }

        [Route("deal/product/add")]
        public string AddProductDeal(int dealId, int productId, int discount, bool type)
        {
            return this.dealService.AddProductDeal(dealId, productId, discount, type);
        }
    }
}
